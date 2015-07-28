namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    interface IEnumerator : StneType
    {
        Object Current { get; set; }
        Boolean MoveNext();
        void Reset();
    }
}

