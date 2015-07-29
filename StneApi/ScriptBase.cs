namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class ScriptBase : Object
    {
        public CWebRequest Request { get; set; }
        public CWebResponse Response { get; set; }
        public void CreateOptions(CEventOnCreateOptions e) { }
        public void CreatePage(CEventOnCreatePage e) { }
        public void DoActions(CEventOnDoAction e) { }
        public void Init(CEventOnInit e) { }
        public void RegisterEvents(CEventOnRegisterEvents e) { }
    }
}

