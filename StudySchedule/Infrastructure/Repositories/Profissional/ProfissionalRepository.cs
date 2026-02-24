using Microsoft.Data.SqlClient;
using StudySchedule.Application.DTOs.Profissional;
using StudySchedule.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StudySchedule.Infrastructure.Repositories.Profissional
{
    public class ProfissionalRepository
    {
        public int Inserir(string nome, string telefone, bool status, int EspecialidadeId)
        {
            return Db.Inserir<int>(
                "cadastro_profissional_inserir",
                SqlParam.In("@nome", SqlDbType.NVarChar, nome),
                SqlParam.In("@telefone", SqlDbType.NVarChar, telefone),
                SqlParam.In("@status", SqlDbType.Int, status),
                SqlParam.In("@especialidade_id", SqlDbType.Int, EspecialidadeId)
            );
        }

        public bool Atualizar (int? id = null, string? nome = null, string? telefone = null, bool? status = null, int? especialideId = null)
        {
            return Db.Atualizar(
                "cadastro_profissional_atualizar",
                SqlParam.In("@id", SqlDbType.Int, @id),
                SqlParam.In("@nome", SqlDbType.NVarChar, nome),
                SqlParam.In("@telefone", SqlDbType.NVarChar, telefone),
                SqlParam.In("@status", SqlDbType.Int, status)
               );
        }

        public  List<ProfissionalDto> Buscar(string? termo = null, bool? status = null)
        {
            return Db.Buscar<ProfissionalDto>(
                "cadastro_profissional_buscar",
                reader => new ProfissionalDto
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Nome = reader.GetString(reader.GetOrdinal("nome")),
                    Telefone = reader.GetString(reader.GetOrdinal("Telefone")),
                    Status = reader.GetInt32(reader.GetOrdinal("status")) == 1,
                    EspecialidadeNome = reader.GetString(reader.GetOrdinal("especialidade_nome")),
                    EspecialidadeId = reader.GetInt32(reader.GetOrdinal("especialidade_id"))
                },
                SqlParam.In("@termo", SqlDbType.NVarChar, termo),
                SqlParam.In("@status", SqlDbType.Int, status)
            );
        }
        public bool Excluir(int id)
        {
            return Db.Excluir(
                "cadastro_profissional_excluir",
                SqlParam.In("@id", SqlDbType.Int, id)
            );
        }
    }
}
