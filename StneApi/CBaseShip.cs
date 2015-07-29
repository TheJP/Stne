namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CBaseShip : Object
    {
        public CShipDefinition Definition { get; set; }
        public SMapPosition MapPosition { get; set; }
        public String Name { get; set; }
        public Boolean ScanProtection { get; set; }
        public CSector Sector { get; set; }
        public Integer ShipID { get; set; }
        public String TypeName { get; set; }
        public Integer UserID { get; set; }
        public CHtmlControl GetNameHtml() { return null; }
        public CHtmlControl GetNameHtmlAndID() { return null; }
        public String GetNameText() { return null; }
        public String GetNameTextAndID() { return null; }
        public CHtmlControl GetTypeNameHtml() { return null; }
    }
}

