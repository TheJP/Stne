namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CDataNodeList : CSortedListBase
    {
        public CDataNode FirstNode { get; set; }
        public CDataNode LastNode { get; set; }
        public CDataNode Parent { get; set; }
        public CDataNode this[String Key] { get { return null; } set { } }
        public CDataNode Add(String Key, Object Value) { return null; }
        public CDataNode AddBoolean(String Key, Boolean Value) { return null; }
        public CDataNode AddDate(String Key, Date Value) { return null; }
        public CDataNode AddDouble(String Key, Double Value) { return null; }
        public CDataNode AddInteger(String Key, Integer Value) { return null; }
        public CDataNode AddString(String Key, String Value) { return null; }
        public Boolean ContainsKey(String Key) { return null; }
        public Boolean ContainsValue(CDataNode Value) { return null; }
        public CDataNodeList CreateIntegerSortedList(Boolean LinkNodes) { return null; }
        public CDataNodeList CreateSortedList(IComparer Comparer, Boolean LinkNodes) { return null; }
        public void FillDictionary(IDictionary dic) { }
        public CDataNode FindNode(String Path, String Delimiter, Boolean ShowExceptionIfNotExists) { return null; }
        public static CDataNodeList FromString(String Expression) { return null; }
        public CDataNode GetNode(String Path, String Delimiter) { return null; }
        public Integer IndexOfKey(String Key) { return null; }
        public Integer IndexOfValue(CDataNode Value) { return null; }
        public CDataNode ItemByIndex(Integer Index) { return null; }
        public String KeyByIndex(Integer Index) { return null; }
        public void Remove(String Key) { }
        public void Rename(String Key, String NewKey) { }
        public CDataNodeList Sort(IComparer Comparer) { return null; }
        public CDataNodeList() : base(null, null) { }
    }
}

