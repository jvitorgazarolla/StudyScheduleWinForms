using Microsoft.Data.SqlClient;
using StudySchedule.Application.DTOs.Agenda.Jornada;
using StudySchedule.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudySchedule.Infrastructure.Repositories.Agenda
{
    public class JornadaRepository
    {
        public int Inserir(int profissionalId, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, TimeSpan duracao) 
        {
            return Db.Inserir<int>(
            "cadastro_jornada_inserir",
            SqlParam.In("@profissional_id", SqlDbType.Int, profissionalId),
            SqlParam.In("@data", SqlDbType.Date, data),
            SqlParam.In("@hora_inicio", SqlDbType.Time, horaInicio),
            SqlParam.In("@hora_fim",SqlDbType.Time, horaFim),
            SqlParam.In("@duracao", SqlDbType.Time, duracao)
            );
        }
        public List<JornadaDto>Buscar(string? nomeProfissional = null, DateTime? data = null, TimeSpan? horaInicio = null, TimeSpan? horaFim = null)
        {
            return Db.Buscar<JornadaDto>(
                "cadastro_jornada_buscar",
                reader => new JornadaDto
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    ProfissionalId = reader.GetInt32(reader.GetOrdinal("profissional_id")),
                    NomeProfissional = reader.GetString(reader.GetOrdinal("nome_profissional")),
                    Data = reader.GetDateTime(reader.GetOrdinal("data")),
                    HoraInicio = reader.GetTimeSpan(reader.GetOrdinal("hora_inicio")),
                    HoraFim = reader.GetTimeSpan(reader.GetOrdinal("hora_fim")),
                    Duracao = reader.GetTimeSpan(reader.GetOrdinal("duracao"))
                },
                SqlParam.In("@nome_profissional", SqlDbType.NVarChar, nomeProfissional),
                SqlParam.In("@data", SqlDbType.Date, data)
              );
        }
        public bool Atualizar(int id, int? profissionalId = null, DateTime? data = null, TimeSpan? horaInicio = null, TimeSpan? horaFim = null, TimeSpan? duracao = null)
        {
            MessageBox.Show(duracao.ToString());
            return Db.Atualizar(
                "cadastro_jornada_atualizar",
                 SqlParam.In("@id", SqlDbType.Int, id),
                 SqlParam.In("@profissional_id", SqlDbType.Int, profissionalId),
                 SqlParam.In("@data", SqlDbType.Date, data),
                 SqlParam.In("@horaInicio", SqlDbType.Time, horaInicio),
                 SqlParam.In("@horaFim", SqlDbType.Time, horaFim),
                 SqlParam.In("@duracao", SqlDbType.Time, duracao)
            );
        }

        public bool Excluir(int id)
        {
            return Db.Excluir(
                "cadastro_jornada_excluir",
                SqlParam.In("@id", SqlDbType.Int, id)
            );
        }
    }
}
