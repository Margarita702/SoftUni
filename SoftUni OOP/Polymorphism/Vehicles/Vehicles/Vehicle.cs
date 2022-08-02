

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; set; }
        public virtual double FuelConsumptionPerKm { get; set; }

        public bool CanDrive(double km)
       =>this.FuelQuantity-(this.FuelConsumptionPerKm * km)>=0;



        public void Drive(double km)
        {
            if (this.FuelQuantity - (km * FuelConsumptionPerKm) >= 0)
            {
                this.FuelQuantity -= (km * FuelConsumptionPerKm);
            }
        }
        public virtual void Refuel(double amount)
        {
            this.FuelQuantity -= amount;
        }
    }
}
