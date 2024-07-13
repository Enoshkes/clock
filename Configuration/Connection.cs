using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Configuration
{
    internal class Connection
    {

        public static readonly string connectionString =
            "Server=DESKTOP-C06JVA2;" +
            "Database=clock;" +
            "Uid=sa;" +
            "Pwd=1234;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True";
    }
}
