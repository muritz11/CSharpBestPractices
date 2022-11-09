
/// <summary>
/// Variable names should use camel case, which is a style of writing that 
/// uses a lower-case letter at the beginning of the first word and an upper-case 
/// letter at the beginning of each subsequent word.
/// </summary>
string helloWorld;


/// <summary>
/// Variable names should be descriptive and meaningful in your application. 
/// You should choose a name for your variable that represents the kind of data it will hold.
/// </summary>
int age = 30; // ✔️
int x = 10; // ❌


/// <summary>
/// Variable names should be one or more entire words appended together. 
/// Don't use contractions, because the name of the variable may be unclear to others who are reading your code.
/// </summary>
int averageRate = 4; // ✔️
int avgRt = 4; // ❌


/// <summary>
/// Variable names shouldn't include the data type of the variable.
/// </summary>
string myValue; // ✔️
string strMyValue; // ❌


/// <summary>
/// Avoid low-level descriptive comment; code comments that unnecessarily explain 
/// the obvious functionality of individual lines of code and don't provide any context to the problem 
/// the code is solving..
/// </summary>
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, padd with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}



/// <summary>
/// Whitespace, when used properly, can increase your ability to read and comprehend the code.
/// </summary>
Console
.
WriteLine
(
"Hello World!"
)
;



/// <summary>
/// Each complete command (a statement) belongs on a separate line.
/// </summary>
string firstWord = "Hello"; string lastWord = "World"; Console.WriteLine(firstWord + " " + lastWord + "!"); // ❌
string xyz = "Hello"; 
string zxy = "World"; 
Console.WriteLine(firstWord + " " + lastWord + "!"); // ✔️



/// <summary>
/// Use a space to the left and right of the assignment operator.
/// </summary>
int height=192; // ❌
int length = 289; // ✔️



/// <summary>
/// Add whitespace to create phrasing and improve readability
/// </summary>

// ❌❌❌❌❌❌❌❌
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// ✔️✔️✔️✔️✔️✔️✔️✔️✔️✔️✔️
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}




/// <summary>
/// Avoid using common type system. Use the language specific aliases
/// </summary>

// ✔️✔️✔️✔️✔
int age;
string firstName;
object addressInfo;

// ❌❌❌❌
System.Int32 age; String firstName;
Object addressInfo;


// While comparing string, convert string variables into Upper or Lower case
// ✔️✔️✔️✔️
if (firstName.ToLower() == "yogesh") { }

// ❌❌❌
if (firstName == "yogesh") { }


// Use enums wherever required. Don’t use numbers or strings to indicate discrete values.
//✔️✔️✔️
public enum LoggerType
{
    Event,
    File,
    Database
}
public void LogException(string message, LoggerType loggerType)
{
    switch (loggerType)
    {
        case LoggerType.Event:
        // Do something break;  
        case LoggerType.File:
        // Do something break;  
        case LoggerType.Database:
        // Do something break;  
        default:
            // Do something break;  
    }
}

// bad
public void LogException(string message, LoggerType loggerType)
{
    switch (loggerType)
    {
        case "Event":
        // Do something break;  
        case "File":
        // Do something break;  
        case "Database":
        // Do something break;  
        default:
            // Do something break;  
    }
}



// Always do null check for objects and complex objects before accessing them.
Good: public Contact GetContactDetails(Address address)
{
    if (address != null && address.Contact != null)
    {
        return address.Contact;
    }
}
Bad: public Contact GetContactDetails(Address address)
{
    return address.Contact;
}

// Error message to end use should be user friendly and self-explanatory but log the actual exception details using logger. Create constants for this and use them in application.
Good:
“Error occurred while connecting to database. Please contact administrator.” “Your session has been expired. Please login again.”  
Bad:  
“Error in Application.”  
“There is an error in application.”  


// The using statements should be sort by framework namespaces first and then application namespaces in ascending order
using System;  
using System.Collections.Generic; using System.IO;  
using System.Text;  
using Company.Product.BusinessLayer;  



// Always catch only the specific exception instead of catching generic exception.
void ReadFile(string fileName)
{
    try
    {
        // read from file.  
    }
    catch (System.IO.IOException fileException)
    {
        // log the error. Re-throw exception throw fileException;  
    }
    finally { }
}
Bad: void ReadFile(string fileName)
{
    try
    {
        // read from file.  
    }
    catch (Exception ex)
    {
        // catching general exception  
    }
    finally { }
}