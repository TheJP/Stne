namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CSector : Object
    {
        public SPoint Coordinates { get; set; }
        public Boolean Habitable { get; set; }
        /// <summary> True if the sector is colonised by someone. </summary>
        public Boolean IsColonised { get; set; }
        /// <summary> True if the sector is colonised or could possibly be colonised. </summary>
        public Boolean IsColony { get; set; }
        public Boolean IsFreeSpace { get; set; }
        public Integer RegionID { get; set; }
        public Integer SectorID { get; set; }
        public EGalaxyMapItemType Type { get; set; }
        public String TypeName { get; set; }
        public CSector(Integer PosX, Integer PosY, SMap Map) { }
        public CSector(Integer PosX, Integer PosY) { }
        public CSector(Integer SektorID) { }
    }
}

