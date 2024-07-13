using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Model
{
    internal class TimeModel
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }

        public TimeModel()
        {
            
        }

        public override string ToString()
        {
            return $"Time (" +
                $"Id: {Id}, EmployeeId: {EmployeeId}, " +
                $"EntryTime: {EntryTime.ToShortDateString()}, " +
                $"ExitTime: {ExitTime.ToShortDateString()}" +
                $")";
        }

    }
}
