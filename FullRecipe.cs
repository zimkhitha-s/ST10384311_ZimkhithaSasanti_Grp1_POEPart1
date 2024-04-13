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

        // Creating a List for the different Array te be able to manipulate them accordingly 
        private List<double> originalQuantities;
        private List<string> ingredientsNameList;
        private List<double> ingredientsQuantityList;
        private List<string> ingredientsUnitOfMeasurementList;
        private List<string> stepsDescriptionList;
//********************************************************************************************************************//
        // A Constructor Method that has the list of disfferent Lists 
        public FullRecipe()
        {
            originalQuantities = new List<double>();
            ingredientsNameList = new List<string>();
            ingredientsQuantityList = new List<double>();
            ingredientsUnitOfMeasurementList = new List<string>();
            stepsDescriptionList = new List<string>();
        }
//********************************************************************************************************************//
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
//********************************************************************************************************************//
        // A Method that populates the ingredient information for the recipe
        public void ingredientsData()
        {
            for(int i = 0; i < recipeInfo.NumberOfIngredients; i++)
            {
                // Inistalizing the Arrays
                recipeInfo.ingredientsName = new string[recipeInfo.NumberOfIngredients];
                recipeInfo.ingredientsQuantity = new double[recipeInfo.NumberOfIngredients];
                recipeInfo.ingredientsUnitOfMeasurement = new string[recipeInfo.NumberOfIngredients];

                /* Asking the user for the name of the ingredients, quantity and unit of measurements
                and adding to the recpective arrays */
                Console.WriteLine("Please enter the name of your ingredient:");
                string ingredientName = Console.ReadLine();
                recipeInfo.ingredientsName[i] = ingredientName;
                Console.WriteLine("Please enter in the quantity of your ingredient:");
                string stringIngredientQuantity = Console.ReadLine();
                recipeInfo.ingredientsQuantity[i] = Convert.ToDouble(stringIngredientQuantity);
                Console.WriteLine("Please enter in the unit of measurement for this ingredient:");
                string ingredientUnitOfMeasurement = Console.ReadLine();
                recipeInfo.ingredientsUnitOfMeasurement[i] = ingredientUnitOfMeasurement;
            }
            // Saving the Arrays data into the Lists
            ingredientsNameList.AddRange(recipeInfo.ingredientsName);
            ingredientsQuantityList.AddRange(recipeInfo.ingredientsQuantity);
            ingredientsUnitOfMeasurementList.AddRange(recipeInfo.ingredientsUnitOfMeasurement);
        }
//********************************************************************************************************************//
        // A Method that defines the steps for the recipe
        public void recipeSteps()
        {
            Console.WriteLine("Please enter in the number of Steps Description for your recipe:");
            recipeInfo.StepsDescription = Console.ReadLine();
            // Initializing the stepsDescriptionList Array and populating it
            recipeInfo.stepsDescriptionArray = new string[Int32.Parse(recipeInfo.StepsDescription)];
            for(int i = 0; i < recipeInfo.stepsDescriptionArray.Length; i++) 
            {
                Console.WriteLine($"Step {i}: ");
                recipeInfo.stepsDescriptionArray[i] = Console.ReadLine();

            }
        }
//********************************************************************************************************************//
        // A Method that displays the full recipe ingredients and steps for the user
        public void displayFullRecipe()
        {
            Console.WriteLine("The Full Recipe");
            Console.WriteLine("************************");
            // This first nested for loop will display the ingredients name, quantity and unit of measurement
            Console.WriteLine("The Ingrdients:");
            for(int i = 0; i < recipeInfo.NumberOfIngredients; i++)
            {
                for(int j = 0; j < recipeInfo.ingredientsName.Length; j++)
                {
                    for(int k = 0; k < recipeInfo.ingredientsQuantity.Length; k++)
                    {
                        for(int l = 0; l < recipeInfo.ingredientsUnitOfMeasurement.Length; l++)
                        {
                            Console.WriteLine($"Ingredient Name {j}: ");
                            Console.Write(recipeInfo.ingredientsName[j] + " ");
                            Console.Write(recipeInfo.ingredientsQuantity[k]);
                            Console.Write(recipeInfo.ingredientsUnitOfMeasurement[l]);
                        }
                    }
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("The Steps:");
            Console.WriteLine("************************");
            // This for loop handles the displaying of the stepsDescriptionList array
            for (int i = 0; i <= recipeInfo.stepsDescriptionArray.Length; i++)
            {
                Console.WriteLine($"Step {i}: ");
                Console.Write(recipeInfo.stepsDescriptionArray[i]);
            }
        }
//********************************************************************************************************************//
        /* This Method handles the functionality of when a user wants to scale the ingredients 
         quantity by a half */
        public void scaleRecipeByHalf()
        {
            for (int i = 0; i < recipeInfo.ingredientsQuantity.Length; i++)
            {
                recipeInfo.ingredientsQuantity[i] = recipeInfo.ingredientsQuantity[i] * 0.5;
            }
        }
//********************************************************************************************************************//
        /* This Method handles the functionality of when a user wants to scale the ingredients 
         quantity by doubling it */
        public void scaleRecipeByDouble()
        {
            for (int i = 0; i < recipeInfo.ingredientsQuantity.Length; i++)
            {
                recipeInfo.ingredientsQuantity[i] = recipeInfo.ingredientsQuantity[i] * 2;
            }
        }
//********************************************************************************************************************//
        /* This Method handles the functionality of when a user wants to scale the ingredients 
         quantity by tripling it*/
        public void scaleRecipeByTriple()
        {
            for (int i = 0; i < recipeInfo.ingredientsQuantity.Length; i++)
            {
                recipeInfo.ingredientsQuantity[i] = recipeInfo.ingredientsQuantity[i] * 3;
            }
        }
//********************************************************************************************************************//
        // This Method to store original quantities
        public void StoreOriginalQuantities()
        {
            // Copy the current quantities to originalQuantities
            originalQuantities.Clear();
            originalQuantities.AddRange(recipeInfo.ingredientsQuantity);
        }
//********************************************************************************************************************//
        // This Method that allows the user to reset the values to the original ones
        public void resetRecipeToOriginal()
        {
            // Check if originalQuantities is populated
            if (originalQuantities.Count != ingredientsQuantityList.Count)
            {
                Console.WriteLine("Original quantities are not stored.");
                return;
            }

            // Copy original quantities back to ingredientsQuantity
            for (int i = 0; i < ingredientsQuantityList.Count; i++)
            {
                recipeInfo.ingredientsQuantity[i] = originalQuantities[i];
            }
        }
//********************************************************************************************************************//
        // This Method handles the functionality of clearing the data
        public void clearRecipeData()
        {
            // Clear all lists
            ingredientsNameList.Clear();
            ingredientsQuantityList.Clear();
            ingredientsUnitOfMeasurementList.Clear();

            // Allowing the user to add a new recipe
            singleRecipeData();
            ingredientsData();
            recipeSteps();
        }

    }
}
//**********************************************!!End of File!!*******************************************************//