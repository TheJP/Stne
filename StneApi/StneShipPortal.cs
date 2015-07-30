using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApi
{
    public abstract class StneShipPortal : StneWebProgram
    {
        protected CMyShip MyShip { get; }
        protected CShip GuestShip { get; }
    }
}
