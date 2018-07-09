using System;
using FuelClass;

namespace fuel_usage_app
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Fuel Fuel = new Fuel();

            /* Dave Question: what is the most C# way of splitting writelines?*/
            //This is a test.
            Console.WriteLine("Please enter the distance travelled in Kilometers:");
            string distance_travelled = Console.ReadLine();
            distance_travelled = Fuel.CheckUserInput(distance_travelled);

            Console.WriteLine("Please enter the litres of petrol used:");
            string litres_used = Console.ReadLine();
            litres_used = Fuel.CheckUserInput(litres_used);

            Console.WriteLine("Please enter the cost of fuel per litre in Australian Dollarydoo's (example 1$ per litre):");
            string cost = Console.ReadLine();
            cost = Fuel.CheckUserInput(cost);

            /* Parse the userinput string into a float variable. */
            Fuel.DistanceTravelled = float.Parse(
                distance_travelled, 
                System.Globalization.CultureInfo.InvariantCulture);
            Fuel.Cost = float.Parse(
                cost, System.Globalization.CultureInfo.InvariantCulture);
            Fuel.LitresUsed = float.Parse(
                litres_used, System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("{0} litres per 100KM.\n", 
                          Fuel.KilometersPerLitre().ToString());
            Console.Write("${0} spent on {1} KM of travel.", 
                          Fuel.CostForDistanceTravelled().ToString(), 
                          Fuel.DistanceTravelled);
        }

    }
}
