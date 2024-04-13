using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class FullRecipe
    {
        // Creating an instance for the RecipeInformation Class
        RecipeInformation recipeInfo = new RecipeInformation();

        // A method that allows the user to enter in the details of a single recipe
        public void singleRecipeData()
        {
            // Displaying a welcoming message for the application
            Console.WriteLine("Hey there, Welcome To Sanele's Recipe App!");
            // Asking the user to enter in the details for the recipe into the
            Console.WriteLine("Please enter in the details for a single recipe: ");
            recipeInfo.RecipeDetails = Console.ReadLine();
            // Asking the user to specify the number of ingredients they want to enter and save it
            Console.WriteLine("How many ingredients do you want to enter?");
            string input = Console.ReadLine();
            // Converting the input number for the number of ingredients into an int
            int numberOfIngredients;
            // Attempt to parse the input string to an integer
            if (int.TryParse(input, out numberOfIngredients))
            {
                recipeInfo.NumberOfIngredients = numberOfIngredients;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // A Method that populates the ingredient information for the recipe
        public void ingredientsData()
        {
            for(int i = 0; i < recipeInfo.NumberOfIngredients; i++)
            {
                /* Asking the user for the name of the ingredients, quantity and unit of measurements
                and adding to the recpective arrays */
                Console.WriteLine("Please enter the name of your ingredient:");
                string ingredientName = Console.ReadLine();
                recipeInfo.ingredientsName[i] = ingredientName;
                Console.WriteLine("Please enter in the quantity of your ingredient:");
                string stringIngredientQuantity = Console.ReadLine();
                recipeInfo.ingredientsQuantity[i] = Int32.Parse(stringIngredientQuantity);
                Console.WriteLine("Please enter in the unit of measurement for this ingredient:");
                string ingredientUnitOfMeasurement = Console.ReadLine();
            }
        }
    }
}
