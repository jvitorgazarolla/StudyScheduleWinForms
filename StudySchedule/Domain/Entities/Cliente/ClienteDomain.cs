using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Domain.Entities.Cliente
{
    public class ClienteDomain
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }

        public string Observacao { get; set; }

        public string Sexo { get; set; }

        public ClienteDomain(string nome, DateTime data_nascimento, string telefone, string observacao, string sexo)
        {
            Validar(nome, data_nascimento, telefone);
            Nome = nome;
            DataNascimento = data_nascimento;
            Telefone = telefone;
            Observacao = observacao;
            Sexo = sexo;
        }

        private void Validar(string nome, DateTime data_nascimento, string telefone)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome é obrigatório");
            }

            if (string.IsNullOrWhiteSpace(telefone))
            {
                throw new Exception("Telefone é obrigatório");
            } 

        }
    }
}
