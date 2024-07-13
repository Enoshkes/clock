using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Model
{
    internal class PasswordModel
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public string Password { get; set; }
        public DateOnly ExpairyDate { get; set; }
        public bool HasAccess { get; set; }

        public PasswordModel()
        {
            
        }

        public override string ToString()
        {
            return $"Password (id: {Id}, employee_id: {EmployeeId}, " +
                $"password: {Password}, expairyDate: {ExpairyDate.ToShortDateString()}, " +
                $"hasAccess: {HasAccess}" +
                $")";
        }
    }
}
