using StneApi;
using static StneApi.CScriptGlobal;

/// <summary>
/// Idea and stne script from akaris. All credits to him.
/// This is only a reimplementation in c# (proof of concept).
/// </summary>
public class Sample6 : StneWebProgram
{
    public override void Main()
    {
        ScriptContext.EnableExtension();
        var filter = CGuiEventFilter.Create().AddControl(EGuiControl.ShipList_ShipTable);
        ScriptContext.RegisterEvent(EGuiEventType.TableBeforeCreate, AddressOf(TableBeforeCreateCallBack), filter);

    }

    public void TableBeforeCreateCallBack(CGuiEventOnTableBeforeCreate e)
    {
    }
}
