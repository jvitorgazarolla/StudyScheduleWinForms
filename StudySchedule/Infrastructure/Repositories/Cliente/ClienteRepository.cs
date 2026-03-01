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
                SqlParam.In("email", SqlDbType.NVarChar, cliente.Email),
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
                     Id = reader.GetInt32(reader.GetOrdinal("id")),
                     Nome = reader.GetString(reader.GetOrdinal("nome")),
                     Email = reader.GetString(reader.GetOrdinal("email")),
                     DataNascimento = reader.GetDateTime(reader.GetOrdinal("data_nascimento")),
                     Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                     Sexo = reader.GetString(reader.GetOrdinal("sexo")),
                     Observacao = reader.GetString(reader.GetOrdinal("observacao"))
                 },
                 SqlParam.In("@nome", SqlDbType.NVarChar, nome)
            );
        }

        public bool Atualizar(ClienteDomain cliente)
        {
            return Db.Atualizar(
               "cadastro_cliente_atualizar",
                SqlParam.In("@id", SqlDbType.Int, cliente.Id),
                SqlParam.In("@nome", SqlDbType.NVarChar, cliente.Nome),
                SqlParam.In("email", SqlDbType.NVarChar, cliente.Email),
                SqlParam.In("@data_nascimento", SqlDbType.Date, cliente.DataNascimento),
                SqlParam.In("@telefone", SqlDbType.VarChar, cliente.Telefone),
                SqlParam.In("sexo", SqlDbType.Char, cliente.Sexo),
                SqlParam.In("@observacao", SqlDbType.NVarChar, cliente.Observacao)
            );
            
        }

        public bool Excluir(ClienteDomain cliente)
        {
            return Db.Excluir(
                "cadastro_cliente_excluir",
                SqlParam.In("id", SqlDbType.Int, cliente.Id)
            );
        }
    }
}
