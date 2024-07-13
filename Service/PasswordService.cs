using clock_time.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static clock_time.Configuration.Connection;

namespace clock_time.Service
{
    internal class PasswordService : IPasswordService
    {
        public PasswordModel? Create(PasswordModel model)
        {
            throw new NotImplementedException();
        }

        public PasswordModel? DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public PasswordModel? ReadByEmployeeId(long employeeId)
        {
            string query = "select * from password where employee_id=@employeeId";

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new(query, connection);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = reader.GetInt64(0);
                            string pwd = reader.GetString(2);
                            DateOnly expairyDate = DateOnly.FromDateTime(reader.GetDateTime(3));
                            bool hasAccess = reader.GetBoolean(4);
                            PasswordModel password = new()
                            {
                                Id = id,
                                Password = pwd,
                                EmployeeId = employeeId,
                                ExpairyDate = expairyDate,
                                HasAccess = hasAccess
                            };

                            return password;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public PasswordModel? ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public PasswordModel? Update(long id, PasswordModel model)
        {
            string query = "update password set password=@password, expairy_date=@expairyDate " +
                "where id=@id";

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new(query, connection);
                    DateTime newExpairyDate = DateTime.Now.AddYears(1);
                    cmd.Parameters.AddWithValue("@password", model.Password);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@expairyDate", newExpairyDate.ToString("yyyy-MM-dd"));


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        PasswordModel newModel = new()
                        {
                            Id = id,
                            Password = model.Password,
                            ExpairyDate = DateOnly.FromDateTime(newExpairyDate),
                            HasAccess = model.HasAccess,
                        };

                        return newModel;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public bool UpdatePassword(long employeeId, string password)
        {
            string query = "update password set password=@password, expairy_date=@expairyDate " +
               "where employee_id=@employeeId";

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new(query, connection);
                    DateTime newExpairyDate = DateTime.Now.AddYears(1);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@expairyDate", newExpairyDate.ToString("yyyy-MM-dd"));


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
