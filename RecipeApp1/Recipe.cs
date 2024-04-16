using System.Text.RegularExpressions;

namespace RecipeApp1
{
    internal class Recipe
    {
        // Define private fields to store ingredients and steps
        private Ingredient[] ingredients;
        private Step[] steps;

        // Constructor to initialize arrays
        public Recipe()
        {
            ingredients = new Ingredient[0];
            steps = new Step[0];
        }
        // Method to enter recipe details
        public void EnterDetails()
        {
            string name, unit;
            double quantity;

            // Prompt user to enter the number of ingredients
            int ingredientCount;
            while (true)
            {
                Console.WriteLine("Enter the number of ingredients:");
                if (!int.TryParse(Console.ReadLine(), out ingredientCount))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                else
                {
                    break;
                }
            }
            ingredients = new Ingredient[ingredientCount];

            // Loop to input ingredient details
            for (int i = 0; i < ingredientCount; i++)
            {
                // Validate ingredient name to ensure only letters are entered
                while (true)
                {
                    Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                    name = Console.ReadLine();
                    if (!Regex.IsMatch(name, @"^[a-zA-Z ]+$"))
                    {
                        Console.WriteLine("Invalid input. Please enter letters and spaces only.");
                    }
                    else
                    {
                        break;
                    }
                }

                // Prompt user to enter quantity of ingredient
                while (true)
                {
                    Console.WriteLine($"Enter the quantity of {name}:");
                    if (!double.TryParse(Console.ReadLine(), out quantity))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    else
                    {
                        break;
                    }
                }
                // Prompt user to enter unit of measurement
                Console.WriteLine($"Enter the unit of measurement for {name}:");
                unit = Console.ReadLine();
                // Store ingredient details in the array
                ingredients[i] = new Ingredient(name, quantity, unit);
            }

            // Prompt user to enter the number of steps
            int stepCount;
            while (true)
            {
                Console.WriteLine("Enter the number of steps:");
                if (!int.TryParse(Console.ReadLine(), out stepCount))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                else
                {
                    break;
                }
            }
            steps = new Step[stepCount];

            // Loop to input step details
            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string description = Console.ReadLine();
                // Store step details in the array
                steps[i] = new Step(description);
            }

            // Inform user that recipe details have been entered successfully
            Console.WriteLine("Recipe details entered successfully.");
            Console.WriteLine("*********************************");
        }
        // Method to display recipe details
        public void Display()
        {
            // Display recipe title
            Console.WriteLine("Recipe:");
            Console.WriteLine("*********************************");
            // Display ingredients
            Console.WriteLine("Ingredients:");

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            // Display steps
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine("Steps:");

            foreach (var step in steps)
            {
                Console.WriteLine(step.Description);
            }

            // Display separator
            Console.WriteLine("*********************************");
        }

        // Method to scale recipe by a factor
        public void Scale()
        {
            Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
            double factor;
            // Prompt user to enter scaling factor
            while (!double.TryParse(Console.ReadLine(), out factor) || !(factor == 0.5 || factor == 2 || factor == 3))
            {
                Console.WriteLine("Invalid input. Please enter 0.5, 2, or 3.");
            }

            // Scale each ingredient quantity
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
            // Inform user that recipe has been scaled
            Console.WriteLine($"Recipe scaled by a factor of {factor}.");
        }

        // Method to reset ingredient quantities to original values
        public void ResetQuantities()
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.ResetQuantity();
            }
            // Inform user that quantities have been reset
            Console.WriteLine("Quantities reset to original values.");
        }

        // Method to clear recipe data
        public void ClearData()
        {
            ingredients = new Ingredient[0];
            steps = new Step[0];
            // Inform user that recipe data has been cleared
            Console.WriteLine("Recipe data cleared");
        }
    }
}
/*--------------------code attribution--------------------
 * The following method was taken from StackOverFlow:
 * Author : N/A
 * link: htpps://https://www.programiz.com/csharp-programming/for-loop
 *for (initialization; condition; iterator)
{
	// body of for loop
}
 */



