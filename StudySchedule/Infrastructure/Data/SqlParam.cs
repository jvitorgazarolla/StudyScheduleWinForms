using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StudySchedule.Infrastructure.Data
{
    public static class SqlParam
    {
        public static SqlParameter In(string name, SqlDbType type, object? value)
        {
            return new SqlParameter(name, type)
            {
                Direction = ParameterDirection.Input,
                Value = value ?? DBNull.Value
            };
        }
    }
}
