namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    interface IDictionary
    {
        Boolean IsFixedSize { get; set; }
        Boolean IsReadOnly { get; set; }
        ICollection Keys { get; set; }
        ICollection Values { get; set; }
        Object this[Object key] { get; set; }
        void Add(Object key, Object value);
        void Clear();
        Boolean Contains(Object key);
        void GetEnumerator();
        void Remove(Object key);
    }
}

