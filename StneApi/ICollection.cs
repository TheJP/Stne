namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    interface ICollection : StneType
    {
        Integer Count { get; set; }
        Boolean IsSynchronized { get; set; }
        Object SyncRoot { get; set; }
        void CopyTo<T>(Array<T> array, Integer index) where T : class, StneType;
    }
}

