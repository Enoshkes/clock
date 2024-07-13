using clock_time.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Service
{
    internal interface IEmployeeService : ICrudService<EmployeeModel, long>
    {
        (EmployeeModel? employee, bool isPwdExpired) Authenticate (
            string identityNumber, 
            string password
         );
    }
}
