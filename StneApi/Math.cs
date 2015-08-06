namespace StneApi
{
    /// <summary>
    /// This is a type, which was automatically generated for the StneApi.
    /// More Infos and the source code can be found here: http://github.com/TheJP/Stne
    /// </summary>
    public static class Math
    {
        /// <summary> Represents the natural logarithmic base, specified by the constant, e. </summary>
        public static Double E;
        /// <summary> Represents the ratio of the circumference of a circle to its diameter, specified by the constant, PI. </summary>
        public static Double PI;
        /// <summary> Returns the absolute value of a double-precision floating-point number. </summary>
        /// <param name="value">A number that is greater than or equal to Double.MinValue, but less than or equal to Double.MaxValue.</param>
        /// <returns>A double-precision floating-point number, x, such that 0 &lt;= x &lt;= Double.MaxValue.</returns>
        /// <remarks>The absolute value of a number is its numeric value without its sign. For example, the absolute value of both 123 and -123 is 123.</remarks>
        public static Double Abs(Double value) { return null; }
        /// <summary> Returns the absolute value of a 16-bit signed integer. </summary>
        /// <param name="value">A number that is greater than Short.MinValue, but less than or equal to Short.MaxValue.</param>
        /// <returns>A 16-bit signed integer, x, such that 0 &lt;= x &lt;= Short.MaxValue.</returns>
        /// <remarks>The absolute value of a number is its numeric value without its sign. For example, the absolute value of both 123 and -123 is 123.</remarks>
        public static Short Abs(Short value) { return null; }
        /// <summary> Returns the absolute value of a 64-bit signed integer. </summary>
        /// <param name="value">A number that is greater than Long.MinValue, but less than or equal to Long.MaxValue.</param>
        /// <returns>A 64-bit signed integer, x, such that 0 &lt;= x &lt;= Long.MaxValue.</returns>
        /// <remarks>The absolute value of a number is its numeric value without its sign. For example, the absolute value of both 123 and -123 is 123.</remarks>
        public static Long Abs(Long value) { return null; }
        /// <summary> Returns the absolute value of a 32-bit signed integer. </summary>
        /// <param name="value">A number that is greater than Integer.MinValue, but less than or equal to Integer.MaxValue.</param>
        /// <returns>A 32-bit signed integer, x, such that 0 &lt;= x &lt;= Integer.MaxValue.</returns>
        /// <remarks>The absolute value of a number is its numeric value without its sign. For example, the absolute value of both 123 and -123 is 123.</remarks>
        public static Integer Abs(Integer value) { return null; }
        /// <summary> Returns the angle whose cosine is the specified number. </summary>
        /// <param name="d">A number representing a cosine, where d must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <returns>
        /// An angle, a, measured in radians, such that 0 &lt;= a &lt;= PI
        /// -or-
        /// NaN if d &lt; -1 or d &gt; 1 or d equals NaN.
        /// </returns>
        /// <remarks>
        /// Multiply the return value by 180/Math.PI to convert from radians to degrees.
        /// </remarks>
        public static Double Acos(Double d) { return null; }
        /// <summary> Returns the angle whose sine is the specified number. </summary>
        /// <param name="d">A number representing a sine, where d must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <returns>
        /// An angle, a, measured in radians, such that -PI/2 &lt;= a &lt;= PI/2
        /// -or-
        /// NaN if d &lt; -1 or d &gt; 1 or d equals NaN.
        /// </returns>
        /// <remarks>
        /// A positive return value represents a counterclockwise angle from the x-axis; a negative return value represents a clockwise angle.
        /// Multiply the return value by 180/Math.PI to convert from radians to degrees.
        /// </remarks>
        public static Double Asin(Double d) { return null; }
        /// <summary> Returns the angle whose tangent is the specified number. </summary>
        /// <param name="d">A number representing a tangent.</param>
        /// <returns>
        /// An angle, a, measured in radians, such that -PI/2 &lt;= a &lt;= PI/2
        /// -or-
        /// NaN if d equals NaN, -PI/2 rounded to double precision (-1.5707963267949) if d equals NegativeInfinity, or PI/2 rounded to double precision (1.5707963267949) if d equals PositiveInfinity.
        /// </returns>
        /// <remarks>
        /// A positive return value represents a counterclockwise angle from the x-axis; a negative return value represents a clockwise angle.
        /// Multiply the return value by 180/Math.PI to convert from radians to degrees.
        /// </remarks>
        public static Double Atan(Double d) { return null; }
        /// <summary> Returns the angle whose tangent is the quotient of two specified numbers. </summary>
        /// <param name="y">The y coordinate of a point.</param>
        /// <param name="x">The x coordinate of a point. </param>
        /// <returns>
        /// An angle, a, measured in radians, such that -PI &lt;= a &lt;= PI, and tan(a) = y / x, where (x, y) is a point in the Cartesian plane.
        /// If x or y is NaN, or if x and y are either PositiveInfinity or NegativeInfinity, the method returns NaN.
        /// </returns>
        /// <remarks>
        /// The return value is the angle in the Cartesian plane formed by the x-axis, and a vector starting from the origin, (0,0), and terminating at the point, (x,y).
        /// </remarks>
        public static Double Atan2(Double y, Double x) { return null; }
        /// <summary> Produces the full product of two 32-bit numbers. </summary>
        /// <param name="a">The first number to multiply.</param>
        /// <param name="b">The second number to multiply.</param>
        /// <returns>The number containing the product of the specified numbers.</returns>
        public static Long BigMul(Integer a, Integer b) { return null; }
        /// <summary> Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number. </summary>
        /// <param name="a">A double-precision floating-point number.</param>
        /// <returns>The smallest integral value that is greater than or equal to a. If a is equal to NaN, NegativeInfinity, or PositiveInfinity, that value is returned. Note that this method returns a Double instead of an integral type.</returns>
        /// <remarks>The behavior of this method follows IEEE Standard 754, section 4. This kind of rounding is sometimes called rounding toward positive infinity. In other words, if a is positive, the presence of any fractional component causes a to be rounded to the next highest integer. If a is negative, the rounding operation causes any fractional component of a to be discarded. The operation of this method differs from the Floor(Double) method, which supports rounding toward negative infinity.</remarks>
        public static Double Ceiling(Double a) { return null; }
        /// <summary> Returns the cosine of the specified angle. </summary>
        /// <param name="d">An angle, measured in radians.</param>
        /// <returns>The cosine of d. If d is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        /// <remarks>
        /// The angle, value, must be in radians. Multiply by Math.PI/180 to convert degrees to radians.
        /// Acceptable values of d range from approximately -9223372036854775295 to approximately 9223372036854775295. For values outside this range, the Cos method returns d unchanged rather than throwing an exception.
        /// </remarks>
        public static Double Cos(Double d) { return null; }
        /// <summary> Returns the hyperbolic cosine of the specified angle. </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic cosine of value. If value is equal to NegativeInfinity or PositiveInfinity, PositiveInfinity is returned. If value is equal to NaN, NaN is returned.</returns>
        /// <remarks>The angle, value, must be in radians. Multiply by Math.PI/180 to convert degrees to radians.</remarks>
        public static Double Cosh(Double value) { return null; }
        /// <summary> Returns e raised to the specified power. </summary>
        /// <param name="d">A number specifying a power.</param>
        /// <returns>The number e raised to the power d. If d equals NaN or PositiveInfinity, that value is returned. If d equals NegativeInfinity, 0 is returned.</returns>
        /// <remarks>
        /// Use the Pow method to calculate powers of other bases.
        /// Exp is the inverse of Log.
        /// </remarks>
        public static Double Exp(Double d) { return null; }
        /// <summary> Returns the largest integer less than or equal to the specified double-precision floating-point number. </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>The largest integer less than or equal to d. If d is equal to NaN, NegativeInfinity, or PositiveInfinity, that value is returned.</returns>
        /// <remarks>The behavior of this method follows IEEE Standard 754, section 4. This kind of rounding is sometimes called rounding toward negative infinity. In other words, if d is positive, any fractional component is truncated. If d is negative, the presence of any fractional component causes it to be rounded to the smaller integer. The operation of this method differs from the Ceiling method, which supports rounding toward positive infinity.</remarks>
        public static Double Floor(Double d) { return null; }
        /// <summary> Returns the remainder resulting from the division of a specified number by another specified number. </summary>
        /// <param name="x">A dividend.</param>
        /// <param name="y">A divisor.</param>
        /// <returns>
        /// A number equal to x - (y Q), where Q is the quotient of x / y rounded to the nearest integer (if x / y falls halfway between two integers, the even integer is returned).
        /// If x - (y Q) is zero, the value +0 is returned if x is positive, or -0 if x is negative.
        /// If y = 0, NaN is returned.
        /// </returns>
        public static Double IEEERemainder(Double x, Double y) { return null; }
        /// <summary> Returns the natural (base e) logarithm of a specified number. </summary>
        /// <param name="d">The number whose logarithm is to be found.</param>
        /// <returns>
        /// If d &gt; 0: The natural logarithm of d; that is, ln d.
        /// If d = 0: NegativeInfinity.
        /// If d &lt; 0 or if d = Nan: NaN.
        /// If d = PositiveInfinity: PositiveInfinity.
        /// </returns>
        public static Double Log(Double d) { return null; }
        /// <summary> Returns the logarithm of a specified number in a specified base. </summary>
        /// <param name="d">The number whose logarithm is to be found.</param>
        /// <param name="newBase">The base of the logarithm.</param>
        /// <returns></returns>
        public static Double Log(Double d, Double newBase) { return null; }
        /// <summary> Returns the base 10 logarithm of a specified number. </summary>
        /// <param name="d">A number whose logarithm is to be found.</param>
        /// <returns>
        /// If d &gt; 0: The base 10 log of d.
        /// If d = 0: NegativeInfinity.
        /// If d &lt; 0 or if d = Nan: NaN.
        /// If d = PositiveInfinity: PositiveInfinity.
        /// </returns>
        public static Double Log10(Double d) { return null; }
        /// <summary> Returns the larger of two 8-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static Byte Max(Byte val1, Byte val2) { return null; }
        /// <summary> Returns the larger of two 16-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 16-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 16-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static Short Max(Short val1, Short val2) { return null; }
        /// <summary> Returns the larger of two 32-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 32-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 32-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static Integer Max(Integer val1, Integer val2) { return null; }
        /// <summary> Returns the larger of two 64-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 64-bit unsigned integers to compare.</param>
        /// <param name="val2">The second of two 64-bit unsigned integers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger.</returns>
        public static Long Max(Long val1, Long val2) { return null; }
        /// <summary> Returns the larger of two double-precision floating-point numbers. </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is larger. If val1, val2, or both val1 and val2 are equal to NaN, NaN is returned. </returns>
        public static Double Max(Double val1, Double val2) { return null; }
        /// <summary> Returns the smaller of two 8-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 8-bit unsigned integers to compare. </param>
        /// <param name="val2">The second of two 8-bit unsigned integers to compare. </param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static Byte Min(Byte val1, Byte val2) { return null; }
        /// <summary> Returns the smaller of two 16-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 16-bit unsigned integers to compare. </param>
        /// <param name="val2">The second of two 16-bit unsigned integers to compare. </param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static Short Min(Short val1, Short val2) { return null; }
        /// <summary> Returns the smaller of two 32-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 32-bit unsigned integers to compare. </param>
        /// <param name="val2">The second of two 32-bit unsigned integers to compare. </param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static Integer Min(Integer val1, Integer val2) { return null; }
        /// <summary> Returns the smaller of two 64-bit unsigned integers. </summary>
        /// <param name="val1">The first of two 64-bit unsigned integers to compare. </param>
        /// <param name="val2">The second of two 64-bit unsigned integers to compare. </param>
        /// <returns>Parameter val1 or val2, whichever is smaller.</returns>
        public static Long Min(Long val1, Long val2) { return null; }
        /// <summary> Returns the smaller of two double-precision floating-point numbers. </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
        /// <returns>Parameter val1 or val2, whichever is smaller. If val1, val2, or both val1 and val2 are equal to NaN, NaN is returned.</returns>
        public static Double Min(Double val1, Double val2) { return null; }
        /// <summary> Returns a specified number raised to the specified power. </summary>
        /// <param name="x">A double-precision floating-point number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number x raised to the power y.</returns>
        public static Double Pow(Double x, Double y) { return null; }
        /// <summary> Rounds a double-precision floating-point value to a specified number of fractional digits. </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <returns>The number nearest to value that contains a number of fractional digits equal to digits.</returns>
        public static Double Round(Double value, Integer digits) { return null; }
        /// <summary> Rounds a double-precision floating-point value to the nearest integral value. </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <returns>The integer nearest a. If the fractional component of a is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a Double instead of an integral type.</returns>
        public static Double Round(Double value) { return null; }
        /// <summary> Returns a value indicating the sign of a 16-bit signed integer. </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        /// A number that indicates the sign of value:
        /// -1: value is less than zero.
        /// 0: value is equal to zero.
        /// 1: value is greater than zero.
        /// </returns>
        public static Integer Sign(Short value) { return null; }
        /// <summary> Returns a value indicating the sign of a 32-bit signed integer. </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        /// A number that indicates the sign of value:
        /// -1: value is less than zero.
        /// 0: value is equal to zero.
        /// 1: value is greater than zero.
        /// </returns>
        public static Integer Sign(Integer value) { return null; }
        /// <summary> Returns a value indicating the sign of a 64-bit signed integer. </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        /// A number that indicates the sign of value:
        /// -1: value is less than zero.
        /// 0: value is equal to zero.
        /// 1: value is greater than zero.
        /// </returns>
        public static Integer Sign(Long value) { return null; }
        /// <summary> Returns a value indicating the sign of a double-precision floating-point number. </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        /// A number that indicates the sign of value:
        /// -1: value is less than zero.
        /// 0: value is equal to zero.
        /// 1: value is greater than zero.
        /// </returns>
        public static Integer Sign(Double value) { return null; }
        /// <summary> Returns the sine of the specified angle. </summary>
        /// <param name="a">An angle, measured in radians.</param>
        /// <returns>The sine of a. If a is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        /// <remarks>
        /// The angle, a, must be in radians. Multiply by Math.PI/180 to convert degrees to radians. 
        /// Acceptable values of a range from approximately -9223372036854775295 to approximately 9223372036854775295. For values outside of this range, the Sin method returns a unchanged rather than throwing an exception.
        /// </remarks>
        public static Double Sin(Double a) { return null; }
        /// <summary> Returns the hyperbolic sine of the specified angle. </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic sine of value. If value is equal to NegativeInfinity, PositiveInfinity, or NaN, this method returns a Double equal to value.</returns>
        /// <remarks>The angle, value, must be in radians. Multiply by Math.PI/180 to convert degrees to radians.</remarks>
        public static Double Sinh(Double value) { return null; }
        /// <summary> Returns the square root of a specified number. </summary>
        /// <param name="d">The number whose square root is to be found.</param>
        /// <returns>
        /// If d &gt;= 0: The positive square root of d.
        /// If d &lt; 0: NaN.
        /// If d = NaN: NaN.
        /// If d = PositiveInfinity: PositiveInfinity.
        /// </returns>
        public static Double Sqrt(Double d) { return null; }
        /// <summary> Returns the tangent of the specified angle. </summary>
        /// <param name="a">An angle, measured in radians.</param>
        /// <returns>The tangent of a. If a is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        /// <remarks>The angle, a, must be in radians. Multiply by Math.PI/180 to convert degrees to radians.</remarks>
        public static Double Tan(Double a) { return null; }
        /// <summary> Returns the hyperbolic tangent of the specified angle. </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic tangent of value. If value is equal to NegativeInfinity, this method returns -1. If value is equal to PositiveInfinity, this method returns 1. If value is equal to NaN, this method returns NaN.</returns>
        public static Double Tanh(Double value) { return null; }
        /// <summary> Calculates the integral part of a specified double-precision floating-point number. </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>
        /// The integral part of d; that is, the number that remains after any fractional digits have been discarded, or one of the values listed bellow;
        /// If d = NaN: NaN.
        /// If d = PositiveInfinity: PositiveInfinity.
        /// If d = NegativeInfinity: NegativeInfinity.
        /// </returns>
        /// <remarks>Truncate rounds d to the nearest integer towards zero.</remarks>
        public static Double Truncate(Double d) { return null; }
    }
}

