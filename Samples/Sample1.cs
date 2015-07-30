using StneApi;
using static StneApi.CScriptGlobal;

namespace Samples
{
    public class Sample1 : StneProgram
    {
        public override void Main()
        {
            WriteLine(this.GetText());
        }
        private String GetText() { return "Hello World"; }
    }
}
