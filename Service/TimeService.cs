using clock_time.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static clock_time.Configuration.Connection;

namespace clock_time.Service
{
    internal class TimeService : ITimeService
    {
        public TimeModel? Create(TimeModel model)
        {
            throw new NotImplementedException();
        }

        public TimeModel? DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public TimeModel? ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public TimeModel? Update(long id, TimeModel model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTime(DateTime entryTime, DateTime exitTime, long employeeId)
        {
            string query = "insert into time (entry_time, exit_time, employee_id) values " +
                "( @entryTime, @exitTime, @employeeId ) ";

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new(query, connection);
                    cmd.Parameters.AddWithValue("@entryTime", entryTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@exitTime", exitTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
