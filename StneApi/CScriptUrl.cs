namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CScriptUrl : CUrl
    {
        public Integer Count { get; set; }
        public String Method { get; set; }
        public String Owner { get; set; }
        public CStringHashTable Parameters { get; set; }
        public String Script { get; set; }
        public String this[String Name] { get { return null; } set { } }
        public void Clear() { }
        public void Remove(String Name) { }
        public CScriptUrl() { }
    }
}

