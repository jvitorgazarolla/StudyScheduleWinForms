using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StudySchedule.Infrastructure.Data
{
    public static class Db
    {
        public static A Atualizar<A>(string procedure, params SqlParameter[] parameters)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand(procedure, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddRange(parameters);

            conn.Open();

            var result = cmd.ExecuteScalar();

            if(result == null || result == DBNull.Value)
            {
                return default!;
            }

            return (A)Convert.ChangeType(result, typeof(A));
        }

        public static I Inserir<I>(string procedure, params SqlParameter[] parameters)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand(procedure, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            conn.Open();
            var result = cmd.ExecuteScalar();
            
            if (result == null || result == DBNull.Value)
            {
                return default!;
            }
            return (I)Convert.ChangeType(result, typeof(I));
        }

        public static List<B> Buscar<B>(string procedure, Func<SqlDataReader, B> map, params SqlParameter[] parameters)
        {
            using var conn = DbConnectionFactory.Create();
            using var cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);

            conn.Open();

            using var reader = cmd.ExecuteReader();
            
            var list = new List<B>();

            while (reader.Read()) {
                list.Add(map(reader));
            }
            return list;

        }
    }
}
