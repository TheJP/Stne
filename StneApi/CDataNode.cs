namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CDataNode : Object
    {
        public object asBinary { get; set; }
        public Boolean asBoolean { get; set; }
        public Date asDate { get; set; }
        public Double asDouble { get; set; }
        public Integer asInteger { get; set; }
        public String asString { get; set; }
        public String CommentRight { get; set; }
        public String CommentTop { get; set; }
        public Boolean HasAttribute { get; set; }
        public Boolean HasChildren { get; set; }
        public Boolean HasParent { get; set; }
        public CDataNodeList Items { get; set; }
        public String Key { get; set; }
        public CDataNode Parent { get; set; }
        public CDataNodeList ParentList { get; set; }
        public String Value { get; set; }
        public CDataNode this[String Key] { get { return null; } set { } }
        public static Boolean CheckKey(String Key, Boolean ShowException) { return null; }
        public void Detach() { }
        public String GetPath() { return null; }
        public void Rename(String NewKey) { }
    }
}

