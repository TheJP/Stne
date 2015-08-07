namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CHtmlGalaxyMap : Object
    {
        public object hmap;
        public object map;
        public Integer EndX { get; set; }
        public Integer EndY { get; set; }
        public Integer Height { get; set; }
        public Boolean Scale { get; set; }
        public Integer StartX { get; set; }
        public Integer StartY { get; set; }
        public Integer Width { get; set; }
        public CHtmlGalaxyMapItem this[Integer PosX, Integer PosY] { get { return null; } set { } }
        public CHtmlGalaxyMapItem this[SPoint Coords] { get { return null; } set { } }
        public CHtmlControl CreateControl() { return null; }
        public CHtmlGalaxyMap(SMap Map, SPoint StartPos, Integer Width, Integer Height) { }
    }
}

