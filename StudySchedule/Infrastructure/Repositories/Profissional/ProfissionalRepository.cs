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
            try
            {
                // 13/02 => Ess procedure já está inserind na tabela cadastro_profissional_especialidade
                //ADICIONAR VERIFICAÇÃO(CASO USUÁRIO JA CADASTRADO) ---- DECIDIR QUAIS CAMPOS VERIFICAR

                // 15/02 Vários profissionais pode ter várias especialidades, Lembrar de adicionar funcionalidade para isso
                using var conn = DbConnectionFactory.Create();

                using var cmdProfissional = new SqlCommand("profissional_inserir", conn);

                conn.Open();

                cmdProfissional.CommandType = CommandType.StoredProcedure;

                cmdProfissional.Parameters.AddWithValue("@nome", nome);
                cmdProfissional.Parameters.AddWithValue("@telefone", telefone);
                cmdProfissional.Parameters.AddWithValue("@status", status);
                cmdProfissional.Parameters.AddWithValue("@especialidade_id", EspecialidadeId);

                var profissionalId = cmdProfissional.ExecuteScalar();

                return Convert.ToInt32(profissionalId);

                //if(profissionalId != null)
                //{
                //    using var cmdUsuarioEspecialidade = new SqlCommand("profissional_especialidade_inserir", conn);
                //    cmdUsuarioEspecialidade.CommandType = CommandType.StoredProcedure;

                //}

            }catch(Exception ex)
            {
                throw new Exception("Profissional já cadastrado", ex);
            }

        }

        public void Editar(int? id = null, string? nome = null, string? telefone = null, bool? status = null, int? especialideId = null)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("profissional_atualizar", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@status", status);
            //cmd.Parameters.AddWithValue("@especialidade_id", especialideId);
            conn.Open();

            cmd.ExecuteNonQuery();
        }

        public  List<ProfissionalDto> Buscar(string? termo = null, bool? status = null)
        {
            var lista = new List<ProfissionalDto>();
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("profissional_buscar", conn);
            cmd.Parameters.AddWithValue("@termo", termo);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            using var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                lista.Add(new ProfissionalDto
                {
                    Id = rd.GetInt32(rd.GetOrdinal("id")),
                    Nome = rd.GetString(rd.GetOrdinal("nome")),
                    Telefone = rd.GetString(rd.GetOrdinal("Telefone")),
                    Status = rd.GetInt32(rd.GetOrdinal("status")) == 1,
                    EspecialidadeNome = rd.GetString(rd.GetOrdinal("especialidade_nome")),
                    EspecialidadeId = rd.GetInt32(rd.GetOrdinal("especialidade_id"))
                });
            }
            return lista;
        }

        public void Excluir(int id)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("profissional_excluir", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            var r = cmd.ExecuteNonQuery();
        }
    }
}
