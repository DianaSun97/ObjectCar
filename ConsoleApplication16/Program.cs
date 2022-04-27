using System;


namespace TestD_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car[] arr = new Car[50];
            for(int i = 0; i < arr.Length; i++)
            {
                Car obj = new Car(randVendor(),randModel(),randFuel(),randPower(),randSpeed(),randType());
                // obj = new Car(parVendor:randVendor(),randModel(),randFuel(),randPower(),randSpeed(),randType());
                arr[i] = obj;
            }
        }
        
        public static string randVendor()
        {
            Random rand = new Random();
            string[] nameVendor = {"Mersedes", "Opel", "Pegeot", "BMW", "Nissan", "Honda", "Kia", "Lada"};
            int ind = rand.Next(0, nameVendor.Length);
            string name=nameVendor[ind]; ;
            return name ;
        }
        
        public  static string randFuel()
        {
            Random rand = new Random();
            string[] nameFuel = {"Petrol", "Diesel", "Electric", "Hybrit"};
            int ind = rand.Next(0, nameFuel.Length);
            string name=nameFuel[ind]; ;
            return name;
        }
        
        public static string randType()
        {
            Random rand = new Random();
            string[] nameType = {"Cabrio", "4x4", "Sedan", "Hatchback"};
            int ind = rand.Next(0, nameType.Length);
            string name=nameType[ind]; ;
            return name;
        }

        public  static int randPower()
        {
            Random rand = new Random();
            int Power = rand.Next(50, 250);
            return Power;
        }
        
        public  static int randSpeed()
        {
            Random rand = new Random();
            int Speed = rand.Next(160, 240);
            return Speed;
        }

        public  static  string randModel()
        {
            Random rand = new Random();
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string A = "";
            int Length = rand.Next(2, 9);
            for (int i = 0; i < Length; i++)
            {
                int ind = rand.Next(0, letters.Length);
                A=A+letters[ind];
            }
            return A;
        }
  
    }
}