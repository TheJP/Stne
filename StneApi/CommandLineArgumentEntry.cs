namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CommandLineArgumentEntry : Object
    {
        public String IndexPrefix;
        public String Name;
        public object Childeren { get; set; }
        public object Collection { get; set; }
        public Boolean IsCollection { get; set; }
        public Boolean IsFlag { get; set; }
        public Boolean IsIndexed { get; set; }
        public Boolean IsValue { get; set; }
        public String Value { get; set; }
    }
}

