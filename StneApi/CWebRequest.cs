namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CWebRequest
    {
        public CStringHashTable Form { get; set; }
        public CStringHashTable Parameters { get; set; }
        public String Script { get; set; }
        public String ScriptMethod { get; set; }
        public String ScriptOwner { get; set; }
        public CUser User { get; set; }
        public Integer UserID { get; set; }
    }
}

