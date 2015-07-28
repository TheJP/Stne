namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CColonyMap
    {
        public CColony Colony { get; set; }
        public Boolean IsOrbital { get; set; }
        public Integer SizeX { get; set; }
        public Integer SizeY { get; set; }
        public CColonyField this[Integer x, Integer y] { get { return null; } set { } }
    }
}

