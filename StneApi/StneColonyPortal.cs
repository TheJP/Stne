using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApi
{
    public abstract class StneColonyPortal : StneWebProgram
    {
        protected CMyColony MyColony { get; }
        protected CShip GuestShip { get; }
    }
}
