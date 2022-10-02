namespace party.service.data
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Data.Sqlite;
    using party.core.model;
    public interface IDataService
    {
        bool DatabaseReady { get; set; }
        void ActualizarNotasInvitado(Invitado invitado);
        void BorrarAsistente(int id);
        string CheckDatabase();
        SqliteConnection CreateConnection();
        IList<Asistente> GetAllAsistentes();
        IList<Invitado> GetAllInvitados();
        IList<Invitado> GetAllInvitadosView();
        Asistente GetAsistenteByIdInvitado(int id);
        int GetCountAsistentes();
        int GetCountInvitados();
        int GetCountInvitadosEvento(string eventoLocal);
        Invitado GetInvitadoByEmail(string email);
        void InitializeDatabase();
        void InsertAsistente(Asistente asistente);
        void InsertInvitadoManual(Invitado invitado);
        void LoadInvitados(IList<Invitado> invitadosLeidos, IProgress<int> updateProgress);
    }
}
