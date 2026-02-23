using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Infrastructure.Data
{
    internal class DbConfig
    {
        public static string ConnectionString =>
            @"Server=(localdb)\MSSQLLocalDB;Database=StudySchedule;Trusted_Connection=True;TrustServerCertificate=True";
    }
}
