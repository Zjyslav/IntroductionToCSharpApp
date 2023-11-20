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
OrderPrecedence();
TestLimits();
WorkWithDoubles();

Console.WriteLine("*********");

void WorkWithIntegers()
{
    Console.WriteLine("Explore integer math:");
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
void OrderPrecedence()
{
    Console.WriteLine("Explore order of operations:");
    int a = 5;
    int b = 4;
    int c = 2;
    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine();

    Console.WriteLine("a + b * c");
    int d = a + b * c;
    Console.WriteLine(d);
    Console.WriteLine();

    Console.WriteLine("(a + b) * c");
    d = (a + b) * c;
    Console.WriteLine(d);
    Console.WriteLine();

    Console.WriteLine("(a + b) - 6 * c + (12 * 4) / 3 + 12");
    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);
    Console.WriteLine();

    int e = 7;
    int f = 4;
    int g = 3;
    Console.WriteLine($"e = {e}, f = {f}, g = {g}");

    Console.WriteLine("(e + f) / g");
    int h = (e + f) / g;
    Console.WriteLine(h);
    Console.WriteLine();
}
void TestLimits()
{
    Console.WriteLine("Explore integer precision and limits:");
    int a = 7;
    int b = 4;
    int c = 3;
    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine();

    Console.WriteLine("(a + b) / c");
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");
    Console.WriteLine();

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}.");

    int what = max + 3;
    Console.WriteLine($"An example of overflow (max int value + 3): {what}");
    Console.WriteLine();
}
void WorkWithDoubles()
{
    Console.WriteLine("Work with the double type:");
    double a = 5;
    double b = 4;
    double c = 2;
    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine();

    Console.WriteLine("(a + b) / c");
    double d = (a + b) / c;
    Console.WriteLine(d);
    Console.WriteLine();

    double e = 19;
    double f = 23;
    double g = 8;
    Console.WriteLine($"e = {e}, f = {f}, g = {g}");
    Console.WriteLine();

    Console.WriteLine("(e + f) / g");
    double h = (e + f) / g;
    Console.WriteLine(h);
    Console.WriteLine();

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}.");
    Console.WriteLine();

    Console.WriteLine("1.0 / 3.0");
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
    Console.WriteLine();

    Console.WriteLine("Doubles challenge:");
    double x = 19.19;
    double y = 0.002;
    double z = 0.01;
    Console.WriteLine($"x = {x}, y = {y}, z = {z}");
    Console.WriteLine();

    Console.WriteLine("x * y");
    Console.WriteLine(x * y);
    Console.WriteLine();

    Console.WriteLine("(x * y) / z");
    Console.WriteLine((x * y) / z);
    Console.WriteLine();

    Console.WriteLine("x * x * x * x / z / z / z ");
    Console.WriteLine(x*x*x*x/z/z/z);
    Console.WriteLine();

    Console.WriteLine("(x + y) * (z + y)");
    Console.WriteLine((x + y) * (z + y));
    Console.WriteLine();
}
}
#endregion