namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CControlTableCell : Object
    {
        public CTableCellList Cells { get; set; }
        public Integer ColumnSpan { get; set; }
        public String CssClass { get; set; }
        public String Height { get; set; }
        public object HorizontalAlign { get; set; }
        public String Text { get; set; }
        public object VerticalAlign { get; set; }
        public String Width { get; set; }
        public Boolean Wrap { get; set; }
        public void AddAttribute(String Key, String Value) { }
        public void AddStyle(String Key, String Value) { }
        public CControlTableCell(CTableCellList CTableCellList) { }
    }
}

