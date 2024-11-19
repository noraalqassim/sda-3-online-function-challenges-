using System;

namespace FunctionChallenges
{
    class Program
    {
        // Challenge 1: String and Number Processor
        static void StringNumberProcessor(params object[] inputs)
        {
            string concatenatedString = string.Join(" ", inputs.OfType<string>());
            int sumOfNumbers = inputs.OfType<int>().Sum();

            Console.WriteLine($"{concatenatedString}; {sumOfNumbers}");
        }

        //Challenge 2: Guessing Game
        static void GuessingGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);  //from 1 to 10 
            int userGuess = 0;

            Console.WriteLine("Can you Guess the Number from 1 to 10 ??");

            while (userGuess != randomNumber)
            {
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess < randomNumber)
                {
                    Console.WriteLine(
                        "Oops!, the number is higher than " + userGuess + ", Tray Again :("
                    );
                }
                if (userGuess > randomNumber)
                {
                    Console.WriteLine(
                        "Oops!, the number is lower than " + userGuess + ", Tray Again :("
                    );
                }
            }
            Console.WriteLine("Yesss!!, Good Guess");
        } // End GuessingGame Function

        //Challenge 3: Simple Word Reversal
        static void ReverseWords(string sentence)
        {
            string[] word = sentence.Split(' ');

            for (int i = 0; i < word.Length; i++)
            {
                char[] charArray = word[i].ToCharArray();
                Array.Reverse(charArray);
                word[i] = new string(charArray);
            }
            Console.WriteLine(string.Join(" ", word));
        }

        //Challenge 4: User Profile Updater
        static void UpdateUserProfile(ref string name, ref int age, ref string email)
        {
            //New name 
            Console.Write("\nEnter your new name: ");
            string newName = Console.ReadLine();
            while (string.IsNullOrEmpty(newName))
            {
                Console.Write("Please enter new name:");
                newName = Console.ReadLine();
            }
            name = newName;
            Console.WriteLine($"Name update to: {newName}");

            //New age 
            Console.Write("Enter your new age: ");
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Please enter the correct age: ");
            }
            Console.WriteLine($"Age update to: {age}");

            //New email
            Console.Write("Enter new email: ");
            string newEmail = Console.ReadLine();
            while (string.IsNullOrEmpty(newEmail) || !newEmail.Contains("@"))
            {
                Console.Write("Please enter new email: ");
                newEmail = Console.ReadLine();
            }
            email = newEmail;
            Console.WriteLine($"Email update to: {newEmail}");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Data type & function challeneges\n");
            // Challenge 1
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World");

            // Challenge 2
            Console.WriteLine("Challenge 2: Guessing Game");
            GuessingGame();

            // Challenge 3
            Console.WriteLine("Challenge 3: Simple Word Reversal");
            ReverseWords("This is the original sentence!"); //output = sihT si eht lanigiro !ecnetnes

            // Challenge 3
            Console.WriteLine("Challenge 4: User Profile Updater");
            string name = "John Doe";
            int age = 28;
            string email = "john@gmail.com";

            Console.WriteLine("Initial Profile:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Email: {email}");

            UpdateUserProfile(ref name, ref age, ref email);

            Console.WriteLine("\nUpdated Profile:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Email: {email}");


        }
    }
}