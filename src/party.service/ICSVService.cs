namespace party.service
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using party.core.model;
    public interface ICSVService
    {
        Invitado ConvertLineToInvitado(string linea);
        Task<IList<Invitado>> ReadFileInvitados(string filename, IProgress<int> updateProgress);
        void WriteCSV<T>(IEnumerable<T> items, string path);
    }
}
