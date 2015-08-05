using StneApi;
using static StneApi.CScriptGlobal;

public class Sample4 : StneProgram
{
    public override void Main()
    {
        if (true)
        {
            WriteLine("True");
        }
        Integer live = 42;
        if(live == 42)
        {
            WriteLine("Correct");
        }
        else
        {
            WriteLine("False");
        }
        var s = (String)"foo";
        if (!((Boolean)1) || false && true)
        {
            WriteLine("Holly!!");
            WriteLine("Why Not!");
        }
        else if ((String)"foo" != "bar")
        {
            WriteLine((Boolean)1);
        }
        Boolean myBool = false;
        var r = new Random(42);
        while (!myBool)
        {
            WriteLine("Hya");
            myBool = r.Next(0, 2) == 0;
        }
        for (Integer i = 0; i < 3; ++i)
        {
            WriteLine(i);
        }
        for(Integer j = 0, k = 0; j < 3; ++j, k+= 2)
        {
            WriteLine(j + " " + k);
        }
    }
}
