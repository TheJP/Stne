namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CTable : CHtmlControl
    {
        public String BackImageUrl { get; set; }
        public String BgColor { get; set; }
        public Integer Border { get; set; }
        public object BorderColor { get; set; }
        public Integer CellPadding { get; set; }
        public Integer CellSpacing { get; set; }
        public Integer DefaultColumnCount { get; set; }
        public CTableRowCollection Rows { get; set; }
        public CTableRow this[Integer Index] { get { return null; } set { } }
        public Integer Add(CTableRow Row) { return null; }
        public CTableRow AddRow() { return null; }
        public CTableRow AddRow(Integer Columns) { return null; }
        public static SPoint CoordsOfCell(CTableCell Cell) { return null; }
        public void DeleteEmptyTableCells(CTableRow TableRow, Boolean SetColumnSpan) { }
        public void DeleteEmptyTableCells(Boolean SetColumnSpan) { }
        public void HideBorders() { }
        public void Merge(CTableCell Cell, Integer LenX, Integer LenY) { }
        public void Merge(CTableCell CellFrom, CTableCell CellTo) { }
        public void Merge(Integer ColumnIndex) { }
        public void Merge(Integer ColumnIndex, Integer RowStart, Integer LenY) { }
        public void Merge(SPoint From, Integer LenX, Integer LenY) { }
        public void Merge(CTableRow Row) { }
        public void Merge(CTableRow Row, Integer StartCellInex, Integer LenX) { }
        public void Merge(SPoint From, SPoint To) { }
        public void RemoveEmtpyColumns(Integer ScanFromRow, Integer ScanToRow, Integer ScanFromColumn, Integer ScanToColumn, String DefaulCHtml) { }
        public CControlTableCell Select(Integer ColumnIndex, Integer StartRowIndex, Integer Count) { return null; }
        public CControlTableCell Select(Integer ColumnIndex, Integer StartRowIndex) { return null; }
        public CControlTableCell Select(CTableRow Row) { return null; }
        public CControlTableCell Select() { return null; }
        public CControlTableCell Select(Integer ColumnIndex) { return null; }
        public CControlTableCell Select(CTableCell Cell) { return null; }
        public CControlTableCell Select(CTableRow Row, Integer ColumnIndex, Integer Len) { return null; }
        public CControlTableCell Select(SPoint From, SPoint To) { return null; }
        public CControlTableCell SelectEmtpyCells() { return null; }
        public CTable() { }
        public CTable(Integer DefaultColumnCount) { }
        public CTable(Integer ColumnCount, Integer RowCount) { }
    }
}
