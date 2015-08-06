namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CHtmlControl : Object, IEnumerable<CHtmlControl>
    {
        public CHtmlControlList Controls { get; set; }
        public Integer Count { get; set; }
        public String CssClass { get; set; }
        public CHtmlEventList Events { get; set; }
        public IGuiControl GuiControl { get; set; }
        public String Height { get; set; }
        public object HorizontalAlign { get; set; }
        public String ID { get; set; }
        public String InnerText { get; set; }
        public Boolean IsSynchronized { get; set; }
        public CHtmlControl Parent { get; set; }
        public Boolean RenderNoEndTag { get; set; }
        public CHtmlStyleCollection Style { get; set; }
        public Object SyncRoot { get; set; }
        public String TagName { get; set; }
        public String ToolTip { get; set; }
        public object VerticalAlign { get; set; }
        public Boolean Visible { get; set; }
        public String Width { get; set; }
        public CHtmlControl this[Integer Index] { get { return null; } set { } }
        public void Add(Object obj) { }
        public void CopyTo(Array<CHtmlControl> array, Integer index) { }
        public IEnumerator<CHtmlControl> GetEnumerator() { return null; }
        public Boolean HasControls() { return null; }
        public void Insert(Integer Index, CHtmlControl Child) { }
        public void Insert(Integer Index, String Text) { }
        public void Reverse() { }
        public void Sort(IComparer Comparer) { }

        System.Collections.Generic.IEnumerator<CHtmlControl> System.Collections.Generic.IEnumerable<CHtmlControl>.GetEnumerator() => null;
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => null;

        public CHtmlControl() { }
    }
}

