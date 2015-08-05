namespace StneApi
{
    /// <summary>
    /// Maker Interface for Numeric types.
    /// (Don't use this in scripts, beacuse it is not translatable to stne scripts)
    /// </summary>
    public abstract class StneNumericType : StneValueType
    {
        public static implicit operator StneNumericType(byte o) => null;
        public static implicit operator StneNumericType(char o) => null;
        public static implicit operator StneNumericType(short o) => null;
        public static implicit operator StneNumericType(int o) => null;
        public static implicit operator StneNumericType(long o) => null;
        public static implicit operator StneNumericType(double o) => null;
        public static implicit operator StneApi.String(StneNumericType o) => null;
        public static implicit operator byte (StneNumericType o) => 0;
        public static implicit operator char (StneNumericType o) => ' ';
        public static implicit operator short (StneNumericType o) => 0;
        public static implicit operator int (StneNumericType o) => 0;
        public static implicit operator long (StneNumericType o) => 0;
        public static implicit operator double (StneNumericType o) => 0;
        public static NumericResult operator +(StneNumericType lhs, StneNumericType rhs) => null;
        public static NumericResult operator -(StneNumericType lhs, StneNumericType rhs) => null;
        public static NumericResult operator *(StneNumericType lhs, StneNumericType rhs) => null;
        public static NumericResult operator /(StneNumericType lhs, StneNumericType rhs) => null;
        public static NumericResult operator -(StneNumericType o) => null;
        public static Boolean operator <(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator >(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator >=(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator <=(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator ==(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator !=(StneNumericType lhs, StneNumericType rhs) => null;

        public class NumericResult
        {
            public static implicit operator Byte(NumericResult o) => null;
            public static implicit operator Char(NumericResult o) => null;
            public static implicit operator Short(NumericResult o) => null;
            public static implicit operator Integer(NumericResult o) => null;
            public static implicit operator Long(NumericResult o) => null;
            public static implicit operator Double(NumericResult o) => null;
            public static implicit operator byte (NumericResult o) => 0;
            public static implicit operator char (NumericResult o) => ' ';
            public static implicit operator short (NumericResult o) => 0;
            public static implicit operator int (NumericResult o) => 0;
            public static implicit operator long (NumericResult o) => 0;
            public static implicit operator double (NumericResult o) => 0;
        }
    }
}
