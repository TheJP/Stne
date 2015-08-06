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
        Array<Integer> a = new Integer[]{ 4, 9 };
        Integer n = a[1];
        Array<Integer> b = new Integer[5,n*2];
        Integer n2 = b[4, 0];
        WriteLine(n + " " + n2);
        foreach(var i in a)
        {
            WriteLine(i + " is in a");
        }
    }
}
