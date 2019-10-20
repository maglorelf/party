using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace party
{
    public class CSVService
    {
        public string CSVSeparationLetter { get; set; }

        public CSVService(string separationLetter)
        {
            CSVSeparationLetter = separationLetter;
        }
        public IList<Invitado> ReadFileInvitados(string filename)
        {
            string[] lineas = File.ReadAllLines(filename);
            IList<Invitado> invitados = new List<Invitado>();
            for (int lineaId = 0; lineaId < lineas.Count(); lineaId++)
            {
                Invitado invitado = ConvertLineToInvitado(lineas[lineaId]);
                invitados.Add(invitado);
            }
            return invitados;
        }

        public Invitado ConvertLineToInvitado(string linea)
        {
            var campos = linea.Split(new char[] { Convert.ToChar(CSVSeparationLetter) });
            Invitado invitado = new Invitado
            {
                Nombre = campos[0],
                Apellidos = campos[1],
                Email = campos[2],
                DNI = campos[3],
                QR = campos[4]
            };
            return invitado;



        }

        public void WriteCSV<T>(IEnumerable<T> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                .OrderBy(p => p.Name);

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(CSVSeparationLetter, props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }
    }
}
