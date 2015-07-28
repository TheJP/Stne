namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CColonyField
    {
        public CBuilding Building { get; set; }
        public CColony Colony { get; set; }
        public SPoint Coordinates { get; set; }
        public Integer FieldID { get; set; }
        public object FieldType { get; set; }
        public Boolean HasBuilding { get; set; }
        public Boolean IsEmpty { get; set; }
        public Boolean IsInOrbit { get; set; }
        public Boolean IsOrbital { get; set; }
        public Boolean IsShielded { get; set; }
        public Boolean IsVisible { get; set; }
        public SMapPosition Position { get; set; }
        public String TypeName { get; set; }
    }
}

