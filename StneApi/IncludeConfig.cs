using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApi
{
    /// <summary>
    /// Defines, that the configuration of this program is allowed.
    /// A class with "public static" configuration options should be used for this attribute.
    /// (Adds the stne script directive "#Include Config".)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class Config : Attribute { }
}
