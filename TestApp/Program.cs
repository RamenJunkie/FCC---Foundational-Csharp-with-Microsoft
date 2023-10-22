// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);



// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);



// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");


// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");


// string value = "Monkey";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");


// Exercise 1
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// float total = 0;
// string code = "";
// float result = 0;

// foreach(string value in values) {
//     if(float.TryParse(value, out result))
//     {
//         total += float.Parse(value);
//     }
//     else
//     {
//         code = code + value;
//     }
// }

// Console.WriteLine(total);
// Console.WriteLine(code); 


// Exercise 2
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1;
decimal result2;
float result3;

// Your code here to set result1
result1 = Convert.ToInt32((value1/value2));
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
result2 = (decimal)(value2/(decimal)value3);

Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
result3 = value3/value1;

Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// Divide value1 by value2, display the result as an int: 2
// Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
// Divide value3 by value1, display the result as a float: 0.3583333