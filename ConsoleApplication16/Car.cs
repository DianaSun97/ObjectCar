using System;

namespace TestD_3
{
    public class Car:Transportation
    {
        public string type;

        public Car(string parVendor, string parModel, string parFuel, int parPower, int parSpeed, string parType) :
            base(parVendor, parModel, parFuel, parPower, parSpeed)
        {
            type = parType;
        }

        public override string ToString()
        {
            return vendor + " " + model + "\nFuel - " + fuel + "\nPower - " + power + "\nSpeed - " + speed +
                   "\nType - " + type;
        }
        
        //Найти максимальную мощность машины
        
        public static Car getMaxPowerCar(Car[]arr)
        {
            Car maxPowerCar = null;
            int maxPower = 0;
            foreach (Car value in arr)
            {
                maxPower = Math.Max(maxPower, value.power);
                if (maxPower == value.power)
                {
                    maxPowerCar = value;
                }
            }

            return maxPowerCar;
        }
        
        //реализовать возврат массива объектов класса CAR с одинаково0-максимальной мощностью
        public static Car[] getMaxPowerCars(Car[] arr)
        {

            return null;
        }
    }
}
