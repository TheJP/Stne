namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CSortedListBase : Object
    {
        public Integer Capacity { get; set; }
        public Integer Count { get; set; }
        public Boolean IsFixedSize { get; set; }
        public Boolean IsReadOnly { get; set; }
        public Boolean IsSynchronized { get; set; }
        public ICollection Keys { get; set; }
        public Object SyncRoot { get; set; }
        public ICollection Values { get; set; }
        public void AddHash(IDictionary HashTable, Boolean OverWriteIfKeyExists) { }
        public void Clear() { }
        public void CopyTo<T>(Array<T> array, Integer index) where T : class, StneType { }
        public void GetEnumerator() { }
        public IList GetKeyList() { return null; }
        public IList GetValueList() { return null; }
        public Boolean IsEmpty() { return null; }
        public void RemoveAt(Integer Index) { }
        public void TrimToSize() { }
        public CSortedListBase(IDictionary Dictionary, IComparer Comparer) { }
    }
}

