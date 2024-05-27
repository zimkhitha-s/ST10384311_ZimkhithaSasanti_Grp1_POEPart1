using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanelesRecipeApplication
{
    internal class FullRecipe
    {
        RecipeInformation recipeInfo = new RecipeInformation();
        private double[] originalQuantities;
//********************************************************************************************************************//
        // A method that allows the user to enter the details for a single recipe
        public void singleRecipeData()
        {
            // Displaying a welcoming message for the user
            Console.WriteLine("Hey there, Welcome To Sanele's Recipe App!");

            // Asking the user to enter the details for a single recipe
            Console.WriteLine("Please enter in the details for a single recipe: ");
            do
            {
                recipeInfo.RecipeDetails = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(recipeInfo.RecipeDetails))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Recipe details cannot be empty. Please re-enter the correct details for a single recipe:");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(recipeInfo.RecipeDetails));


            // Asking the user to enter the number of ingredients
            Console.WriteLine("How many ingredients do you want to enter?");
            string input;
            int numberOfIngredients;

            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out numberOfIngredients))
                {
                    if (numberOfIngredients <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("The number of ingredients must be greater than 0. Please enter a valid number:");
                        Console.ResetColor();
                    }
                    else
                    {
                        recipeInfo.NumberOfIngredients = numberOfIngredients;
                    }
                }
                else
                {
                    // Handling a possible error and displaying a message and allowing the user to re-enter the value
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("This is an invalid input, please enter a valid number:");
                    Console.ResetColor();
                }
            } while (numberOfIngredients <= 0);
        }
//********************************************************************************************************************//
            // A method that asks a user to enter in data to populate the different arrays
            public void ingredientsData()
        {
            // Initializing the arrays
            recipeInfo.ingredientsName = new List<string>(recipeInfo.NumberOfIngredients);
            recipeInfo.ingredientsQuantity = new List<double>(recipeInfo.NumberOfIngredients);
            recipeInfo.ingredientsUnitOfMeasurement = new List<string>(recipeInfo.NumberOfIngredients);
            // For loop to populate array
            for (int i = 0; i < recipeInfo.NumberOfIngredients; i++)
            {
                // Asking the user to enter in the ingredient name
                Console.WriteLine($"Please enter the name of ingredient {i + 1}:");
                string ingredientName;
                do
                {
                    // handling the any possible error
                    ingredientName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingredientName))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ingredient name cannot be empty, please enter an ingredient name:");
                        Console.ResetColor();
                    }
                } while (string.IsNullOrWhiteSpace(ingredientName));
                recipeInfo.ingredientsName[i] = ingredientName;

                // Asking the user to enter in the ingredient quantity
                Console.WriteLine($"Please enter in the quantity of ingredient {i + 1}:");
                string stringIngredientQuantity;
                double ingredientQuantity;
                do
                {
                    // Handling the possible errors
                    stringIngredientQuantity = Console.ReadLine();
                    if (!double.TryParse(stringIngredientQuantity, out ingredientQuantity))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter in the correct value:");
                        Console.ResetColor();
                    }
                } while (!double.TryParse(stringIngredientQuantity, out ingredientQuantity));
                recipeInfo.ingredientsQuantity[i] = ingredientQuantity;

                // Asking the user to enter in the unit of measurement 
                Console.WriteLine($"Please enter in the unit of measurement for ingredient {i + 1}:");
                string ingredientUnitOfMeasurement;
                do
                {
                    ingredientUnitOfMeasurement = Console.ReadLine();

                    // Handling any possible errors
                    if (string.IsNullOrWhiteSpace(ingredientUnitOfMeasurement))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Unit of measurement cannot be empty. Please enter a unit of measurement:");
                        Console.ResetColor();
                    }
                } while (string.IsNullOrWhiteSpace(ingredientUnitOfMeasurement));
                recipeInfo.ingredientsUnitOfMeasurement[i] = ingredientUnitOfMeasurement;
            }
        }

        // A method that asks the user to input the description for each step
        public void recipeSteps()
        {

            // Asking the user to provide the number of steps description
            Console.WriteLine("Please enter the number of Steps Description for your recipe:");
            string input;
            int intStepsDescription;
            bool validInput = false;

            do
            {
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    // Handling the case where the user enters an empty string
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Step description cannot be empty, please enter the number of Steps Description:");
                    Console.ResetColor();
                }
                else if (!int.TryParse(input, out intStepsDescription))
                {
                    // Handling the case where the user enters a non-integer value
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please enter a valid number for the steps description:");
                    Console.ResetColor();
                }
                else
                {
                    // Input is valid
                    validInput = true;
                }
            } while (!validInput);
            intStepsDescription = int.Parse(input);

            int.Parse(recipeInfo.stepsDescription = intStepsDescription.ToString());
            // Initializing the stepsDescription Array
            recipeInfo.stepsDescriptionArray = new List<string>(intStepsDescription);
            for (int i = 0; i < recipeInfo.stepsDescriptionArray.Count; i++)
            {
                Console.WriteLine($"Step {i + 1}: ");
                recipeInfo.stepsDescription = Console.ReadLine();
                recipeInfo.stepsDescriptionArray[i] = recipeInfo.stepsDescription;
            }
        }

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