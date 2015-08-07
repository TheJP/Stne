namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CTableCell : CHtmlControl
    {
        public Boolean CanRemove;
        public Integer ColumnSpan { get; set; }
        public CTableRow ParentRow { get; set; }
        public Integer RowSpan { get; set; }
        public CTable Table { get; set; }
        public String Text { get; set; }
        public Boolean Wrap { get; set; }
        public void Remove(Boolean SetColumnSpan) { }
        public void SetAllBorders(String StyleExpression) { }
        public CTableCell(CHtmlControl Child, String CssClass) { }
        public CTableCell() { }
        public CTableCell(String Text, String CssClass) { }
    }
}

