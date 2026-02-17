using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.Usuario
{
    public class UsuarioDto
    {
        public int Id {  get; set; }
        public required string Nome { get; set; }
        public required string Usuario { get; set; }
    }
}
