namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine()?.ToLower();

            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Math is cool because it's logic-based!");
                    break;
                case "science":
                    Console.WriteLine("Science is cool because of Bill Nye The Science Guy!");
                    break;
                case "history":
                    Console.WriteLine("History is very important assuming it's not rewritten and we can learn from it.");
                    break;
                case "writing":
                    Console.WriteLine("Writing is rad!");
                    break;
                case "lunch":
                    Console.WriteLine("One of my favorite subjects!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
            
        }
        
    }
}