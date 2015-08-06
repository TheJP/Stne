namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CGuiControlHelper : Object
    {
        public static IGuiControl AddCell(IGuiControl row) { return null; }
        public static IGuiControl AddRow(IGuiControl Table) { return null; }
        public static Integer ColumnSpan(IGuiControl Cell) { return null; }
        public static IGuiControl InsertCell(IGuiControl row, Integer Index) { return null; }
        public static void MergeRow(IGuiControl row, Integer Start, Integer Count) { }
        public static void SetColumnSpan(IGuiControl Cell, Integer Value) { }
        /// <summary> Sets the number of columns in the given table to the givne integer. </summary>
        /// <param name="Table">Table, in which the number of columns should be changed.</param>
        /// <param name="Value">Number of columns the table should have afterwards.</param>
        public static void SetTableColumnCount(IGuiControl Table, Integer Value) { }
        /// <summary> Callculates the number of columns in the given table. </summary>
        /// <param name="Table">Table, in which the columns should be counted.</param>
        /// <returns>Number of columns in the given table.</returns>
        public static Integer TableColumnCount(IGuiControl Table) { return null; }
    }
}

