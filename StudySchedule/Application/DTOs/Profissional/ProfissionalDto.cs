using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.Profissional
{
    public class ProfissionalDto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Status { get; set; }

        public int EspecialidadeId { get;set; }

        public string EspecialidadeNome { get; set; }
    }
}
