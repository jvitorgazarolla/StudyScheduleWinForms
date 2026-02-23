using StudySchedule.Application.DTOs.Agenda.Jornada;
using StudySchedule.Infrastructure.Repositories.Agenda;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.Services.Agenda
{
    public class JornadaService
    {
        private readonly JornadaRepository _repo;
        public JornadaService()
        {
            var repo = new JornadaRepository();
            _repo = repo;
        }
        public List<JornadaDto>Buscar(string? nomeProfissional = null,  DateTime? data = null, TimeSpan? horaInicio = null, TimeSpan? horaFim = null)
        {
            return _repo.Buscar(nomeProfissional, data, horaInicio, horaFim);
        }
        public (bool ok, string msg, int? id)Inserir(int  profissionalId,  DateTime data, TimeSpan horaInicio, TimeSpan horaFim)
        {
            try
            {
                var id = _repo.Inserir(profissionalId, data, horaInicio, horaFim);
                return (true, "Jornada cadastrada com sucesso", id);

            }
            catch (Exception ex) {
                return (false, ex.Message, null);
            }
        }
        public (bool ok, string msg, int? id)Editar(int id, int? profissionalId = null, int? especialidadeId = null, DateTime? data = null, TimeSpan?  hora = null)
        {
            var result = _repo.Editar(id, profissionalId, especialidadeId, data, hora);
            return (true, "Jornada Atualiazda com sucesso!", null);
        }
    }
}
