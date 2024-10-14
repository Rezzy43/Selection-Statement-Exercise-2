namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their favorite school subject here
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            // Use a switch statement to respond to the user's input here
            switch (favoriteSubject.ToLower()) // Convert to lower case for Case-Insensitivity
            {
                case "math":
                    Console.WriteLine("Math is cool because it's all about solving problems!");
                    break;
                case "science":
                    Console.WriteLine("Science helps the world work but I still don't understand it myself!");
                    break;
                case "history":
                    Console.WriteLine("History was my best class and teaches us about our past and shapes the future!");
                    break;
                case "english":
                    Console.WriteLine("English is great for expressing an idea or even show creativity!");
                    break;
                case "art":
                    Console.WriteLine("Art allows the brain to explore your creativity and imagination and it's a free grade in college!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
                    //Tried writing this scope in a different manner than the Exercise called for... 
            }
        }
    }
}