//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }

        // Since the class `Equipment` is an expert of all the important data associated to itself,
        // it should calculate its total cost

        /// <summary>
        /// Returns the total cost required for the piece of equiment to work for a period of time
        /// </summary>
        /// <param name="minutes">The amount of minutes the piece of equipment is used.</param>
        /// <returns>The amount of money the usage costs.</returns>
        public double TotalCost(int minutes) => this.HourlyCost * minutes / 60;
    }
}