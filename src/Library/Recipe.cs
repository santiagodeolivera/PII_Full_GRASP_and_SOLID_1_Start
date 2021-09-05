//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        // System.Collections.Generic.List is more preferable, according to the official web page of Microsoft
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0#performance-considerations
        private List<Step> steps = new List<Step>();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // We decided that it's better to return the string to be printed by the message sender,
        // so it can be used however is necessary according to the context.
        // Also, the class Step should have the responsibility of making a representative text of itself.

        /// <summary>
        /// Returns a representative string of the recipe.
        /// </summary>
        /// <param name="verbose">Determines whether the cost of equipment usage and products is shown. Default is false.</param>
        /// <returns>A representative string of the recipe.</returns>
        public string PrintRecipe(bool verbose = false)
        {
            StringBuilder stringBuilder = new StringBuilder($"Receta de {this.FinalProduct.Description}:\n\n");
            foreach (Step step in this.steps)
            {
                stringBuilder.Append(step.ToText(verbose));
                stringBuilder.Append("\n");
            }
            stringBuilder.Append($"\nCosto total: ${this.TotalCost()}");
            return stringBuilder.ToString();
        }

        // Since the class `Recipe` is an expert of all the important data associated to itself,
        // it should calculate its total cost

        /// <summary>
        /// Returns the total cost of the recipe.
        /// </summary>
        /// <returns>The total cost of the recipe.</returns>
        public double TotalCost() => this.steps.Select(step => step.TotalCost).Sum();
    }
}