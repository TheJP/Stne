namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CHtmlListBox : CHtmlControl
    {
        public CHtmlListBoxItemCollection Items { get; set; }
        public Boolean Multiple { get; set; }
        public String Name { get; set; }
        public Integer RowCount { get; set; }
        public new CHtmlListBoxItem this[Integer Index] { get { return null; } set { } }
        public CHtmlListBoxItem Add(String Caption, String Value, Boolean Selected) { return null; }
        public CHtmlListBoxItem Add(String Caption, String Value) { return null; }
        public Integer Add(CHtmlListBoxItem ListItem) { return null; }
        public void SortByCaption() { }
        public void SortByValue() { }
        public CHtmlListBox(String Name) { }
    }
}

