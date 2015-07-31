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
        public static implicit operator StneApi.String(StneNumericType o) => null;
        public static StneNumericType operator +(StneNumericType lhs, StneNumericType rhs) => null;
        public static StneNumericType operator -(StneNumericType lhs, StneNumericType rhs) => null;
        public static StneNumericType operator *(StneNumericType lhs, StneNumericType rhs) => null;
        public static StneNumericType operator /(StneNumericType lhs, StneNumericType rhs) => null;
        public static StneNumericType operator -(StneNumericType o) => null;
        public static Boolean operator <(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator >(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator >=(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator <=(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator ==(StneNumericType lhs, StneNumericType rhs) => null;
        public static Boolean operator !=(StneNumericType lhs, StneNumericType rhs) => null;
    }
}
