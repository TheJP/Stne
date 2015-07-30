using StneApi;
using static StneApi.CScriptGlobal;

public class Sample2 : StneWebProgram
{
    public override void Main()
    {
        CUser user = new CUser(43237);
        Response.Add(CUser.Create(25).GetHtmlNameAndID(false));
        Response.Add(Request.User.GetHtmlNameAndID());
        Response.Add(user.GetHtmlName());
    }
}
