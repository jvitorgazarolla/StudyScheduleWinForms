using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using StudySchedule.Application.DTOs.Cliente;
using StudySchedule.Domain.Entities.Cliente;
using StudySchedule.Infrastructure.Data;

namespace StudySchedule.Infrastructure.Repositories.Cliente
{
    public class ClienteRepository
    {
        public int Inserir(ClienteDomain cliente)
        {
            return Db.Inserir<int>(
                "cadastro_cliente_inserir",
                SqlParam.In("@nome", SqlDbType.NVarChar, cliente.Nome),
                SqlParam.In("@data_nascimento", SqlDbType.Date, cliente.DataNascimento),
                SqlParam.In("@telefone", SqlDbType.VarChar, cliente.Telefone),
                SqlParam.In("sexo", SqlDbType.Char, cliente.Sexo),
                SqlParam.In("@observacao", SqlDbType.NVarChar, cliente.Observacao)
            );
        }

        public List<ClienteDto> Buscar(string nome) {
            return Db.Buscar<ClienteDto>(
                 "cadastro_cliente_buscar",
                 reader => new ClienteDto
                 {
                     Nome = reader.GetString(reader.GetOrdinal("nome")),
                     DataNascimento = reader.GetDateTime(reader.GetOrdinal("data_nascimento"))
                 },
                 SqlParam.In("@nome", SqlDbType.NVarChar, nome)
            );
        } 
    }
}
