using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApi
{
    public abstract class StneProgram
    {
        public abstract void Main();
        protected CScriptContext ScriptContext { get; }
    }
}
