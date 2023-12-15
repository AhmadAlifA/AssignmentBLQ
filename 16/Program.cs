using System;

namespace Np._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tunaSandwich = 42000; // Fish
            int spaghettiCarbonara = 50000;
            int teaPitcher = 30000;
            int pizza = 70000;
            int salad = 30000;

            int n = 4, notAllergy = 3;


            int totalPrice = tunaSandwich + spaghettiCarbonara + teaPitcher + pizza + salad;

            int priceWithoutFish = totalPrice - tunaSandwich;

            double TotalPriceWithoutFish = (1.15 * priceWithoutFish) / n;

            double priceFishOnly = tunaSandwich / notAllergy;

            double totalCostPerPerson = TotalPriceWithoutFish + (1.15 * priceFishOnly);

            Console.WriteLine($"Total biaya per orang (tanpa alergi ikan): {totalCostPerPerson:N0}");
            Console.WriteLine($"Total biaya untuk yang alergi ikan: {TotalPriceWithoutFish:N0}");
        }
    }
}
