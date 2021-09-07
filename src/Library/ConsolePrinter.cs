using System;
/// <summary>
/// Esta clase tiene la responsabilidad de imprimir las recetas.
/// Tiene como colaborador a la clase Recipe.
/// </summary>
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
           Console.WriteLine(recipe.GetRecipeText());
        }
    }
}