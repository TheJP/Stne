namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CBaseColonyManager
    {
        public void ActivateBuilding(String Position, Boolean Status) { }
        public void ChargeShields(String Position, Integer Menge) { }
        public void FillEmergencyFusionChamber(String Position, Integer Menge) { }
        public Integer GetBeamProtection(EGoodsType Type) { return null; }
        public void RepairBuilding(String Position, Integer Menge) { }
        public void Replicate(String Position, Integer Menge, EReplicatorGoods Von, EReplicatorGoods Zu) { }
        public void SetAlertLevel(EAlertLevel Stufe) { }
        public Integer SetBeamProtection(EGoodsType Type, Integer Value) { return null; }
        public void SetBuildingName(String Position, String Name) { }
        public void SetImigrationLimit(Integer Grenze) { }
        public void SetTorpedoProduction(String Position, ETorpedoType TorpedoTyp) { }
        public void Shipyard_Build(String WerftPosition, EShipType ShipTyp) { }
        public void Shipyard_ChargeEmergencyBattery(Integer ShipID, Integer Menge) { }
        public void Shipyard_Repair(Integer ShipID, Integer Menge) { }
        public void TransferFromShip(Integer FromShipID, Integer Anzahl, EBeamResource Ressource) { }
        public void TransferToShip(Integer ToShipID, Integer Anzahl, EBeamResource Ressource) { }
    }
}

