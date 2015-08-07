namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public class Date : StneValueType
    {
        public static Date MaxValue;
        public static Date MinValue;
        public Date Date { get; set; }
        public Integer Day { get; set; }
        public object DayOfWeek { get; set; }
        public Integer DayOfYear { get; set; }
        public Integer Hour { get; set; }
        public object Kind { get; set; }
        public Integer Millisecond { get; set; }
        public Integer Minute { get; set; }
        public Integer Month { get; set; }
        public static Date Now { get; set; }
        public Integer Second { get; set; }
        public Long Ticks { get; set; }
        public object TimeOfDay { get; set; }
        public static Date Today { get; set; }
        public static Date UtcNow { get; set; }
        public Integer Year { get; set; }
        public Date AddDays(Double value) { return null; }
        public Date AddHours(Double value) { return null; }
        public Date AddMilliseconds(Double value) { return null; }
        public Date AddMinutes(Double value) { return null; }
        public Date AddMonths(Integer months) { return null; }
        public Date AddSeconds(Double value) { return null; }
        public Date AddTicks(Long value) { return null; }
        public Date AddYears(Integer value) { return null; }
        public static Integer Compare(Date t1, Date t2) { return null; }
        public Integer CompareTo(Date value) { return null; }
        public Integer CompareTo(Object value) { return null; }
        public static Integer DaysInMonth(Integer year, Integer month) { return null; }
        public static Date FromBinary(Long dateData) { return null; }
        public static Date FromFileTime(Long fileTime) { return null; }
        public static Date FromFileTimeUtc(Long fileTime) { return null; }
        public static Date FromOADate(Double d) { return null; }
        public void GetDateTimeFormats(Char format) { }
        public void GetDateTimeFormats() { }
        public void GetTypeCode() { }
        public Boolean IsDaylightSavingTime() { return null; }
        public static Boolean IsLeapYear(Integer year) { return null; }
        public static Boolean op_Equality(Date d1, Date d2) { return null; }
        public static Boolean op_GreaterThan(Date t1, Date t2) { return null; }
        public static Boolean op_GreaterThanOrEqual(Date t1, Date t2) { return null; }
        public static Boolean op_Inequality(Date d1, Date d2) { return null; }
        public static Boolean op_LessThan(Date t1, Date t2) { return null; }
        public static Boolean op_LessThanOrEqual(Date t1, Date t2) { return null; }
        public static void op_Subtraction(Date d1, Date d2) { }
        public static Date Parse(String s) { return null; }
        public void Subtract(Date value) { }
        public Long ToBinary() { return null; }
        public Long ToFileTime() { return null; }
        public Long ToFileTimeUtc() { return null; }
        public Date ToLocalTime() { return null; }
        public String ToLongDateString() { return null; }
        public String ToLongTimeString() { return null; }
        public Double ToOADate() { return null; }
        public String ToShortDateString() { return null; }
        public String ToShortTimeString() { return null; }
        public Date ToUniversalTime() { return null; }
        public Date(Integer year, Integer month, Integer day, Integer hour, Integer minute, Integer second, Integer millisecond) { }
        public Date(Integer year, Integer month, Integer day, Integer hour, Integer minute, Integer second) { }
        public Date(Long ticks) { }
        public Date(Integer year, Integer month, Integer day) { }
        public static implicit operator String(Date o) => null;
    }
}

