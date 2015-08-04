namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public interface IList<T> : IEnumerable<T> where T : class, StneType
    {
        Boolean IsFixedSize { get; set; }
        Boolean IsReadOnly { get; set; }
        T this[Integer index] { get; set; }
        Integer Add(Object value);
        void Clear();
        Boolean Contains(Object value);
        Integer IndexOf(Object value);
        void Insert(Integer index, T value);
        void Remove(T value);
        void RemoveAt(Integer index);
    }
}

