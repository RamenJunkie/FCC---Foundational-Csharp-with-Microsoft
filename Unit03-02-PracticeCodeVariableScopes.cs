// bool flag = true;
// int value = 0;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }
// Console.WriteLine($"Outside of code block: {value}");
//////////////////////////////////
// bool flag = true;
// if (flag) Console.WriteLine(flag);
//////////////////////////////////
// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");
/////////////////////////////////
///////  BAD CODE /////
// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// foreach (int number in numbers)
// {
//     int total;

//     total += number;

//     if (number == 42)
//     {
//        bool found = true;

//     }

// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");

/////////////////////
////// Fixed Code ////

int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;
foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;
}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");