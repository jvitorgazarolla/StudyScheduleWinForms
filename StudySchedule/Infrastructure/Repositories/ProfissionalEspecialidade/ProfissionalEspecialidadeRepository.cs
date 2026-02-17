using Microsoft.Data.SqlClient;
using StudySchedule.Application.DTOs.ProfissionalEspecialidade;
using StudySchedule.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StudySchedule.Infrastructure.Repositories.ProfissionalEspecialidade
{
    public class ProfissionalEspecialidadeRepository
    {
        public int Inserir(int profissionalId, int profissionalEspecialidadeId, DateTime data, TimeSpan horario)
        {
            try
            {

                using var conn = DbConnectionFactory.Create();
                using var cmd = new SqlCommand("cadastro_jornada_inserir", conn);

                conn.Open();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@profissional_id", profissionalId);
                cmd.Parameters.AddWithValue("@profissional_especialidade_id", profissionalEspecialidadeId);
                cmd.Parameters.Add("@data", SqlDbType.Date).Value = data;
                cmd.Parameters.Add("@horario", SqlDbType.Time).Value = horario;

                var r = cmd.ExecuteScalar();

                return Convert.ToInt32(r);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        public List<ProfissionalEspecialidadeDto>Buscar(int? id = null, int? profissionalId = null, int? especialidadeId = null)
        {
            var lista = new List<ProfissionalEspecialidadeDto>();
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("cadastro_profissional_especialidade_buscar", conn);
            cmd.Parameters.AddWithValue("@profissional_id", profissionalId);
            cmd.Parameters.AddWithValue("@especialidade_id", especialidadeId);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            using var rd = cmd.ExecuteReader();

            while (rd.Read()) {
                lista.Add(new ProfissionalEspecialidadeDto
                {
                    Id = rd.GetInt32(rd.GetOrdinal("id")),
                    ProfissionalId = rd.GetInt32(rd.GetOrdinal("profissional_id")),
                    EspecialidadeId = rd.GetInt32(rd.GetOrdinal("especialidade_id")),
                    Descricao = rd.GetString(rd.GetOrdinal("descricao")),
                });
            }
            return lista;

        }
    }
}
