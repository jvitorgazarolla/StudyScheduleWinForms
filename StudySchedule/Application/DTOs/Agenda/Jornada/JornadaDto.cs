using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.Agenda.Jornada
{
    public class JornadaDto
    {
        public string NomeProfissional { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Data { get; set; }
    }
}
