using System;
using System.Collections;
using System.Collections.Generic;

namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public abstract class CUserEnumerator : Object, IEnumerator<CUser>
    {
        public Object Current { get; set; }
        public CUser CurrentUser { get; set; }
        CUser System.Collections.Generic.IEnumerator<CUser>.Current { get; }
        object IEnumerator.Current { get; }
        public Boolean MoveNext() { return null; }
        public Boolean Next() { return null; }
        public void Reset() { }
        public void Dispose() { }
        bool IEnumerator.MoveNext() { return false; }
        public CUserEnumerator() { }
    }
}

