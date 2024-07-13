using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_time.Service
{
    internal interface ICrudService<MODEL, ID>
    {
        MODEL? Create(MODEL model);

        MODEL? ReadById(ID id);

        MODEL? Update(ID id,  MODEL model);

        MODEL? DeleteById(ID id);
    }
}
