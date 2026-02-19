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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<JornadaDto>Buscar(string? nomeProfissional = null, TimeSpan? hora = null, DateTime? data = null)
        {
            var lista = new List<JornadaDto>();

            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("cadastro_jornada_buscar", conn);
            cmd.Parameters.AddWithValue("@nome_profissional", nomeProfissional);
            cmd.Parameters.Add("@data", SqlDbType.Date).Value = data;
            cmd.Parameters.Add("@horario", SqlDbType.Time).Value = hora;


            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            using var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                lista.Add(new JornadaDto
                {
                    NomeProfissional = rd.GetString(rd.GetOrdinal("nome")),
                    Hora = rd.GetTimeSpan(rd.GetOrdinal("horario")),
                    Data = rd.GetDateTime(rd.GetOrdinal("data"))


                });

            }

            return lista;
        }
    }
}
