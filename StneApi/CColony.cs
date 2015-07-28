namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CColony : CSector
    {
        public String Name { get; set; }
        public Integer UserID { get; set; }
        public CColony(Integer PosX, Integer PosY, SMap Map) : base(PosX, PosY, Map) { }
    }
}

