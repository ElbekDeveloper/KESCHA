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
System.Console.WriteLine($"You are older than or equal to KESCHA: {age >= keschasAge}");
System.Console.WriteLine($"You are older than to KESCHA: {age > keschasAge}");
System.Console.WriteLine($"You are younger than or equal to KESCHA: {age < keschasAge}");
System.Console.WriteLine($"You are younger than KESCHA: {age <= keschasAge}");
System.Console.WriteLine($"Your age is equal to KESCHA's age: {age == keschasAge}");
System.Console.WriteLine($"Your age is not equal to KESCHA's age: {age != keschasAge}");