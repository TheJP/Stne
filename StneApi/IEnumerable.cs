namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public interface IEnumerable<out T> : System.Collections.Generic.IEnumerable<T>, StneType
    {
        new StneApi.IEnumerator<T> GetEnumerator();
    }
}

