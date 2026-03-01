

using StudySchedule.Application.DTOs.Cliente;
using StudySchedule.Domain.Entities.Cliente;
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

        public (bool ok, string msg, int? id)Inserir(string nome, string email, DateTime data_nascimento, string telefone, string observacao, string sexo)
        {
            try
            {
                var cliente = new ClienteDomain(nome, email, data_nascimento, telefone, observacao, sexo);

                var id = _repo.Inserir(cliente);
                return (true, "Cliente inserido com sucesso!", null);

            }
            catch (Exception ex) {
                return (false, ex.Message, null);
            }
        }
        public (bool ok, string msg, int? id) Atualizar(int id, string nome , string email, DateTime data_nascimento, string telefone, string observacao, string sexo)
        {
            try
            {
                var cliente = new ClienteDomain(id, nome, email, data_nascimento, telefone, observacao, sexo);
                _repo.Atualizar(cliente);
                return (true, "Cliente atualizado com sucesso!", null);

            }catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }
        public List<ClienteDto>Buscar(string nome)
        {
             return _repo.Buscar(nome);
        }

    }
}
