using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercises
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }
        public override double FuelConsumption
            => base.FuelConsumption + 1.6;

        public override void Refueled(double amountFuel)
        {
            amountFuel *= 0.95;
            base.Refueled(amountFuel);
        }
    }
}
