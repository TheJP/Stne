using System;

namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class CScriptGlobal
    {
        public static void WriteLine(String msg) { }
        public static String CStr(Boolean b) { return null; }
        public static String CStr(StneNumericType n) { return null; }
        /// <summary> Can fail! </summary>
        public static Boolean CBool(String n) { return null; }
        /// <summary> 0 results in False, Non 0 results in True </summary>
        public static Boolean CBool(StneNumericType n) { return null; }
        /// <summary> Can fail! </summary>
        public static Byte CByte(String n) { return null; }
        public static Byte CByte(StneNumericType n) { return null; }
        /// <summary> True results in 1, False results in 0 </summary>
        public static Byte CByte(Boolean n) { return null; }
        /// <summary> Can fail! </summary>
        public static Short CShort(String n) { return null; }
        public static Short CShort(StneNumericType n) { return null; }
        /// <summary> True results in 1, False results in 0 </summary>
        public static Short CShort(Boolean n) { return null; }
        /// <summary> Can fail! </summary>
        public static Integer CInt(String n) { return null; }
        public static Integer CInt(StneNumericType n) { return null; }
        /// <summary> True results in 1, False results in 0 </summary>
        public static Integer CInt(Boolean n) { return null; }
        /// <summary> Can fail! </summary>
        public static Long CLng(String n) { return null; }
        public static Long CLng(StneNumericType n) { return null; }
        /// <summary> True results in 1, False results in 0 </summary>
        public static Long CLng(Boolean n) { return null; }
        /// <summary>
        /// Can fail!
        /// Be cautious: Strings with the format "x.y" will convert to a number xy,
        /// while Strings with the format "x,y" will convert to a number x.y
        /// </summary>
        public static Double CDbl(String n) { return null; }
        public static Double CDbl(StneNumericType n) { return null; }
        /// <summary> True results in 1, False results in 0 </summary>
        public static Double CDbl(Boolean n) { return null; }
        public static CDelegate AddressOf(Action<CGuiEvent> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnGalaxyMapBeforeRender> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnInfoBarAfterCreate> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnPageBeforeCreateControls> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnPageBeforeExecuteAction> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnPageBeforeRender> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnTableAfterCreate> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnTableAfterHeadAdded> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnTableAfterRowAdded> action) => null;
        public static CDelegate AddressOf(Action<CGuiEventOnTableBeforeCreate> action) => null;
        public static CDelegate AddressOf(Action<CEvent> action) => null;
        public static CDelegate AddressOf(Action<CEventOnCreateControls> action) => null;
        public static CDelegate AddressOf(Action<CEventOnCreateOptions> action) => null;
        public static CDelegate AddressOf(Action<CEventOnCreatePage> action) => null;
        public static CDelegate AddressOf(Action<CEventOnDoAction> action) => null;
        public static CDelegate AddressOf(Action<CEventOnInit> action) => null;
        public static CDelegate AddressOf(Action<CEventOnRegisterEvents> action) => null;
    }
}

