using StneApi;
using static StneApi.CScriptGlobal;

public class Sample1 : StneProgram
{
    public override void Main()
    {
        WriteLine(GetText());
        WriteLine(GetText2());
    }
    private String GetText() { return "Hello World"; }
    private String GetText2() => "Hello World with Lambda";
}
