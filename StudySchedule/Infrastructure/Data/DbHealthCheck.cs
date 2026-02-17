using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Infrastructure.Data
{
    internal class DbHealthCheck
    {
        public static bool canConnect(out string error)
        {
            try
            {
                using var conn = DbConnectionFactory.Create();
                conn.Open();
                error = "";
                return true;

            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
