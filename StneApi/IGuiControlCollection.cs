namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public interface IGuiControlCollection : StneType
    {
        IGuiControl this[Integer Index] { get; set; }
        void Clear();
        void Insert(Integer Index, IGuiControl Control);
        void Remove(IGuiControl Control);
        void RemoveAt(Integer Index);
    }
}

