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
        public string stepsDescription;
        // The ingredientsName Array containing the names of the recipe ingredients
        public string[] ingredientsName;
        // The ingredientsQuantity Array containing the quantity for the recipe ingredients
        public int[] ingredientsQuantity;
        // The ingredientsUnitOfMeasurement Array containing the unit of measurement for the recipe ingredients
        public string[] ingredientsUnitOfMeasurement;
        // The numberOfSteps Array containing the number of steps for the recipe
        public int[] numberOfStepsDescription;

        // The Getters and Setters for each variable
        public int NumberOfIngredients
        {
            set { numberOfIngredients = value; }
            get { return numberOfIngredients; }
        }

        public string RecipeDetails
        {
            set { recipeDetails = value; }
            get { return recipeDetails; }
        }

        public string StepsDescription
        {
            set { stepsDescription = value; }
            get { return stepsDescription; }
        }

        // Creating a default RecipeInformation Constructor 
        public RecipeInformation()
        {
        }
    }
}
//**********************************************!!End of File!!*******************************************************//