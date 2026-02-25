using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.Agenda.Jornada
{
    public class JornadaDto
    {
        public int Id { get; set; }
        public int ProfissionalId { get; set; }
        public required string NomeProfissional { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public TimeSpan Duracao { get; set; }
    }
}
