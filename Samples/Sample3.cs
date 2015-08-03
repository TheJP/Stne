using StneApi;
using static StneApi.CScriptGlobal;

public class Sample3 : StneProgram
{
    public override void Main()
    {
        Integer five = 5;
        WriteLine(CStr(5 + 4));
        WriteLine(5 + 5);
        WriteLine(5 / 3.0 - 5);
        WriteLine("Are pcs edible? " + CStr(false));
    }
}
