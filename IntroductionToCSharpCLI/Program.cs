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