using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.ProfissionalEspecialidade
{
    public class ProfissionalEspecialidadeDto
    {
        public int Id {  get; set; }
        public int ProfissionalId { get; set; }
        public int EspecialidadeId { get; set; }
        public required string Descricao {  get; set; }
    }
}
