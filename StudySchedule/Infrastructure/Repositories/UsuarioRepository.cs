using Microsoft.Data.SqlClient;
using StudySchedule.Application.DTOs.Usuario;
using StudySchedule.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace StudySchedule.Infrastructure.Repositories
{
    public class UsuarioRepository
    {
        public UsuarioDto? Login(string usuario, string senha)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand("login", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            conn.Open();


            using var rd = cmd.ExecuteReader();

            if (!rd.Read())
            {
                return null;
            }

            return new UsuarioDto
            {
                Id = rd.GetInt32(rd.GetOrdinal("id")),
                Nome = rd.GetString(rd.GetOrdinal("nome")),
                Usuario = rd.GetString(rd.GetOrdinal("usuario"))              
            };
        }
    }

  
}
