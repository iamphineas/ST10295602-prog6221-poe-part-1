namespace RecipeApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Set the background color of the console to BLUE for visual appeal.
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************");
            Console.WriteLine("*   WELCOME TO MY RecipeApp  *");
            Console.WriteLine("******************************");
            // Reset the console background color to default after displaying the welcome message.
            Console.ResetColor();


            // Create an instance of the Recipe class to manage recipe-related operations.
            Recipe recipe = new Recipe();
            bool exit = false;


            // This loop keeps the program running until the user chooses to exit.
            while (!exit)
            {

                // Display options for the user to interact with the RecipeApp.
                Console.WriteLine("*********************************");
                Console.WriteLine();
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear all data");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.WriteLine("*********************************");
            }
        }
    }
}
