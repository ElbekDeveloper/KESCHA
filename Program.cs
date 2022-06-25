System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter you age: ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted! {age}");
int keschasAge = 3;
int ageDifference = age - keschasAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");