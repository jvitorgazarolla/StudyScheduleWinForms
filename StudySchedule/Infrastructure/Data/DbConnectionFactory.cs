using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace StudySchedule.Infrastructure.Data
{
    internal static class DbConnectionFactory
    {
        public static SqlConnection Create()
            => new SqlConnection(DbConfig.ConnectionString);
    }
}
