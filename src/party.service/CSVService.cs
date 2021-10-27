using Microsoft.Extensions.Options;
using party.core.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace party.service
{
    public class CSVService : ICSVService
    {
        protected readonly string CSVSeparationLetter;

        public CSVService(IOptionsSnapshot<Configuracion> configuracion)
        {
            CSVSeparationLetter = configuracion.Value.CSVSeparationLetter;
        }
        public async Task<IList<Invitado>> ReadFileInvitados(string filename, IProgress<int> updateProgress)
        {
            IList<Invitado> invitados = new List<Invitado>();
            await Task.Run(() =>
            {
                string[] lineas = File.ReadAllLines(filename, Encoding.GetEncoding("iso-8859-15"));
                updateProgress.Report(0);
                for (int lineaId = 1; lineaId < lineas.Length; lineaId++)
                {
                    Invitado invitado = ConvertLineToInvitado(lineas[lineaId]);
                    invitados.Add(invitado);
                    updateProgress.Report((100 * lineaId) / lineas.Length);
                }
                updateProgress.Report(100);
            });
            return invitados;
        }

        public Invitado ConvertLineToInvitado(string linea)
        {
            var campos = linea.Split(new char[] { Convert.ToChar(CSVSeparationLetter) });
            Invitado invitado = new()
            {
                Codigo = Convert.ToInt32(campos[0]),
                Evento = campos[1],
                Asistencia = campos[2],
                EventoLocal = campos[3],
                Email = campos[4],
                Nombre = campos[5],
                Oficina = campos[6],
                DNI = campos[7],
                Extra = campos[8]
            };
            return invitado;



        }

        public void WriteCSV<T>(IEnumerable<T> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                .OrderBy(p => p.Name);

            using var writer = new StreamWriter(path);
            writer.WriteLine(string.Join(CSVSeparationLetter, props.Select(p => p.Name)));

            foreach (var item in items)
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
            }
        }
    }
}
