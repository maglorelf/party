using party.core.model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace party.service
{
    public interface ICSVService
    {
        Invitado ConvertLineToInvitado(string linea);
        Task<IList<Invitado>> ReadFileInvitados(string filename, IProgress<int> updateProgress);
        void WriteCSV<T>(IEnumerable<T> items, string path);
    }
}