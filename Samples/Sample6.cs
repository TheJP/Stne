using System;
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
        ScriptContext.RegisterEvent(EGuiEventType.TableAfterHeadAdded, AddressOf(HeadAddedCallBack), filter);
        ScriptContext.RegisterEvent(EGuiEventType.TableAfterRowAdded, AddressOf(RowAddedCallBack), filter);

        ScriptContext.ActivateEvents();
    }

    public void TableBeforeCreateCallBack(CGuiEventOnTableBeforeCreate e)
    {
        CGuiControlHelper.SetTableColumnCount(e.Table, CGuiControlHelper.TableColumnCount(e.Table) + 1);
    }

    private void HeadAddedCallBack(CGuiEventOnTableAfterHeadAdded e)
    {
        e.Row.Controls[e.Row.Count - 2].Add("Pos");
    }

    private void RowAddedCallBack(CGuiEventOnTableAfterRowAdded e)
    {
        CMyShip ship = (CMyShip)e.DataObject;
        var cell = e.Row.Controls[e.Row.Count - 2];
    }
}
