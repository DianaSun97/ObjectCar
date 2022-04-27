namespace TestD_3
{
    public class Transportation
    {
        public string vendor;
        public string model;
        public string fuel;
        public int power;
        public int speed;

        public Transportation(string parVendor, string parModel, string parFuel, int parPower, int parSpeed)
        {
            vendor = parVendor;
            model = parModel;
            fuel = parFuel;
            power = parPower;
            speed = parSpeed;
        }
    }
}