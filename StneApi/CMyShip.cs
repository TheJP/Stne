namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CMyShip : CShip
    {
        public CBaseShipManager Action { get; set; }
        public EAutoPilotType AutoPilotType { get; set; }
        public Double BussardCollectorHeating { get; set; }
        public CUser CoPilot { get; set; }
        public CColony Colony { get; set; }
        public Integer CoPilotID { get; set; }
        public Boolean DamageControlActive { get; set; }
        public Integer DefendingShipID { get; set; }
        public Double Deflector { get; set; }
        public Integer DisruptorHeating { get; set; }
        public Double EmergencyBattery { get; set; }
        public Integer FieldsFlown { get; set; }
        public Double FlightRange { get; set; }
        public CGalaxyMapItem GalaxyMapItem { get; set; }
        public Double Gondola { get; set; }
        public Boolean IsHidden { get; set; }
        public Double Larne { get; set; }
        public EShipLogType LogType { get; set; }
        public Boolean LRSIsActive { get; set; }
        public ELRSNumericType LRSNumericType { get; set; }
        public Double LRSShipSlots { get; set; }
        public Integer LRSSize { get; set; }
        public Boolean MainComputerIsActive { get; set; }
        public Object Maneuver { get; set; }
        public Boolean ManeuverActive { get; set; }
        public Double ManeuverRessourceMin { get; set; }
        public Double ManeuverTransferMax { get; set; }
        public Double OreCollectorHeating { get; set; }
        public Integer PhaserHeating { get; set; }
        public Integer RenameCount { get; set; }
        public Boolean ReplicatorIsActive { get; set; }
        public Byte ShieldsIonLevel { get; set; }
        public CShipList SRS { get; set; }
        public Boolean SRSIsActive { get; set; }
        public Boolean SystemBlockade { get; set; }
        public CMyShipTick Tick { get; set; }
        public Integer TorpedoHeating { get; set; }
        public EShipType Type { get; set; }
        public Double WarpCore { get; set; }
        public Boolean WarpCoreIsActive { get; set; }
        public CHtmlControl CreateItemGUI(Integer ItemID, String Method, CSortedStringObjectList Parameters) { return null; }
        public CHtmlControl CreateItemGUI(Integer ItemID, String Method, CSortedStringObjectList Parameters, CScriptUrl BaseUrl) { return null; }
        public Object InvokeItem(Integer ItemID, String Method, CSortedStringObjectList Parameters) { return null; }
        public CMyShip(Integer ShipID) { }
    }
}

