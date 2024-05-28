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
        public string nameOfRecipe;
        public string ingredientsName;
        public double ingredientQuantity;
        public string ingredientUnitOfMeasurement;
        public string stepsDescription;
        // The List containing the Recipe Details
        public List<string> recipeDetailsList;
        // The List containing the Recipe Names
        public List<string> recipeNamesList;
        // The List containing the names of the recipe ingredients
        public List<string> ingredientsNameList;
        // The List containing the quantity for the recipe ingredients
        public List<double> ingredientsQuantityList;
        // The List containing the unit of measurement for the recipe ingredients
        public List<string> ingredientsUnitOfMeasurementList;
        // The List containing the number of steps for the recipe
        public List<string> stepsDescriptionArrayList;
//********************************************************************************************************************//
        // The Getters and Setters for each variable
        public string NameOfRecipe
        {
            set { nameOfRecipe = value; }
            get { return nameOfRecipe; }
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
//********************************************************************************************************************//
        // Creating a default RecipeInformation Constructor 
        public RecipeInformation()
        {
        }
    }
}
//**********************************************!!End of File!!*******************************************************//