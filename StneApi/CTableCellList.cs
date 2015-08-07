namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CTableCellList : CCollectionBase<CTableCell>
    {
        public CControlTableCell ControlCell;
        public CTableCell this[Integer Index] { get { return null; } set { } }
        public void Add(CTable Table, Integer ColumnIndex, Integer StartRowIndex) { }
        public void Add(CTable Table, Integer ColumnIndex) { }
        public void Add(CTableRow Row, Integer Start, Integer Count) { }
        public Integer Add(CTableCell Value) { return null; }
        public void Add(CTableRow Row) { }
        public void Add(CTable Table, Integer ColumnIndex, Integer StartRowIndex, Integer Count) { }
        public void Add(CTable Table) { }
        public void Add(CTable Table, SPoint vFrom, SPoint vTo) { }
        public Boolean Contains(CTableCell Value) { return null; }
        public Integer IndexOf(CTableCell Value, Integer Start) { return null; }
        public Integer IndexOf(CTableCell Value) { return null; }
        public Integer IndexOf(CTableCell Value, Integer Start, Integer Count) { return null; }
        public void Insert(Integer Index, CTableCell Value) { }
        public Integer LastIndexOf(CTableCell Value, Integer Start) { return null; }
        public Integer LastIndexOf(CTableCell Value) { return null; }
        public Integer LastIndexOf(CTableCell Value, Integer Start, Integer Count) { return null; }
        public void Remove(CTableCell Value) { }
        public void ReverseSelection(CTable SourceTable) { }
        public void ToArray() { }
        public CTableCellList() { }
    }
}

