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
    internal class EmployeeService : IEmployeeService
    {

        public EmployeeModel? Create(EmployeeModel employee)
        {
            string query = "insert into employees (identity_number, first_name, last_name) " +
                "OUTPUT INSERTED.ID " +
                "values (@identityNumber, @firstName, @lastName); ";

            try
            {
                using (SqlConnection connection = new (connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new (query, connection);
                    cmd.Parameters.AddWithValue("@identityNumber", employee.IdentityNumber);
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);

                    var id = Convert.ToInt64(cmd.ExecuteScalar());

                    EmployeeModel newEmployee = new()
                    {
                        Id = id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        IdentityNumber = employee.IdentityNumber,
                    };

                    return newEmployee;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           return null;
        }

        public EmployeeModel? DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public (EmployeeModel? employee, bool isPwdExpired) Authenticate(string identityNumber, string password)
        {
            string query = "select e.*, p.expairy_date from employees e " +
                "inner join password p on e.id = p.employee_id " +
                "where e.identity_number=@identityNumber and p.password=@password";

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new(query, connection);
                    cmd.Parameters.AddWithValue("@identityNumber", identityNumber);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = reader.GetInt64(0);
                            string firstName = reader.GetString(2);
                            string lastName = reader.GetString(3);

                            DateOnly expairyDate = DateOnly.FromDateTime(reader.GetDateTime(4));
                            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                            EmployeeModel employee = new()
                            {
                                Id = id,
                                IdentityNumber = identityNumber,
                                FirstName = firstName,
                                LastName = lastName,
                            };
                            return (employee, isPwdExpired: currentDate > expairyDate);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return (null, isPwdExpired: false);
        }

        public EmployeeModel? ReadById(long id)
        {
            string query = "select * from employees where id=@id";

            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new(query, connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string identityNumber = reader.GetString(1);
                            string firstName = reader.GetString(2);
                            string lastName = reader.GetString(3);
                            EmployeeModel employee = new()
                            {
                                Id = id,
                                IdentityNumber = identityNumber,
                                FirstName = firstName,
                                LastName = lastName,
                            };

                            return employee;
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

        public EmployeeModel? Update(long id, EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
