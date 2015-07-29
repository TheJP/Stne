namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class SMap : Object
    {
        public Integer InstanceID;
        public Integer MapID;
        public static SMap Default { get; set; }
        public object Map { get; set; }
        public static SMap FromString(String Expression) { return null; }
        public SMap(Integer MapID) { }
    }
}

