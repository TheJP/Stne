namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CTableRow : CHtmlControl
    {
        public CTableCellCollection Cells { get; set; }
        public new CTableCell this[Integer Index] { get { return null; } set { } }
        public void Add(CTableCell Cell) { }
        public void Merge() { }
        public void Merge(Integer Start, Integer Count) { }
        public void Merge(Integer Start) { }
        public CControlTableCell Select() { return null; }
        public CControlTableCell Select(Integer Start, Integer Count) { return null; }
        public CControlTableCell Select(Integer Start) { return null; }
        public CTableRow() { }
        public CTableRow(Integer CellCount) { }
    }
}

