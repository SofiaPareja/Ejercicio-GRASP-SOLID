//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;
/// <summary>
/// Esta clase tiene la responsabilidad de calcular el costo total de la receta y crear el texto ya que es el experto en esta información.
/// </summary>
namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public double CostoTotal() {
            double resultado = 0;
            foreach (Step step in this.steps) 
            {
                 resultado = resultado + step.Costo();
            }
            return resultado;
        }

        public StringBuilder GetRecipeText()
        {
            
            StringBuilder text = new StringBuilder ($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
               text.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
            text.Append($"Costo total de la receta: {this.CostoTotal()}");
            return text;
            
        }



       
        
    }
}

// Le agregamos la responsabilidad de calcular el costo total porque conoce los costos de cada paso.