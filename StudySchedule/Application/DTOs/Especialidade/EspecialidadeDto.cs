using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.Especialidade
{
    public class EspecialidadeDto
    {
        public int Id {  get; set; }
        public required string Descricao {  get; set; }

        public required Boolean Status { get; set; }
    }
}
