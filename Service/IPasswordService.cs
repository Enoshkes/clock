using clock_time.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Service
{
    internal interface IPasswordService: ICrudService<PasswordModel, long>
    {
        PasswordModel? ReadByEmployeeId(long employeeId);

        bool UpdatePassword(long  employeeId, string password);
    }
}
