void Introduction()
{
    // Hello World - Introduction to C#
// https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world

Console.WriteLine("Hello World - Introduction to C# tutorial:");
Console.WriteLine();

#region step1
Console.WriteLine("Step 1:");

Console.WriteLine("Hello World!");

Console.WriteLine();
#endregion

#region step2
Console.WriteLine("Step 2:");

string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");

Console.WriteLine();
#endregion

#region step3
Console.WriteLine("Step 3:");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

Console.WriteLine();
#endregion

#region step4
Console.WriteLine("Step 4:");

string greeting = "             Hello World!          ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

Console.WriteLine();
#endregion

#region step5
Console.WriteLine("Steps 5:");
string songLyrics = "You say goodbye and I say hello";
Console.WriteLine($"Song lyrics contain \"goodbye\": {songLyrics.Contains("goodbye")}");
Console.WriteLine($"Song lyrics contain \"greetings\": {songLyrics.Contains("greetings")}");

Console.WriteLine($"Song lyrics start with \"You\": {songLyrics.StartsWith("You")}");
Console.WriteLine($"Song lyrics start with \"goodbye\": {songLyrics.StartsWith("goodbye")}");

Console.WriteLine($"Song lyrics end with \"hello\": {songLyrics.EndsWith("hello")}");
Console.WriteLine($"Song lyrics end with \"goodbye\": {songLyrics.EndsWith("goodbye")}");

Console.WriteLine();
#endregion

    Console.WriteLine("*********");
}

Introduction();

#region numbers
// Numbers in C#
// https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp-local
Console.WriteLine("Numbers in C# tutorial:");

WorkWithIntegers();

Console.WriteLine("*********");

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;

    Console.WriteLine($"a = {a}, b = {b}");
    Console.WriteLine();

    // addition
    Console.WriteLine("addition (a + b):");
    int c = a + b;
    Console.WriteLine(c);
    Console.WriteLine();

    //subtraction
    Console.WriteLine("subtraction (a - b):");
    c = a - b;
    Console.WriteLine(c);
    Console.WriteLine();

    // multiplication
    Console.WriteLine("multiplication (a * b):");
    c = a * b;
    Console.WriteLine(c);
    Console.WriteLine();

    // division
    Console.WriteLine("division (a / b):");
    c = a / b;
    Console.WriteLine(c);
    Console.WriteLine();
}
#endregion