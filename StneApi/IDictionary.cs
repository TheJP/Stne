namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public interface IDictionary<K, V> : StneType
        where K : class, StneType
        where V : class, StneType
    {
        Boolean IsFixedSize { get; set; }
        Boolean IsReadOnly { get; set; }
        ICollection<K> Keys { get; set; }
        ICollection<V> Values { get; set; }
        V this[K key] { get; set; }
        void Add(K key, V value);
        void Clear();
        Boolean Contains(K key);
        void GetEnumerator();
        void Remove(K key);
    }
}

