using StudySchedule.Application.DTOs.ProfissionalEspecialidade;
using StudySchedule.Infrastructure.Repositories.ProfissionalEspecialidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.Services.ProfissionalEspecialidade
{
    public class ProfissionalEspecialidadeService
    {
        private readonly ProfissionalEspecialidadeRepository _repo;

        public ProfissionalEspecialidadeService(ProfissionalEspecialidadeRepository repo)
        {
            _repo = repo;
        }

        public List <ProfissionalEspecialidadeDto>Buscar(int? id = null, int? profissionalId = null, int? especialidadeId = null)
        {
            return _repo.Buscar(id, profissionalId, especialidadeId);
        }

        public (bool ok, string msg, int? id) Inserir(int profissionalId, int especialidadeId, DateTime data, TimeSpan horario)
        {
            try
            {
                
                var id = _repo.Inserir(profissionalId, especialidadeId, data, horario);
                return (true, "Jornada cadastrada com sucesso!", null);

            }
            catch (Exception ex) {
                return (false, ex.Message, null);
            }
        }
    }
}
