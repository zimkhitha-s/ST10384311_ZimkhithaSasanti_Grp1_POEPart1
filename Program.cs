/*
Name: Zimkhitha Sasanti
Student Number: ST10384311
Group: 2

References: https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/csharp-foreach#:~:text=The%20foreach%20loop%20in%20C%23,readable%20alternative%20to%20for%20loop.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the FullRecipe Class
            FullRecipe recipe = new FullRecipe();

            // Calling all the methods from FullRecipe Class accordingly
            recipe.singleRecipeData();
            recipe.ingredientsData();
            recipe.recipeSteps();
            recipe.displayFullRecipe();

            // Displaying options for the user to choose from and manipulate the recipe accordingly
            Console.Write("If you wish to scale the recipe, choose one of the options below:/n " +
                "***********************************************************************************" +
                "1. Scale by Half (0.5)/n " +
                "2. Scale by Double (2) " +
                "3. Scale by Triple (3)/n " +
                "4. Set to Original Recipe/n " +
                "5. Clear Recipe and Add a new one/n" +
                "6. Exit");
            string choice = Console.ReadLine();

            // Whatever choice was chosen, the action of what to happens within this switch statement
            switch(choice)
            {
                case "1":
                    recipe.scaleRecipeByHalf();
                    break;
                case "2":
                    recipe.scaleRecipeByDouble();
                    break;
                case "3":
                    recipe.scaleRecipeByTriple();
                    break;
                case "4":
                    recipe.resetRecipeToOriginal();
                    break;
                case "5":
                    recipe.clearRecipeData();
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    return; // Exit the program or method
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
//**********************************************!!End of File!!*******************************************************//