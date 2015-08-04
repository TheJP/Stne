using StneApi;
using static StneApi.CScriptGlobal;

public class Sample5 : StneShipPortal
{
    public override void Main()
    {
        foreach(var ship in MyShip.SRS)
        {
            Response.Add(ship.GetNameHtmlAndID());
            Response.Add(new CHtmlBreak());
        }
    }
}
