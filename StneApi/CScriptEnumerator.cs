using System;
using System.Collections;
using System.Collections.Generic;

namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public abstract class CScriptEnumerator : Object, IEnumerator<CScript>
    {
        public Object Current { get; set; }
        public CScript CurrentScript { get; set; }
        CScript System.Collections.Generic.IEnumerator<CScript>.Current { get; }
        object IEnumerator.Current { get; }
        public Boolean MoveNext() { return null; }
        public Boolean Next() { return null; }
        public void Reset() { }
        public void Dispose() { }
        bool IEnumerator.MoveNext() { return false; }
        public CScriptEnumerator() { }
    }
}

