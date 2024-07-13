using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Utils
{
    internal class Validations
    {
        public static bool AnyEmptyString (params string[] values) =>
            values.Any(value => string.IsNullOrWhiteSpace(value));
    }
}
