namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CSortedObjectList
    {
        public Object DefaultReturnValue;
        public Boolean ShowExceptionIfKeyNotExists;
        public Integer Capacity { get; set; }
        public Integer Count { get; set; }
        public Boolean IsFixedSize { get; set; }
        public Boolean IsReadOnly { get; set; }
        public Boolean IsSynchronized { get; set; }
        public ICollection<Object> Keys { get; set; }
        public Object SyncRoot { get; set; }
        public ICollection<Object> Values { get; set; }
        public Object this[Object Key] { get { return null; } set { } }
        public void Add(Object Key, Object Value) { }
        public void AddHash(IDictionary<Object, Object> HashTable, Boolean OverWriteIfKeyExists) { }
        public void Clear() { }
        public Object Clone() { return null; }
        public Boolean Contains(Object key) { return null; }
        public Boolean ContainsKey(Object key) { return null; }
        public Boolean ContainsValue(Object value) { return null; }
        public void CopyTo(Array<Object> array, Integer arrayIndex) { }
        public Object GetByIndex(Integer index) { return null; }
        public Object GetKey(Integer index) { return null; }
        public IList<Object> GetKeyList() { return null; }
        public IList<Object> GetValueList() { return null; }
        public Integer IndexOfKey(Object key) { return null; }
        public Integer IndexOfValue(Object value) { return null; }
        public Boolean isEmpty() { return null; }
        public Object ItemByIndex(Integer Index) { return null; }
        public Object KeyByIndex(Integer Index) { return null; }
        public void Remove(Object Key) { }
        public void RemoveAt(Integer index) { }
        public void SetByIndex(Integer index, Object value) { }
        public void TrimToSize() { }
        public CSortedObjectList(IDictionary<Object, Object> Dictionary, IComparer Comparer) { }
    }
}

