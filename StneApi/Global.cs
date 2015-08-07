using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApi
{
    /// <summary>
    /// Use this attribute on a class to specify, that all it's members are globally accessible.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class Global : Attribute { }
}
