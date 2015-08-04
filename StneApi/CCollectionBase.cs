namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CCollectionBase<T> : Object, ICollection<T> where T : class, StneType
    {
        public Integer Capacity { get; set; }
        public Integer Count { get; set; }
        public Boolean IsFixedSize { get; set; }
        public Boolean IsReadOnly { get; set; }
        public Boolean IsSynchronized { get; set; }
        public Object SyncRoot { get; set; }
        public void AddRange(ICollection<T> col) { }
        public Boolean CheckIndex(Integer Index) { return null; }
        public void Clear() { }
        public void CopyTo(Array<T> Array, Integer Index) { }
        public IEnumerator<T> GetEnumerator() { return null; }
        public void InsertRange(Integer Index, ICollection<T> col) { }
        public Boolean IsEmpty() { return null; }
        public void Move(Integer IndexFrom, Integer IndexTo) { }
        public void RemoveAt(Integer Index) { }
        public void RemoveRange(Integer Index, Integer Count) { }
        public void Reverse(Integer Index, Integer Count) { }
        public void SetRange(Integer Index, ICollection<T> col) { }
        public void Sort() { }
        public void TrimToSize() { }

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() => null;
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => null;

        public CCollectionBase(Integer Capacity) { }
    }
}

