namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class Array<T> : StneType, IEnumerable<T> where T : class, StneType
    {
        public T this[params Integer[] index] { get { return null; } set { } }
        public static implicit operator Array<T>(T[] o) => null;
        public static implicit operator Array<T>(T[,] o) => null;
        public static implicit operator Array<T>(T[,,] o) => null;
        public static implicit operator Array<T>(T[,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,,,,,,,] o) => null;
        public static implicit operator Array<T>(T[,,,,,,,,,,,,,,,] o) => null;
        public Boolean IsFixedSize { get; set; }
        public Boolean IsReadOnly { get; set; }
        public Boolean IsSynchronized { get; set; }
        public Integer Length { get; set; }
        public Integer Rank { get; set; }
        public Object SyncRoot { get; set; }
        public static Integer BinarySearch(Array<T> array, Integer index, Integer length, T value, IComparer comparer) { return null; }
        public static Integer BinarySearch(Array<T> array, T value, IComparer comparer) { return null; }
        public static Integer BinarySearch(Array<T> array, T value) { return null; }
        public static Integer BinarySearch(Array<T> array, Integer index, Integer length, T value) { return null; }
        public static void Clear(Array<T> array, Integer index, Integer length) { }
        public Object Clone() { return null; }
        public static void ConstrainedCopy(Array<T> sourceArray, Integer sourceIndex, Array<T> destinationArray, Integer destinationIndex, Integer length) { } { }
        public static void Copy(Array<T> sourceArray, Integer sourceIndex, Array<T> destinationArray, Integer destinationIndex, Integer length) { }
        public static void Copy(Array<T> sourceArray, Array<T> destinationArray, Integer length) { }
        public void CopyTo(Array<T> array, Integer index) { }
        public IEnumerator<T> GetEnumerator() { return null; }
        public Integer GetLength(Integer dimension) { return null; }
        public Integer GetLowerBound(Integer dimension) { return null; }
        public Integer GetUpperBound(Integer dimension) { return null; }
        public T GetValue(Integer index1, Integer index2, Integer index3) { return null; }
        public T GetValue(Integer index1, Integer index2) { return null; }
        public T GetValue(Integer index) { return null; }
        public static Integer IndexOf(Array<T> array, T value, Integer startIndex, Integer count) { return null; }
        public static Integer IndexOf(Array<T> array, T value) { return null; }
        public static Integer IndexOf(Array<T> array, T value, Integer startIndex) { return null; }
        public void Initialize() { }
        public static Integer LastIndexOf(Array<T> array, T value) { return null; }
        public static Integer LastIndexOf(Array<T> array, T value, Integer startIndex) { return null; }
        public static Integer LastIndexOf(Array<T> array, T value, Integer startIndex, Integer count) { return null; }
        public static void Reverse(Array<T> array, Integer index, Integer length) { }
        public static void Reverse(Array<T> array) { }
        public void SetValue(T value, Integer index1, Integer index2) { }
        public void SetValue(T value, Integer index) { }
        public void SetValue(T value, Integer index1, Integer index2, Integer index3) { }
        public static void Sort(Array<T> keys, Array<T> items, IComparer comparer) { }
        public static void Sort(Array<T> array, IComparer comparer) { }
        public static void Sort(Array<T> keys, Array<T> items, Integer index, Integer length, IComparer comparer) { }
        public static void Sort(Array<T> array, Integer index, Integer length, IComparer comparer) { }
        public static void Sort(Array<T> keys, Array<T> items, Integer index, Integer length) { }
        public static void Sort(Array<T> array) { }
        public static void Sort(Array<T> array, Integer index, Integer length) { }
        public static void Sort(Array<T> keys, Array<T> items) { }

        //Allowing the use of foreach
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() => null;
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => null;
    }
}

