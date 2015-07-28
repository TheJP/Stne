namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CAlliance
    {
        public Integer AllianceID { get; set; }
        public Date DateFounded { get; set; }
        public String Description { get; set; }
        public Date LastJoinDate { get; set; }
        public CUserList Members { get; set; }
        public String Name { get; set; }
        public Integer OwnerID { get; set; }
        public CUser President { get; set; }
        public static Boolean Exists(Integer AllianzID) { return null; }
        public CHtmlControl GetHtmlName() { return null; }
        public CHtmlControl GetHtmlNameAndID() { return null; }
        public CAlliance(Integer AllianzID) { }
    }
}

