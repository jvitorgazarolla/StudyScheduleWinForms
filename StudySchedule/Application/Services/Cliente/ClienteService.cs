using StudySchedule.Infrastructure.Repositories.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.Services.Cliente
{
    public class ClienteService
    {
        private readonly ClienteRepository _repo;

        public ClienteService()
        {
            var repo = new ClienteRepository();
            _repo = repo;
        }

        public (bool ok, string msg, int? id)Inserir(string nome, DateTime data_nascimento, string telefone, string sexo, string observacao)
        {
            try
            {
                var id = _repo.Inserir(nome, data_nascimento,telefone, sexo, observacao);
                return (true, "Cliente inserido com sucesso!", id);

            }
            catch (Exception ex) {
                return (false, ex.Message, null);
            }
        }

    }
}
