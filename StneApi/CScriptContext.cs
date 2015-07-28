namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CScriptContext : Object
    {
        public Boolean CanCallScripts { get; set; }
        public CStringObjectHashTable CustomRequestArguments { get; set; }
        public Boolean ExtensionIsRunning { get; set; }
        public Boolean ServiceEnabled { get; set; }
        public String ServiceName { get; set; }
        public void AbortScript() { }
        public void ActivateEvents() { }
        public void ActivateService() { }
        public void DeactivateEvents() { }
        public void DisableExtension() { }
        public void EnableExtension() { }
        public Object GetCustomRequestArgument(String Key) { return null; }
        public void RegisterEvent(EGuiEventType EventType, CDelegate CallBack) { }
        public void SetResult(Object Value) { }
        public void UnRegisterEvent(CDelegate CallBack) { }
        public void WriteAppLog(String Text) { }
    }
}

