using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class HandleRecipeInformation
    {
        // Creating an instance of the AddingRecipeInformation Class
        AddingRecipeInformation recipe = new AddingRecipeInformation();
        // Creating an instance of the RecipeInformation Class
        RecipeInformation recipeInformation = new RecipeInformation();

        // A method that arranges the Recipe Names in Alphabetical Order
        public void ArrangeRecipeNames()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The Recipe Names in Alphabetical Order");
            Console.WriteLine("***************************************");
            Console.WriteLine("");

            // Sorting the Recipe Names in Alphabetical Order
            recipeInformation.recipeNamesList.Sort();

            // Displaying the Recipe Names in Alphabetical Order
            foreach (string recipeName in recipeInformation.recipeNamesList)
            {
                Console.WriteLine(recipeName);
            }
            Console.ResetColor();
        }

        // A method that displays the Full Recipe
        public void DisplayFullRecipe()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The Full Recipe");
            Console.WriteLine("************************");
            Console.WriteLine("");

            // Displaying the Full Recipe using a For Loop
            for(int i = 0; i < recipeInformation.recipeNamesList.Count; i++)
            {
                // Displaying the name of the Recipe
                Console.WriteLine($"Name of Recipe {i + 1}: ");
                Console.Write(recipeInformation.recipeNamesList[i]);
                Console.WriteLine("");
                // Displaying the Ingredients of the Recipe
                Console.WriteLine("Ingredients: ");

            }

            // Displaying the Recipe Details
            Console.WriteLine("Details of the Recipe:");
        }
    }
}
