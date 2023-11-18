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