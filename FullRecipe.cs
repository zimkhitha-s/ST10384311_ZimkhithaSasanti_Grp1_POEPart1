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


    }
}
