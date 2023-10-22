// Check for Values, Check for input, String Processing Challenges

// Check that Inpuit is an integer

string? readResult;
bool invalidEntry = true;

do
{
    Console.WriteLine("Enter the password (any integer number):");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (int.TryParse(readResult, out _))
        {
            invalidEntry = false;
        }
        else
        {
            Console.WriteLine("Incorrect Password, Try again.");
        }
    }
} while (invalidEntry);

// Verify String Input

string[] validRoles = {"Administrator", "Manager", "User"};
invalidEntry = true;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if(validRoles.Contains(readResult))
        {
            Console.WriteLine($"Role {readResult} accepted, thank you.");
            invalidEntry = false;
        }
        else
        {
            Console.WriteLine($"Invalie role entry {readResult}.");
        }
    }
} while(invalidEntry);

// String manipulationw ith loops and while and what????
// This challenge is rediculous because there is a built in functiont o do all this nonsense of splitting a string.
// I'm doing it logically.
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string line in myStrings)
{
foreach (string likes in line.Replace(". ",".").Split('.'))
    {
        Console.WriteLine(likes);
    }
}
