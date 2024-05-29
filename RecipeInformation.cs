using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class RecipeInformation
    {
        // The List of the Recipe Class
        public List<RecipeDescription> RecipeList { get; set; }

        // The List of the Ingredients Class
        public List<IngredientsDescription> IngredientsList { get; set; }

        // Variable for rriginal values of the Recipe Information
        private RecipeInformation OriginalRecipeInformation;

        // Creating a constructor for the RecipeInformation Class
        public RecipeInformation()
        {
            RecipeList = new List<RecipeDescription>();
            IngredientsList = new List<IngredientsDescription>();
            SaveOriginalRecipeInformation();
        }

        // A method that saves the Original Recipe Information
        public void SaveOriginalRecipeInformation()
        {
            OriginalRecipeInformation = new RecipeInformation
            {
                RecipeList = new List<RecipeDescription>(this.RecipeList.Select(i => new RecipeDescription
                {
                    RecipeName = i.RecipeName,
                    RecipeDetails = i.RecipeDetails
                })),
                IngredientsList = new List<IngredientsDescription>(this.IngredientsList.Select(i => new IngredientsDescription
                {
                    IngredientsName = i.IngredientsName,
                    IngredientsQuantity = i.IngredientsQuantity,
                    IngredientsUnitOfMeasurement = i.IngredientsUnitOfMeasurement,
                    IngredientsCalories = i.IngredientsCalories,
                    IngredientsFoodGroup = i.IngredientsFoodGroup,
                    IngredientsStepsDescription = i.IngredientsStepsDescription
                }))
            };
        }

        // A method that resets the Original Recipe Information
        public void ResetOriginalRecipeInformation()
        {
            if (OriginalRecipeInformation != null)
            {
                RecipeList = new List<RecipeDescription>(OriginalRecipeInformation.RecipeList.Select(i => new RecipeDescription
                {
                    RecipeName = i.RecipeName,
                    RecipeDetails = i.RecipeDetails
                }));
                IngredientsList = new List<IngredientsDescription>(OriginalRecipeInformation.IngredientsList.Select(i => new IngredientsDescription
                {
                    IngredientsName = i.IngredientsName,
                    IngredientsQuantity = i.IngredientsQuantity,
                    IngredientsUnitOfMeasurement = i.IngredientsUnitOfMeasurement,
                    IngredientsCalories = i.IngredientsCalories,
                    IngredientsFoodGroup = i.IngredientsFoodGroup,
                    IngredientsStepsDescription = i.IngredientsStepsDescription
                }));
            }
        }

        // A method that checks and converts ingredient quantities
        public bool CheckIngredientsQuantity()
        {
            bool result = false;

            foreach (var ingredient in IngredientsList)
            {
                if (ingredient.IngredientsQuantity == 8 && ingredient.IngredientsUnitOfMeasurement.ToLower() == "teaspoons")
                {
                    // Conversion found, update the values
                    ingredient.IngredientsQuantity = 1;
                    ingredient.IngredientsUnitOfMeasurement = "cup";

                    // Log the conversion
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The quantity of the ingredient has been changed to 1 cup.");
                    Console.ResetColor();

                    result = true;
                }
            }
            return result;
        }

        // A method that allows the user to scale the recipe
        public void ScaleRecipe()
        {
            double scalingFactor;

            while (true)
            {
                Console.WriteLine("Please enter a scaling factor by choosing one of these options (0.5, 2, 3):");
                if (double.TryParse(Console.ReadLine(), out scalingFactor) && scalingFactor > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid scaling factor. Please enter a positive number.");
                }
            }

            foreach (var ingredient in IngredientsList)
            {
                ingredient.IngredientsQuantity *= scalingFactor;
            }

            Console.WriteLine($"The recipe has been scaled by a factor of {scalingFactor}.");
        }
    }

    // A Recipe Class that contains the Recipe Information
    class RecipeDescription
    {
        // The variables for the Recipe Class
        public string RecipeName { get; set; }
        public string RecipeDetails { get; set; }
    }

    // An Ingredients Class that contains the Ingredients Information
    class IngredientsDescription
    {
        // The variables for the Ingredients Class
        public string IngredientsName { get; set; }
        public double IngredientsQuantity { get; set; }
        public string IngredientsUnitOfMeasurement { get; set; }
        public double IngredientsCalories { get; set; }
        public string IngredientsFoodGroup { get; set; }
        public string IngredientsStepsDescription { get; set; }
    }

}
//**********************************************!!End of File!!*******************************************************//