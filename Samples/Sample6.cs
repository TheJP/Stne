using StneApi;
using static StneApi.CScriptGlobal;
using static Globals;

/// <summary>
/// Idea and stne script from akaris. All credits to him.
/// This is only a reimplementation in c# (proof of concept).
/// </summary>
public class Sample6 : StneExtensionProgram
{
    public override void Main()
    {
        ScriptContext.EnableExtension();

        var filter = CGuiEventFilter.Create().AddControl(EGuiControl.ShipList_ShipTable);
        ScriptContext.RegisterEvent(EGuiEventType.TableBeforeCreate, AddressOf(Globals.TableBeforeCreateCallBack), filter);
        ScriptContext.RegisterEvent(EGuiEventType.TableAfterHeadAdded, AddressOf(HeadAddedCallBack), filter);
        ScriptContext.RegisterEvent(EGuiEventType.TableAfterRowAdded, AddressOf(RowAddedCallBack), filter);

        ScriptContext.ActivateEvents();
    }
}

[Global]
public class Globals
{
    public static void TableBeforeCreateCallBack(CGuiEventOnTableBeforeCreate e)
    {
        CGuiControlHelper.SetTableColumnCount(e.Table, CGuiControlHelper.TableColumnCount(e.Table) + 2);
    }

    public static void HeadAddedCallBack(CGuiEventOnTableAfterHeadAdded e)
    {
        e.Row.Controls[e.Row.Count - 3].Add("Pos");
        e.Row.Controls[e.Row.Count - 2].Add("Info");
    }

    public static void RowAddedCallBack(CGuiEventOnTableAfterRowAdded e)
    {
        var ship = (CMyShip)e.DataObject;
        //Add lrs
        var cell = e.Row.Controls[e.Row.Count - 3];
        var div = new CHtmlDiv();
        if (ship.LRSShipSlots > ship.Definition.Slots)
        {
            var nTab = new CTable(1);
            nTab.Style.Add("width", "32px");
            nTab.Style.Add("height", "32px");
            var nRow = nTab.AddRow();
            nRow[0].Add(ship.LRSShipSlots);
            nRow[0].CssClass = "nbz";
            nRow[0].Style.Add("color", "#33FF33");
            div.Add(nTab);
        }
        cell.Add(div.GuiControl);
        div.Style.Add("background-image", "url(" + ship.GalaxyMapItem.GetImage().Url + ")");
        div.Style.Add("width", "32px");
        div.Style.Add("height", "32px");
        //Add colony information
        var cellColony = e.Row.Controls[e.Row.Count - 2];
        if (ship.Sector.IsColonised)
        {
            var colony = ship.Colony;
            var user = new CUser(colony.UserID);
            cellColony.Add(colony.Name + " von ");
            cellColony.Add(user.GetHtmlNameAndID().GuiControl);
        } else
        {
            cellColony.Add("-");
        }
    }
}
