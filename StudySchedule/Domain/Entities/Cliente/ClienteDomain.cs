using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Domain.Entities.Cliente
{
    public class ClienteDomain
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Email {  get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
        public string Sexo { get; set; }


        public ClienteDomain(string nome, string email , DateTime data_nascimento, string telefone, string observacao, string sexo)
        {
            Validar(nome, email, data_nascimento, telefone);
            Nome = nome;
            Email = email;
            DataNascimento = data_nascimento;
            Telefone = telefone;
            Observacao = observacao;
            Sexo = sexo;
        }
        public ClienteDomain(int id)
        {
            Id = id;
        }

        public ClienteDomain(int id, string nome, string email, DateTime data_nascimento, string telefone, string observacao, string sexo) :
            this(nome, email, data_nascimento, telefone, observacao, sexo)
        {
            Id = id;
        }

        private void Validar(string nome, string email, DateTime data_nascimento, string telefone)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome é obrigatório");
            }

            if (string.IsNullOrWhiteSpace(telefone))
            {
                throw new Exception("Telefone é obrigatório");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email é obrigatório");
            }
        }
    }
}
