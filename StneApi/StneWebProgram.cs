using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApi
{
    public abstract class StneWebProgram : StneProgram
    {
        protected CWebRequest Request { get; }
        protected CWebResponse Response { get; }
    }
}
