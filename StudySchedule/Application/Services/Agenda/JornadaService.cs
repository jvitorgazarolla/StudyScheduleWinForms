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

        public (bool ok, string msg, int? id)Inserir(int  profissionalId, int profissionalEspecialidadeId, DateTime data, TimeSpan horario)
        {

            try
            {
                var id = _repo.Inserir(profissionalId, profissionalEspecialidadeId, data, horario);
                return (true, "Jornada cadastrada com sucesso", id);

            }
            catch (Exception ex) {
                return (false, ex.Message, null);
            }
        }
    }
}
