namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CBuilding : Object
    {
        public Boolean Active { get; set; }
        public object BuildingType { get; set; }
        public CColony Colony { get; set; }
        public CColonyField Field { get; set; }
        public Integer FieldID { get; set; }
        public Integer Integrity { get; set; }
        public String Name { get; set; }
        public String TypeName { get; set; }
        public Boolean UnderConstruction { get; set; }
    }
}

