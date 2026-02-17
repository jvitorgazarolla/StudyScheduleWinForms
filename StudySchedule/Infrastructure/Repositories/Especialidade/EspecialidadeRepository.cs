using Microsoft.Data.SqlClient;
using StudySchedule.Application.DTOs.Especialidade;
using StudySchedule.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StudySchedule.Infrastructure.Repositories.Especialidade
{
    public class EspecialidadeRepository
    {
        public List<EspecialidadeDto> Listar()
        {
            var lista = new List<EspecialidadeDto>();

            using var conn = DbConnectionFactory.Create();

            using var cmd = new SqlCommand("especialidade_listar", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            using var rd = cmd.ExecuteReader();

            while (rd.Read()) 
            {
                lista.Add(new EspecialidadeDto
                {
                    Id = rd.GetInt32(rd.GetOrdinal("id")),
                    Descricao = rd.GetString(rd.GetOrdinal("descricao")),
                    Status = rd.GetInt32(rd.GetOrdinal("status")) == 1
                });
            }

            return lista;

        }

        public List<EspecialidadeDto> Buscar(string? termo = null, bool? status = null)
        {
            var lista = new List<EspecialidadeDto>();

            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("especialidade_buscar", conn);
            cmd.Parameters.AddWithValue("@termo", termo);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.CommandType = CommandType.StoredProcedure;


            conn.Open();

            using var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                lista.Add(new EspecialidadeDto
                {
                    Id = rd.GetInt32(rd.GetOrdinal("id")),
                    Descricao = rd.GetString(rd.GetOrdinal("descricao")),
                    Status = rd.GetInt32(rd.GetOrdinal("status")) == 1
                });
            }
            return lista;
        }


        public int Inserir(string descricao, bool status)
        {
            try
            {
                using var conn = DbConnectionFactory.Create();
                using var cmd = new SqlCommand("especialidade_inserir", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("descricao", descricao);
                cmd.Parameters.AddWithValue("status", status);
                conn.Open();

                var id = cmd.ExecuteScalar();

                return System.Convert.ToInt32(id);

            }catch(SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new Exception("Essa especialidade já existe!");                                                                                                                                           
            }
        }

        public void Atualizar(int? id = null, string? descricao = null, bool? status = null)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("especialidade_atualizar", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@status", status);

            conn.Open();

            cmd.ExecuteNonQuery();
        }

        public void Excluir(int id)
        {
            MessageBox.Show("Chegou ao repository");

            using var conn = DbConnectionFactory.Create();

            using var cmd = new SqlCommand("especialidade_excluir", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            var linhas = cmd.ExecuteNonQuery();

            if(linhas == 0)
            {
                throw new Exception("Nenhuma especialidade foi excluida");
            }

        }
    }
}
