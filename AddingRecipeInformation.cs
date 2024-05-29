using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class AddingRecipeInformation
    {
        // Creating an instance of the RecipeInformation class
        RecipeInformation recipeInfo = new RecipeInformation();
        private double[] originalQuantities;

        // Defining a List that stores all the Recipe Information thats entered by the user
        public List<RecipeInformation> recipeInformationList = new List<RecipeInformation>();
//********************************************************************************************************************//
        // A method that allows the user to enter the name of the recipe
        public void AddingRecipeNames()
        {
            // Initializing the recipeNamesList array
            recipeInfo.recipeNamesList = new List<string>();

            // Displaying a welcoming message for the user
            Console.WriteLine("Hey there, Welcome To Sanele's Recipe App!");

            // Asking the user to enter the name of the recipe
            Console.WriteLine("Please enter the name of the Recipe:");
            do
            {
                recipeInfo.NameOfRecipe = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(recipeInfo.NameOfRecipe))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Recipe name cannot be empty. Please re-enter the correct name of the Recipe:");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(recipeInfo.NameOfRecipe));
            recipeInfo.recipeNamesList.Add(recipeInfo.NameOfRecipe);
        }
//********************************************************************************************************************//
        // A method that allows the user to enter the details for a single recipe
        public void AddingRecipeDetails()
        {
            // Initializing the recipeDetailsList array
            recipeInfo.recipeDetailsList = new List<string>();

            // Asking the user to enter the details for a single recipe
            Console.WriteLine("Please enter in the details for this Recipe: ");
            do
            {
                recipeInfo.RecipeDetails = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(recipeInfo.RecipeDetails))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Recipe details cannot be empty. Please re-enter the correct details for a single Recipe:");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(recipeInfo.RecipeDetails));
            recipeInfo.recipeDetailsList.Add(recipeInfo.RecipeDetails);
        }
//********************************************************************************************************************//
        // A method that allows the user to enter in the ingredients names for the recipe
        public void AddingIngredientNames()
        {
            // Initializing the ingredientsNameList array
            recipeInfo.ingredientsNameList = new List<string>();

            // Asking the user to enter in the name of the ingredients
            Console.WriteLine("Please enter the name of the ingredients for the recipe:");
            do
            {
                recipeInfo.ingredientsName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(recipeInfo.ingredientsName))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ingredient name cannot be empty. Please re-enter the correct name of the ingredient:");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(recipeInfo.ingredientsName));
            recipeInfo.ingredientsNameList.Add(recipeInfo.ingredientsName);
        }
//********************************************************************************************************************//
        // A method that allows the user to enter in the quantity for the ingredients
        public void AddingIngredientQuantity()
        {
            // Initializing the ingredientsQuantityList array
            recipeInfo.ingredientsQuantityList = new List<double>();

            // Asking the user to enter in the quantity for the ingredients
            Console.WriteLine("Please enter the quantity for the ingredients:");
            string stringIngredientQuantity;
            do
            {
                stringIngredientQuantity = Console.ReadLine();
                if (!double.TryParse(stringIngredientQuantity, out recipeInfo.ingredientsQuantity))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please enter in the correct value for the quantity:");
                    Console.ResetColor();
                }
            } while (!double.TryParse(stringIngredientQuantity, out recipeInfo.ingredientsQuantity));
            recipeInfo.ingredientsQuantityList.Add(recipeInfo.ingredientsQuantity);
        }
//********************************************************************************************************************//
        // A method that allows the user to enter in the unit of measurement for the ingredients
        public void AddingIngredientUnitOfMeasurement()
        {
            // Initializing the ingredientsUnitOfMeasurementList array
            recipeInfo.ingredientsUnitOfMeasurementList = new List<string>();

            // Asking the user to enter in the unit of measurement for the ingredients
            Console.WriteLine("Please enter the unit of measurement for the ingredients:");
            do
            {
                recipeInfo.ingredientsUnitOfMeasurement = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(recipeInfo.ingredientsUnitOfMeasurement))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Unit of measurement cannot be empty. Please re-enter the correct unit of measurement:");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(recipeInfo.ingredientsUnitOfMeasurement));
            recipeInfo.ingredientsUnitOfMeasurementList.Add(recipeInfo.ingredientsUnitOfMeasurement);
        }
//********************************************************************************************************************//
        // A method that checks if the ingredients quantity is 8
        public bool CheckIngredientsQuantity()
        {
            bool result = false;

            // Checking if the ingredients quantity is 8, if so, convert it to 1 cup
            for (int i = 0; i < recipeInfo.ingredientsQuantityList.Count; i++)
            {
                if (recipeInfo.ingredientsQuantityList[i] == 8 && recipeInfo.ingredientsUnitOfMeasurementList[i] == "teaspoons")
                {
                    // Conversion found, update the values
                    recipeInfo.ingredientsQuantityList[i] = 1;
                    recipeInfo.ingredientsUnitOfMeasurementList[i] = "cup";

                    // Log the conversion
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The quantity of the ingredient has been changed to 1 cup.");
                    Console.ResetColor();

                    result = true;
                }
            }
            return result;
        }
