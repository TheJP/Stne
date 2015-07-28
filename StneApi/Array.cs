namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class Array<T> : StneType where T : class, StneType
    {
        public T this[Integer index] { get { return null; } set { } }
        public T this[Long index] { get { return null; } set { } }
        public Boolean IsFixedSize { get; set; }
        public Boolean IsReadOnly { get; set; }
        public Boolean IsSynchronized { get; set; }
        public Integer Length { get; set; }
        public Long LongLength { get; set; }
        public Integer Rank { get; set; }
        public Object SyncRoot { get; set; }
        public static Integer BinarySearch(Array<T> array, Integer index, Integer length, Object value, IComparer comparer) { return null; }
        public static void Clear(Array<T> array, Integer index, Integer length) { }
        public Object Clone() { return null; }
        public static void ConstrainedCopy(Array<T> sourceArray, Integer sourceIndex, Array<T> destinationArray, Integer destinationIndex, Integer length) { }
        public static void Copy(Array<T> sourceArray, Integer sourceIndex, Array<T> destinationArray, Integer destinationIndex, Integer length) { }
        public void CopyTo(Array<T> array, Long index) { }
        public IEnumerator GetEnumerator() { return null; }
        public Integer GetLength(Integer dimension) { return null; }
        public Long GetLongLength(Integer dimension) { return null; }
        public Integer GetLowerBound(Integer dimension) { return null; }
        public Integer GetUpperBound(Integer dimension) { return null; }
        public Object GetValue(Integer index1, Integer index2, Integer index3) { return null; }
        public static Integer IndexOf(Array<T> array, Object value, Integer startIndex, Integer count) { return null; }
        public void Initialize() { }
        public static Integer LastIndexOf(Array<T> array, Object value) { return null; }
        public static void Reverse(Array<T> array, Integer index, Integer length) { }
        public void SetValue(Object value, Integer index1, Integer index2) { }
        public static void Sort(Array<T> keys, Array<T> items, IComparer comparer) { }
    }
}

