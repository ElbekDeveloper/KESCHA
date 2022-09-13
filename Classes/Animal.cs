namespace KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        protected int Age { get; set; }
        internal int AgeDifference { get; set; }
        private string Password { get; set; }
        public DateTimeOffset CreatedDate { get; set; }


        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
            Password = "23;";
            CreatedDate = DateTimeOffset.Now;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            CreatedDate = DateTimeOffset.UtcNow;
        }

        public Animal(
            string name,
            int userAge,
            int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
            CreatedDate = DateTimeOffset.Now;
        }
        public abstract void Greet2(string userName);

        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference between your and {Name}'s age is {AgeDifference}");
        }

        public void CompareAges(int userAge)
        {
            if(userAge > Age)
            {
                Console.WriteLine("You are older!");
            }
            else if(userAge == Age)
            {
                Console.WriteLine("You are equal");
            }
            else
            {
                Console.WriteLine("You are younger!");
            }
        }

        public void TellAboutFriends(string userName, int userAge)
        {
            Console.WriteLine("Let me tell you about my friends.");

            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "Vasya";
            friendsName[2] = userName;
            int[] friendsAge = { 1, 2, userAge};

            for(int iteration = 0; iteration < friendsName.Length; iteration++)
            {
                Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration]} year old!");
            }
        }

        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }

        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }
       
        public virtual void Greet(string userName)
        {
            if(userName == "")
            {
                userName = "Unknown Person";
            }

            Console.WriteLine($"Hello, {userName}");
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}