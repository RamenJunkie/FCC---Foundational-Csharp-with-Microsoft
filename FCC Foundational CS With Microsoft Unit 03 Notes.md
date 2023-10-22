# Foundational C# with Microsoft

## Unit 3 - Add Logic to C# Console Applications

### Section 1 - Make Decisions with Boolians

#### Basic Boolean

Things work as expected from other languages.

```C#
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
```

Case sensetive etc.  "a" != "A" and "a" != "a " etc.

Ways to correct for these if they may be mistakes.

ToUpper() - All uppercase
ToLower() - All lowercase
Trim() - Remove trailing or anding spaces.

Example: valueString.Trim().ToLower();

#### Handle Discrepencies

You can check in a string is in another string with .Contains()

Example:

```C#
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
```

#### Logical Negation

Logical Negation works for reversing a boolean.

Example:

```C#
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
```

#### Conditional Operator

Quickly determing between a or b.

Exmaple:

```C#
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
```

Example of Real Code:

```C#
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
```

Amore compact version without a temporary variable:

```C#
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
```

It's basically saying, "Sale Amount greater than 1000?  If yes, 100, if no, 50."

### For Loops Notes

```C#
// Various For Loop Examples

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
```
### DO While Loops

```C#
// Do While Examples

Random random = new Random();
int current = random.Next(1, 11);


do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

// The continue statement breaks to the end at the While Condition, skipping over any remaining code.   
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

```

### Read Input Code Notes

Sample Code

```C#
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
```




### Unit Challenge - Pet Project Notes

DO WHILE LOOPS

```C# 
do
{
   // Body
} while (condition);
```

Check if a variable is an Integer  RETURNS A BOOL VALUE

```C#
int.TryParse("123", out _);
```

