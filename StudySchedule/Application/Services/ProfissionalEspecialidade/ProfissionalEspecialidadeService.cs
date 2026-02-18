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

    }
}
