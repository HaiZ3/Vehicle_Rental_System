using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_System.Enums;
using Vehicle_Rental_System.Models.Interfaces;

namespace Vehicle_Rental_System.Models
{
    internal class Car : IVehicle
    {
        private decimal rentingPricePerDay;
        private decimal insuranceCostPerDay = 0.01M;
        public Car(string model, string brand, decimal value, int daysRented, SafetyRating safetyRating)
        {
            Model = model;
            Brand = brand;
            Value = value;
            DaysRented = daysRented;
            SafetyRating = safetyRating;
            if(daysRented > 7)
            {
                rentingPricePerDay = 15;
            }
            else
            {
                rentingPricePerDay = 20;
            }
            if((int)safetyRating >= 4)
            {
                insuranceCostPerDay = insuranceCostPerDay * 0.9M;
            }
        }

        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Value { get; set; }
        public int DaysRented { get; set; }
        public SafetyRating SafetyRating { get; set; }

        public decimal GetInsuranceCost(int DaysRented,)
        {
            
        }
    }
}
