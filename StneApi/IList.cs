namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    interface IList : StneType
    {
        Boolean IsFixedSize { get; set; }
        Boolean IsReadOnly { get; set; }
        Object this[Integer index] { get; set; }
        Integer Add(Object value);
        void Clear();
        Boolean Contains(Object value);
        Integer IndexOf(Object value);
        void Insert(Integer index, Object value);
        void Remove(Object value);
        void RemoveAt(Integer index);
    }
}

