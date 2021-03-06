namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CDefaultValueHashTable<K, V> : Object
        where K : class, StneType
        where V : class, StneType
    {
        public V DefaultValue;
        public Integer Count { get; set; }
        public Boolean IsFixedSize { get; set; }
        public Boolean IsReadOnly { get; set; }
        public Boolean IsSynchronized { get; set; }
        public ICollection<K> Keys { get; set; }
        public Object SyncRoot { get; set; }
        public ICollection<V> Values { get; set; }
        public V this[K key] { get { return null; } set { } }
        public void Add(K key, V value) { }
        public void Clear() { }
        public Object Clone() { return null; }
        public Boolean Contains(K key) { return null; }
        public Boolean ContainsKey(K key) { return null; }
        public Boolean ContainsValue(V value) { return null; }
        public void CopyTo(Array<V> array, Integer arrayIndex) { }
        public void GetEnumerator() { }
        public void OnDeserialization(Object sender) { }
        public void Remove(K key) { }
        public CDefaultValueHashTable(V DefaultValue, IDictionary<K, V> Dictionary) { }
        public CDefaultValueHashTable(V DefaultValue) { }
        public CDefaultValueHashTable(V DefaultValue, Integer capacity) { }
    }
}

