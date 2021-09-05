//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        // Since the class `Step` is expert of all the important data associated to itself,
        // it should have a method to obtain a representative text.

        /// <summary>
        /// Returns a representative text of the recipe step.
        /// </summary>
        /// <param name="verbose">Determines whether the text shows the cost of equipment usage and the product.</param>
        /// <returns>A representative text of the recipe step.</returns>
        public string ToText(bool verbose = false) =>
            verbose
            ?$"{this.Quantity} de '{this.Input.Description}' (${this.Input.TotalCost(this.Quantity)}) usando '{this.Equipment.Description}' durante {this.Time} minuto(s) (${this.Equipment.TotalCost(this.Time)})."
            : $"{this.Quantity} de '{this.Input.Description}' usando '{this.Equipment.Description}' durante {this.Time} minuto(s).";

        // Since the class `Step` is an expert of all the important data associated to itself,
        // it should calculate its total cost

        /// <summary>
        /// Returns the total cost of performing this step.
        /// </summary>
        /// <value>The total cost of performing this step.</value>
        public double TotalCost {
            get => this.Input.TotalCost(this.Quantity) + this.Equipment.TotalCost(this.Time);
        }
    }
}