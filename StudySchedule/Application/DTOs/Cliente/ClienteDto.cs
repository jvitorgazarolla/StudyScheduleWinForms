using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.Cliente
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }

        public string Observacao { get; set; }

        public string Sexo { get; set; }
    }
}
