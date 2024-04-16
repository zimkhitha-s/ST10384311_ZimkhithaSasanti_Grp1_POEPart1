/*
Name: Zimkhitha Sasanti
Student Number: ST10384311
Group: 1

References: 
https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/csharp-foreach#:~:text=The%20foreach%20loop%20in%20C%23,readable%20alternative%20to%20for%20loop.
https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/
https://www.w3schools.com/cs/index.php
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
            recipe.displayMenu();

            Console.ReadKey();
        }
    }


}
//**********************************************!!End of File!!*******************************************************//