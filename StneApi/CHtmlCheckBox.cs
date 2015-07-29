namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CHtmlCheckBox : CHtmlInput
    {
        public Boolean Checked { get; set; }
        public String Text { get; set; }
        public CHtmlCheckBox(Boolean Checked, String Name) : base(null, Name, null) { }
    }
}

