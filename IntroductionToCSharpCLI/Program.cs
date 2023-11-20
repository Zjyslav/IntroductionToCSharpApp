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
Numbers();
BranchesAndLoops();

#region numbers
void Numbers()
{
    // Numbers in C#
    // https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp-local
    Console.WriteLine("Numbers in C# tutorial:");

    WorkWithIntegers();
    OrderPrecedence();
    TestLimits();
    WorkWithDoubles();
    WorkWithDecimals();

    Console.WriteLine("*********");
}

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
void WorkWithDecimals()
{
    Console.WriteLine("Work with decimal types:");
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of decimal type is {min} to {max}.");
    Console.WriteLine();

    Console.WriteLine("1/3 with doubles:");
    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    Console.WriteLine("1/3 with decimals:");
    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);
    Console.WriteLine();

    Console.WriteLine("Challenge:");
    double r = 2.50;
    Console.WriteLine($"Area of a circle with radius = {r}cm is {AreaOfCircle(r)}cm^2.");

    Console.WriteLine();
}
double AreaOfCircle(double r) => Math.PI * r * r;
#endregion

#region branches
void BranchesAndLoops()
{
    // C# if statements and loops - conditional logic tutorial
    // https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops-local
    Console.WriteLine("C# if statements and loops - conditional logic tutorial:");

    ExploreIf();
    ExploreLoops();
    CombineBranchesAndLoops();

    Console.WriteLine("*********");
}

void ExploreIf()
{
    Console.WriteLine("Make decisions using the if statement:");
    int a = 5;
    int b = 6;
    Console.WriteLine($"a = {a}, b = {b}");

    Console.WriteLine("a + b");
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10.");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10.");
    }
    Console.WriteLine();

    b = 3;
    Console.WriteLine($"a = {a}, b = {b}");
    Console.WriteLine("a + b");
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10;");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10.");
    }
    Console.WriteLine();

    a = 1;
    b = 1;
    int c = 4;
    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine("(a + b + c > 10) || (a == b)");
    if ((a + b + c > 10) || (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is equal to the second.");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not equal to the second.");
    }
    Console.WriteLine();
}
void ExploreLoops()
{
    Console.WriteLine("Use loops to repeat operations:");
    Console.WriteLine("while loop:");
    int counter = 0;
    while (counter < 10)
    {
        Console.WriteLine($"Hello World! The counter is {counter}.");
        counter++;
    }
    Console.WriteLine();

    Console.WriteLine("do while loop:");
    counter = 0;
    do
    {
        Console.WriteLine($"Hello World! The counter is {counter}.");
        counter++;
    } while (counter < 10);
    Console.WriteLine();

    Console.WriteLine("for loop:");
    for (int index = 0; index < 10; index++)
    {
        Console.WriteLine($"Hello World! The index is {index}.");
    }
    Console.WriteLine();

    Console.WriteLine("Created nested loops:");
    for (int row = 1; row < 11; row++)
    {
        Console.WriteLine($"The row is {row}.");
    }
    Console.WriteLine();

    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The column is {column}.");
    }
    Console.WriteLine();

    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
    Console.WriteLine();
    }
void CombineBranchesAndLoops()
{
    Console.WriteLine("Combine branches and loops:");
    int start = 1;
    int end = 20;
    int divisibleBy = 3;
    int sum = 0;

    for (int i = start; i < end + 1; i++)
    {
        if (i % divisibleBy == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine($"Sum of integers between {start} and {end} divisible by {divisibleBy} is {sum}.");
    Console.WriteLine();
}
#endregion