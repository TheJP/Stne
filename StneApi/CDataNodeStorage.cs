namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CDataNodeStorage : Object
    {
        public CDataNodeList Items { get; set; }
        public String Name { get; set; }
        public String Title { get; set; }
        public CDataNodeStorage Copy(String NewName) { return null; }
        public void Delete() { }
        public static Boolean Exists(String Name) { return null; }
        public static Boolean Exists(String Name, Integer UserID) { return null; }
        public static CDataNodeStorage LoadFromUser(String Name, Integer UserID) { return null; }
        public void Rename(String NewName) { }
        public CDataNodeStorage(String Name, Boolean CreateIfNotExists) { }
        public CDataNodeStorage(String Name) { }
    }
}

