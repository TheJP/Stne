namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CUser
    {
        public CAlliance Alliance { get; set; }
        public Integer AllianceID { get; set; }
        public Boolean IsOnline { get; set; }
        public Integer Level { get; set; }
        public String Name { get; set; }
        public String NameAndID { get; set; }
        public Date RegisteredSince { get; set; }
        public Integer ReputationExternal { get; set; }
        public Integer ReputationInternal { get; set; }
        public Integer RoundsPlayed { get; set; }
        public Integer UserID { get; set; }
        public static CUser Create(Integer UserID) { return null; }
        public static Boolean Exists(Integer UserID) { return null; }
        public CHtmlControl GetHtmlName(Boolean ShowSponsor) { return null; }
        public CHtmlControl GetHtmlNameAndID(Boolean ShowSponsor) { return null; }
        public void GetRelation(CUser User) { }
        public CUser(Integer UserID) { }
    }
}

