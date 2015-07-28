namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CShip : CBaseShip
    {
        public EAlertLevel AlertLevel { get; set; }
        public Integer Crew { get; set; }
        public Boolean Docked { get; set; }
        public CBaseShip DockedTo { get; set; }
        public Integer DockedToShipID { get; set; }
        public Double Energy { get; set; }
        public Double Eps { get; set; }
        public Double Hull { get; set; }
        public Double Shields { get; set; }
        public Boolean ShieldsActive { get; set; }
        public CStockRoom StockRoom { get; set; }
        public Integer TractorFromShipID { get; set; }
        public Integer TractorToShipID { get; set; }
        public Boolean WeaponsActivated { get; set; }
        public Boolean FreeDockingPorts(CBaseShip Ship) { return null; }
        public Boolean FreeDockingPortsHangar(CBaseShip Ship) { return null; }
    }
}

