System.Console.Write($"Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
System.Console.WriteLine(greeting);

System.Console.Write($"Enter your age: ");
string ageasString = Console.ReadLine();
System.Console.WriteLine($"Converting...");
int age = Convert.ToInt32(ageasString);
System.Console.WriteLine($"Sucessfully converted {age}");
int Keschasage = 3;
int ageDifference = age - Keschasage;
System.Console.WriteLine($"Difference between your and Kescha's age is {ageDifference - Keschasage}");
// > >= < <= == !=
System.Console.WriteLine($"You are older than KESCHA: {ageDifference > Keschasage}");
System.Console.WriteLine($"You are older or equal to KESCHA: {ageDifference >= Keschasage}");
System.Console.WriteLine($"You are younger than KESCHA: {ageDifference < Keschasage}");
System.Console.WriteLine($"You are younger or equal to KESCHA: {ageDifference <= Keschasage}");
System.Console.WriteLine($"You are equal to KESCHA: {ageDifference == Keschasage}");
System.Console.WriteLine($"You are not equal to KESCHA: {ageDifference != Keschasage}");