//********************************************************************************************************************//
        // A method that allows the user to enter in the steps for the recipe
        public void AddingStepsDescription()
        {
            // Initializing the stepsDescriptionArrayList array
            recipeInfo.stepsDescriptionArrayList = new List<string>();

            // Asking the user to enter in the steps for the recipe
            Console.WriteLine("Please enter the steps description for the Recipe:");
            do
            {
                recipeInfo.ingredientsStepsDescription = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(recipeInfo.ingredientsStepsDescription))
                {
                    // Handling the case where the user enters an empty string
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Step description cannot be empty, please enter the number of Steps Description:");
                }
            } while (string.IsNullOrWhiteSpace(recipeInfo.ingredientsStepsDescription));
            recipeInfo.stepsDescriptionArrayList.Add(recipeInfo.ingredientsStepsDescription);
        }
//********************************************************************************************************************//
        // A method that displays the full recipe
        public void displayFullRecipe()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The Full Recipe");
            Console.WriteLine("************************");
            Console.WriteLine("");

            // Displaying the ingrdients
            Console.WriteLine("The Ingredients:");
            Console.WriteLine("************************");
            for (int i = 0; i < recipeInfo.ingredientsName.Count; i++)
            {
                Console.WriteLine($"{recipeInfo.ingredientsName[i]} {recipeInfo.ingredientsQuantity[i]}{recipeInfo.ingredientsUnitOfMeasurement[i]}");
            }
            // Displaying the steps
            Console.WriteLine("");
            Console.WriteLine("The Steps:");
            Console.WriteLine("************************");
            for (int i = 0; i < recipeInfo.stepsDescriptionArray.Count; i++)
            {
                Console.WriteLine($"Step {i + 1}: {recipeInfo.stepsDescriptionArray[i]}");
            }
            Console.WriteLine("");
            Console.ResetColor();
        }

        // A method that scales the recipe accordingly
        public void ScaleRecipe()
        {
            double scalingFactor;

            // Prompt the user to enter the scaling factor and validate the input
            while (true)
            {
                Console.WriteLine("Please enter a scaling factor by choosing one of these options (0,5; 2; 3):");

                if (double.TryParse(Console.ReadLine(), out scalingFactor) && scalingFactor > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid scaling factor. Please enter a positive number.");
                }
            }

            // Scale the quantities of ingredients
            for (int i = 0; i < recipeInfo.NumberOfIngredients; i++)
            {
                recipeInfo.ingredientsQuantity[i] *= scalingFactor;
            }

            // Inform the user that the recipe has been scaled
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The recipe has been scaled by a factor of {scalingFactor}.");
            Console.ResetColor();
        }

        // A method that resets the recipe to its original value
        public void resetRecipeToOriginal()
        {
            // Initializing the originalQuantities array 
            originalQuantities = new double[recipeInfo.ingredientsQuantity.Count];
            
            if (originalQuantities.Length != recipeInfo.ingredientsQuantity.Count)
            {
                Console.WriteLine("Original quantities are not stored.");
                return;
            }
            // Copying all the contents with in the ingredientsQuantity array into the originalQuantities array
            for (int i = 0; i < recipeInfo.ingredientsQuantity.Count; i++)
            {
                recipeInfo.ingredientsQuantity[i] = originalQuantities[i];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The recipe has been reset to its original value.");
                Console.ResetColor();
            }
        }

        public void clearRecipeData()
        {
            Console.WriteLine("Are you sure you want to clear all data? Choose one of the options below.\n" +
                "1. Yes\n" +
                "2. No");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                // Clears the data by taking the user back to the start and input a new recipe
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter in a new recipe.");
                Console.ResetColor();

                singleRecipeData();
                ingredientsData();
                recipeSteps();
                displayFullRecipe();
            } else if(answer == "2")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        // A method that displays the menu for the user to choose from
        public void displayMenu()
        {
            while (true)
            {
                // Displaying options for the user to choose from and manipulate the recipe accordingly
                Console.WriteLine("If you wish to scale the recipe, choose one of the options below:");
                Console.WriteLine("*********************************************************************");
                Console.WriteLine("1. Scale your Recipe");
                Console.WriteLine("2. Set to Original Recipe");
                Console.WriteLine("3. Clear Recipe and Add a new one");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ScaleRecipe();
                        break;
                    case "2":
                        resetRecipeToOriginal();
                        break;
                    case "3":
                        clearRecipeData();
                        break;
                    case "4":
                        Environment.Exit(0);
                        return; 
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }


    }
}
//**********************************************!!End of File!!*******************************************************//