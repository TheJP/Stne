namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CDictionaryBase<K, V> : Object
        where K : class, StneType
        where V : class, StneType
    {
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
        public Boolean IsEmpty() { return null; }
        public CDictionaryBase(IDictionary<K, V> Dictionary) { }
    }
}

