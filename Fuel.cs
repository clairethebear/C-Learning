using System;

namespace FuelClass
{
    public class Fuel
    {
        private float _distance_travelled;
        private float _cost;
        private float _litres_used;

        public Fuel(float distance, float cost, float litres_used)
        {
            _distance_travelled = distance;
            _cost = cost;
            _litres_used = litres_used;
        }

        public Fuel()
        {
            _distance_travelled = 0;
            _cost = 0;
            _litres_used = 0;
        }

        public float DistanceTravelled
        {
            set => _distance_travelled = value;
            get
            {
                return _distance_travelled;
            }
        }
        public float Cost
        {
            set => _cost = value;
            get
            {
                return _cost;
            }
        }
        public float LitresUsed
        {
            set => _litres_used = value;
            get
            {
                return _litres_used;
            }
        }

        public float KilometersPerLitre()
        {
            return (_litres_used * 100) / _distance_travelled;
        }

        public float CostForDistanceTravelled()
        {
            return _litres_used * _cost;
        }

        public string CheckUserInput(string value)
        {
            /* Dave Question: Is this the best way to implement a Try catch? */
            int line;
            while (!int.TryParse(value, out line))
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                value = Console.ReadLine();
            }
            return value;
        }
    }
}
