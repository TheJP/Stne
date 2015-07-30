using StneApi;
using static StneApi.CScriptGlobal;

public class Sample1 : StneProgram
{
    public override void Main()
    {
        WriteLine(GetText());
    }
    private String GetText() { return "Hello World"; }
}
