namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    interface IGuiControl
    {
        IGuiControlCollection Controls { get; set; }
        Integer Count { get; set; }
        String InnerHtml { get; set; }
        Boolean IsLiteral { get; set; }
        IGuiControl Parent { get; set; }
        String TagName { get; set; }
        void Add(IGuiControl Control);
        IGuiControlCollection FindByControlType(Integer GuiControl);
        IGuiControlCollection FindByID(String ID);
        IGuiControlCollection FindByTagName(String TagName);
        void Remove();
        void SetStyle(String Name, String Value);
    }
}

