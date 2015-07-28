namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CGuiEvent : Object
    {
        public EGuiControl ControlType { get; set; }
        public Object DataObject { get; set; }
        public EGuiEventType EventType { get; set; }
        public CGuiEventFilter Filter { get; set; }
        public CGuiPage Page { get; set; }
        public CGuiEvent SetDataObject(Object Value) { return null; }
    }
}

