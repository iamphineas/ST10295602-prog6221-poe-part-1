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

                // Get the user's choice and parse it as an integer.
                int choice = int.Parse(Console.ReadLine());

                // Perform actions based on the user's choice.
                switch (choice)
                {
                    case 1:
                        recipe.EnterDetails();
                        break;
                    case 2:
                        recipe.Display();
                        break;
                    case 3:
                        recipe.Scale();
                        break;
                    case 4:
                        recipe.ResetQuantities();
                        break;
                    case 5:
                        recipe.ClearData();
                        break;
                    case 6:

                        // Set the exit flag to true to terminate the loop and exit the program.
                        exit = true;
                        break;
                    default:
                        // Good coding practice: Provide clear error messages for invalid input.
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }

            }
        }
    }
}
//end
/*--------------------code attribution--------------------
 * The following method was taken from StackOverFlow:
 * Author : Prasanth Jaya
 * link: htpps://https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input
 * int intTemp = Convert.ToInt32(Console.ReadLine());
 * 
 * The following method was taken from StackOverFlow:
 * Author : Mark Byers
 * link: htpps://https://stackoverflow.com/questions/2743260/is-it-possible-to-write-to-the-console-in-colour-in-net
 * Console.BackgroundColor = ConsoleColor.Blue;
  */
