namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    class CBaseShipManager
    {
        public void ActivateLRS(Boolean Status) { }
        public void ActivateMaincomputer(Boolean Status) { }
        public void ActivateReplicators(Boolean Status) { }
        public void ActivateShields(Boolean Status) { }
        public void ActivateSRS(Boolean Status) { }
        public void ActivateTractorBeam(Integer ShipID) { }
        public void ActivateWarpCore(Boolean Status) { }
        public void ApplyGoodsToConstruction() { }
        public void CollectDeuterium(Integer Energie) { }
        public void CollectOre(Integer Energie) { }
        public void DeactivateTractorBeam() { }
        public void Defend(Integer ShipID) { }
        public void DockHangar(Integer InShipID) { }
        public void DockHangarForce(Integer TargetShip) { }
        public void DockTo(Integer ToShipID) { }
        public void DockToForce(Integer TargetShip) { }
        public void EnterOrbit() { }
        public void ExtractFromWreck(Integer Menge) { }
        public void Fly(Integer AnzahlFelder, EShipDirection Richtung) { }
        public void FlyTo(String Position) { }
        public void Hide(Boolean Versteckt) { }
        public void JettisonGoods(Integer Menge, EGoodsType WarenTyp) { }
        public void LeaveAllFleets() { }
        public void LeaveOrbit() { }
        public void RefillWarpCore(Double Menge, EWarpcoreFillType BasisWarenTyp) { }
        public void Repair(Boolean Status) { }
        public void ReserveBatterieEntladen(Integer Menge) { }
        public void SchildeAufladen(Integer Menge) { }
        public void SetAlertLevel(EAlertLevel Stufe) { }
        public void SetName(String Name) { }
        public void StationsReserveBatterieAufladen(Integer Menge) { }
        public void StopDefending() { }
        public void TransferFromColony(Integer FromColonieID, Integer Anzahl, EBeamResource Ressource) { }
        public void TransferFromShip(Integer FromShipID, Double Anzahl, EBeamResource Ressource) { }
        public void TransferToColony(Integer ToColonieID, Integer Anzahl, EBeamResource Ressource) { }
        public void TransferToShip(Integer ToShipID, Double Anzahl, EBeamResource Ressource) { }
        public void Undock() { }
        public void UndockForce(Integer TargetShip) { }
        public void UndockHangar() { }
        public void UndockHangarForce(Integer TargetShip) { }
    }
}

