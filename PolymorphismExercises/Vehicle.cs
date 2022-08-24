using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercises
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }
        public virtual double FuelConsumption { get; set; }

        public bool IsEnoughFuel(double km)
        => this.FuelQuantity - (this.FuelConsumption * km) >= 0;

        public void Drive(double km)
        {
            if (this.FuelQuantity - (this.FuelConsumption * km) >= 0)
            {
                this.FuelQuantity -= this.FuelConsumption * km;
            }

        }
        public virtual void Refueled(double amountFuel)
        {
            this.FuelQuantity += amountFuel;
        }

    }
}
