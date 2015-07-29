namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CGoodsInfo : Object
    {
        public Integer GoodsID { get; set; }
        public EGoodsType GoodsType { get; set; }
        public String Name { get; set; }
        public Boolean Special { get; set; }
        public Boolean TradableOnCommodityExchenge { get; set; }
        public static CHtmlImage GetImage(EGoodsType WarenTyp) { return null; }
        public static String GetName(EGoodsType WarenTyp) { return null; }
        public CGoodsInfo(EGoodsType WarenTyp) { }
    }
}

