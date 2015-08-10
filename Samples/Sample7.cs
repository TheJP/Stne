using StneApi;
using static StneApi.CScriptGlobal;
using static Sample7Globals;

[Config]
public class Sample7Globals
{
    public static Integer FleetId = 5;
    public static Integer PlasmaAmount = 1000;
    public static Integer DeutAmount = 2300;
    public static EBeamResource product = EBeamResource.Plasma;
    public static EBeamResource ingredient = EBeamResource.Deuterium;
}

/// <summary>
/// A custom transfer/transportation script.
/// Also demonstrates how to use a configuration.
/// </summary>
public class Sample7 : StneProgram
{
    public override void Main()
    {
        var fleet = new CMyFleet(FleetId);
        //Fly to Plasma producer
        fleet.Action.LeaveOrbit();
        fleet.Action.Fly(6, EShipDirection.down);
        fleet.Action.Fly(4, EShipDirection.right);
        fleet.Action.EnterOrbit();
        //Transfer from Plasma producer
        var producerId = fleet.Ships[0].Sector.SectorID;
        fleet.Action.TransferFromColony(producerId, PlasmaAmount, product);
        fleet.Action.TransferToColony(producerId, DeutAmount, ingredient);
        //Fly to Plasma destination
        fleet.Action.LeaveOrbit();
        fleet.Action.Fly(4, EShipDirection.left);
        fleet.Action.Fly(6, EShipDirection.up);
        fleet.Action.EnterOrbit();
        //Transfer to Plasma destination
        var destinationId = fleet.Ships[0].Sector.SectorID;
        fleet.Action.TransferFromColony(destinationId, DeutAmount, ingredient);
        fleet.Action.TransferToColony(destinationId, PlasmaAmount, product);
    }
}
