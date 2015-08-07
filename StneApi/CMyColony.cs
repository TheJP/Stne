namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CMyColony : CColony
    {
        public CBaseColonyManager Action { get; set; }
        public CBuildingList Buildings { get; set; }
        public Integer Energy { get; set; }
        public Integer EnergyBalance { get; set; }
        public Integer EnergyCapacity { get; set; }
        public Integer EnergyCapacityFree { get; set; }
        public Integer EnergyConsumption { get; set; }
        public Integer EnergyProduction { get; set; }
        public CColonyFieldList Fields { get; set; }
        public Double Larne { get; set; }
        public Integer LivingSpace { get; set; }
        public CColonyMap Map { get; set; }
        public Integer MaxBeamProtection { get; set; }
        public CColonyMap OrbitMap { get; set; }
        public Integer Population { get; set; }
        public CShipList SRS { get; set; }
        public CStockRoom StockRoom { get; set; }
        public CBuilding BuildingByID(Integer FeldID) { return null; }
        public CBuilding BuildingByIndex(Integer Index) { return null; }
        public CBuilding BuildingByPosition(String Position) { return null; }
        public CColonyField FieldByID(Integer FeldID) { return null; }
        public CColonyField FieldByPosition(String Position) { return null; }
        public Integer GetBalance(EGoodsType Type) { return null; }
        public CMyColony(Integer KolonieID) : base(KolonieID) { }
        public CMyColony(Integer PosX, Integer PosY) : base(PosX, PosY) { }
        public CMyColony(Integer PosX, Integer PosY, SMap Map) : base(PosX, PosY, Map) { }
    }
}

