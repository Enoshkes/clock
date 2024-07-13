using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Model
{
    internal class EmployeeModel
    {
        public long Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmployeeModel() {}

        public EmployeeModel(EmployeeModel other)
        {
            Id = other.Id;
            IdentityNumber = other.IdentityNumber;
            FirstName = other.FirstName;
            LastName = other.LastName;
        }

        public EmployeeModel(long id, string identityNumber, string firstName, string lastName)
        {
            Id = id;
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public EmployeeModel(string identityNumber, string firstName, string lastName)
        {
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() 
        {
            return $"Employee (" +
                $"Id: {Id}, IdentityNumber: {IdentityNumber}, " +
                $"firstName: {FirstName}, lastName: {LastName}" +
                $")";
        }
    }
}
