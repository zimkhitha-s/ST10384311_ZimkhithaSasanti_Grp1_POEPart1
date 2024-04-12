using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class RecipeInformation
    {
        // The variables for the RecipeInformation Class
        public string recipeDetails;
        public int numberOfIngredients;
        public string description;
        // The ingredientsQuantity Array containing the quantity for the recipe ingredients
        public int[] ingredientsQuantity;
        // The ingredientsUnitOfMeasurement Array containing the unit of measurement for the recipe ingredients
        public string[] ingredientsUnitOfMeasurement;
        // The ingredientsName Array containing the names of the recipe ingredients
        public string[] ingredientsName;
        // The numberOfSteps Array containing the number of steps for the recipe
        public int[] numberOfSteps;

        // The Getters and Setters for each variable
        public int NumberOfIngredients
        {
            get { return numberOfIngredients; }
            set { numberOfIngredients = value; }
        }

        public string RecipeDetails
        {
            get { return recipeDetails; }
            set { recipeDetails = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // Creating a default RecipeInformation Constructor 
        public RecipeInformation()
        {
        }
    }
}
