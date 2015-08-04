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
        Array<Integer> a = new Integer[]{ 4 };
        Array<Integer> b = new Integer[5];
    }
}
