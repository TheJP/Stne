namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CSortedListBase<K, V> : Object
        where K : class, StneType
        where V : class, StneType
    {
        public Integer Capacity { get; set; }
        public Integer Count { get; set; }
        public Boolean IsFixedSize { get; set; }
        public Boolean IsReadOnly { get; set; }
        public Boolean IsSynchronized { get; set; }
        public ICollection<K> Keys { get; set; }
        public Object SyncRoot { get; set; }
        public ICollection<V> Values { get; set; }
        public void AddHash(IDictionary<K, V> HashTable, Boolean OverWriteIfKeyExists) { }
        public void Clear() { }
        public void CopyTo(Array<V> array, Integer index) { }
        public void GetEnumerator() { }
        public IList<K> GetKeyList() { return null; }
        public IList<V> GetValueList() { return null; }
        public Boolean IsEmpty() { return null; }
        public void RemoveAt(Integer Index) { }
        public void TrimToSize() { }
        public CSortedListBase(IDictionary<K, V> Dictionary, IComparer Comparer) { }
        public CSortedListBase(IComparer Comparer, Integer Capacity) { }
        public CSortedListBase(IDictionary<K, V> Dictionary) { }
        public CSortedListBase(Integer initialCapacity) { }
        public CSortedListBase(IComparer Comparer) { }
        public CSortedListBase() { }
    }
}

