//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }

        // Since the class `Product` is an expert of all the important data associated to itself,
        // it should calculate its total cost

        /// <summary>
        /// Returns the total cost required to obtain a certain quantity of the product.
        /// </summary>
        /// <param name="quantity">The quantity of the product.</param>
        /// <returns>The amount of money it costs.</returns>
        public double TotalCost(double quantity) => this.UnitCost * quantity;
    }
}