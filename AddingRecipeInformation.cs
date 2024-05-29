using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class AddingRecipeInformation
    {
        private RecipeInformation recipeInformation;

        // Constructor for AddingRecipeInformation class
        public AddingRecipeInformation(RecipeInformation recipeInfo)
        {
            this.recipeInformation = recipeInfo;
        }

        // Method to get Recipe Information from the user
        public void GetRecipeInformation()
        {
            GetRecipeDetails();
            GetIngredientsDetails();
        }

        // A method that gets the Recipe Details from the user
        public void GetRecipeDetails()
        {
            // Getting the Recipe Name from the user
            Console.WriteLine("Please enter the Name of the Recipe: ");
            string recipeName;
            do
            {
                recipeName = Console.ReadLine();
                if (string.IsNullOrEmpty(recipeName))
                {
                    Console.WriteLine("Recipe Name cannot be empty. Please enter a valid Recipe Name: ");
                }
            } while (string.IsNullOrEmpty(recipeName));

            // Getting the Recipe Details from the user
            Console.WriteLine("Please enter the Details of the Recipe: ");
            string recipeDetails;
            do
            {
                recipeDetails = Console.ReadLine();
                if (string.IsNullOrEmpty(recipeDetails))
                {
                    Console.WriteLine("Recipe Details cannot be empty. Please enter a valid Recipe Details: ");
                }
            } while (string.IsNullOrEmpty(recipeDetails));

            // Adding RecipeDescription to the list
            recipeInformation.RecipeList.Add(new RecipeDescription
            {
                RecipeName = recipeName,
                RecipeDetails = recipeDetails
            });
        }

        // A method that gets the Ingredients Details of the Recipe from the user
        public void GetIngredientsDetails()
        {
            // Getting the Ingredients of the Recipe from the user
            bool addMoreIngredients = true;
            while (addMoreIngredients)
            {
                // Adding IngredientsDescription to the list
                recipeInformation.IngredientsList.Add(new IngredientsDescription
                {
                    IngredientsName = GetIngredientsName(),
                    IngredientsQuantity = GetIngredientsQuantity(),
                    IngredientsUnitOfMeasurement = GetIngredientsUnitOfMeasurement(),
                    IngredientsCalories = GetIngredientsCalories(),
                    IngredientsFoodGroup = GetIngredientsFoodGroup(),
                    IngredientsStepsDescription = GetIngredientsStepsDescription()
                });
                Console.WriteLine("Add another ingredient? (y/n)");
                addMoreIngredients = Console.ReadLine().ToLower() == "y";
            }

            // Save the original state after adding the recipe
            recipeInformation.SaveOriginalRecipeInformation();
        }

        // A method that gets the Ingredients Name from the user
        public string GetIngredientsName()
        {
            // Getting the Ingredients Name from the user
            Console.WriteLine("Enter the Ingredients Name: ");
            string ingredientName;
            do
            {
                ingredientName = Console.ReadLine();
                if (string.IsNullOrEmpty(ingredientName))
                {
                    Console.WriteLine("Ingredients Name cannot be empty. Please enter a valid Ingredients Name: ");
                }
            } while (string.IsNullOrEmpty(ingredientName));
            return ingredientName;
        }

        // A method that gets the Ingredients Quantity from the user
        public double GetIngredientsQuantity()
        {
            // Getting the Ingredients Quantity from the user
            Console.WriteLine("Enter the Ingredients Quantity: ");
            double ingredientQuantity;
            do
            {
                if (!double.TryParse(Console.ReadLine(), out ingredientQuantity))
                {
                    Console.WriteLine("Invalid input. Please enter a valid Ingredients Quantity: ");
                }
                else if (ingredientQuantity <= 0)
                {
                    Console.WriteLine("Ingredients Quantity cannot be less than or equal to 0. Please enter a valid Ingredients Quantity: ");
                }
                else if (ingredientQuantity.Equals(null))
                {
                    Console.WriteLine("Ingredients Quantity cannot be empty. Please enter a valid Ingredients Quantity: ");
                }
            } while (!double.TryParse(Console.ReadLine(), out ingredientQuantity) || ingredientQuantity <= 0 || ingredientQuantity.Equals(null));
            return ingredientQuantity;
        }

        // A method that gets the Ingredients Unit of Measurement from the user
        public string GetIngredientsUnitOfMeasurement()
        {
            // Getting the Ingredients Unit of Measurement from the user
            Console.WriteLine("Enter the Ingredients Unit of Measurement: ");
            string ingredientUnit;
            do
            {
                ingredientUnit = Console.ReadLine();
                if (string.IsNullOrEmpty(ingredientUnit))
                {
                    Console.WriteLine("Ingredients Unit of Measurement cannot be empty. Please enter a valid Ingredients Unit of Measurement: ");
                }
            } while (string.IsNullOrEmpty(ingredientUnit));
            return ingredientUnit;
        }

        // A method that gets the Ingredients Calories from the user
        public double GetIngredientsCalories()
        {
            // Getting the Ingredients Calories from the user
            Console.WriteLine("Please enter the Ingredients Calories: ");
            double ingredientCalories;
            do
            {

                if (!double.TryParse(Console.ReadLine(), out ingredientCalories))
                {
                    Console.WriteLine("Invalid input. Please enter a valid Ingredients Calories: ");
                }
                else if (ingredientCalories <= 0)
                {
                    Console.WriteLine("Ingredients Calories cannot be less than or equal to 0. Please enter a valid Ingredients Calories: ");
                }
                else if (ingredientCalories.Equals(null))
                {
                    Console.WriteLine("Ingredients Calories cannot be empty. Please enter a valid Ingredients Calories: ");
                }
            } while (!double.TryParse(Console.ReadLine(), out ingredientCalories) || ingredientCalories <= 0 || ingredientCalories.Equals(null));
            return ingredientCalories;
        }

        // A method that gets the Ingredients Food Group from the user
        public string GetIngredientsFoodGroup()
        {
            // Getting the Ingredients Food Group from the user
            Console.WriteLine("Please enter the Ingredients Food Group: ");
            string ingredientFoodGroup;
            do
            {
                ingredientFoodGroup = Console.ReadLine();
                if (string.IsNullOrEmpty(ingredientFoodGroup))
                {
                    Console.WriteLine("Ingredients Food Group cannot be empty. Please enter a valid Ingredients Food Group: ");
                }
            } while (string.IsNullOrEmpty(ingredientFoodGroup));
            return ingredientFoodGroup;
        }

        // A method that gets the Ingredients Steps Description from the user
        public string GetIngredientsStepsDescription()
        {
            // Getting the Ingredients Steps Description from the user
            Console.WriteLine("Enter the Ingredients Steps Description: ");
            string stepsDescription;
            do
            {
                stepsDescription = Console.ReadLine();
                if (string.IsNullOrEmpty(stepsDescription))
                {
                    Console.WriteLine("Ingredients Steps Description cannot be empty. Please enter a valid Ingredients Steps Description: ");
                }
            } while (string.IsNullOrEmpty(stepsDescription));
            return stepsDescription;
        }
    }
}
//**********************************************!!End of File!!*******************************************************//