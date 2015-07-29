namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CMyFleet : Object
    {
        public CBaseShipManager Action { get; set; }
        public String Filter { get; set; }
        public Boolean FilterIsActive { get; set; }
        public Integer FleetID { get; set; }
        public Boolean Hidden { get; set; }
        public Boolean IsAll { get; set; }
        public String Name { get; set; }
        public String NameAndID { get; set; }
        public CShipList Ships { get; set; }
        public CMyFleet(Integer FlottenID) { }
    }
}

