




## Variable Types

### Integral Types

```C#
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
```
Result

```C#
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807
```

```C#
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
```

Result

```C#
Output
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615
```

### Float Types

```C#
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
```

Result

```C#
Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
```

### Reference Types

```C#
int[] data;
data = new int[3];  //Array for 3 items

// Single Line
int[] data = new int[3];
```

### Strings

```C#
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);
```

### When in doubt, stick with the basics

While you've looked at several considerations, as you're getting started, for simplicity's sake you should prefer a subset of basic data types, including:

```X
    int for most whole numbers
    decimal for numbers representing money
    bool for true or false values
    string for alphanumeric value
```

Choose specialty complex types for special situations

Don't reinvent data types if one or more data type already exists for a given purpose. The following examples identify where a specific .NET data types can be useful:

```X
    byte: working with encoded data that comes from other computer systems or using different character sets.
    double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
    System.DateTime for a specific date and time value.
    System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
```
## Data Type Casting

Compiler will make "Safe Conversions".  IE, it will concatonate a string of an int + string, but will not create an int from an int + a string (of a number).

Casting will force a conversion but my fail, some samples...

Casting with ():

```C#
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
```

A narrowing cast, will lose precision.

```C#
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
```

Use ToString() to convert a number to a string

```C#
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
// Output = 57
```

Convert a string to an int using the Parse() helper method

```C#
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
// Output 12
```

Convert a string to a int using the Convert class

```C#
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
// Output 35
```

Casting vs Converting

```C#
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
// Output 1
// Output 2
```

### TryPrse()

Will try to perform the conversion and store it in an out format.  It returns a Bool value.

One Method:

```C#
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
```

Takes int he String "value", and the output is the int "result".  If the int.TryParse() works, then it outputs True, which triggers the if conditional, otherwise it moves to the Else which outputs the failure message.

Example with failure:

```C#
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine($"Measurement (w/ offset): {50 + result}");
```

Output:

```C#
Unable to report the measurement.
Measurement (w/ offset): 50
```

