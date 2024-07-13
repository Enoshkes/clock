using clock_time.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Service
{
    internal interface ITimeService : ICrudService<TimeModel, long>
    {
        bool UpdateTime(DateTime entryTime, DateTime exitTime, long employeeId);
    }
}
