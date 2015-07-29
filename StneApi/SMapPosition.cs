namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class SMapPosition : Object
    {
        public Boolean InOrbit;
        public Integer MapID;
        public Integer MapInstanceID;
        public Integer X;
        public Integer Y;
        public SPoint Coords { get; set; }
        public static SMapPosition Empty { get; set; }
        public SMap Map { get; set; }
        public static SMapPosition FromString(String Expression) { return null; }
        public void ToJs() { }
        public SMapPosition(Integer PosX, Integer PosY, Boolean InOrbit) { }
    }
}

