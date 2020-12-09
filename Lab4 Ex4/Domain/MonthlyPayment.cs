using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ex4.Domain
{
    /// <summary>
    /// Monthly payment class
    /// </summary>
    public class MonthlyPayment
    {
        private Apartment apartment;


        public MonthlyPayment(Apartment apartment) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="apartment">Apartment to find the monthly payment for</param>

            this.apartment = apartment;
        }

        public Dictionary<String,int> getMonthlyPayment(int month) {
            /// <summary>
            /// Finds and stores the tax for each category in a dictionary where key=category ; value = price
            /// </summary>
            /// <param name="month">The month to find the taxes in</param>
            /// <returns>Dictionary<String,int> explained above</returns>

            Dictionary<String, int> monthPayment = new Dictionary<string, int>();

            Random rng = new Random(month);
            Random apartmentRng = new Random(apartment.noApartment);

            double randomMultiplier = (double)rng.Next(7,13)/10;
            double residentsMultiplier = this.apartment.noResidents*0.08;
            double surfaceMultiplier = this.apartment.surface * 0.04 ;
            double apartmentMultiplier = (double)apartmentRng.Next(8,12)/10;

            int gasTax = Convert.ToInt32(120 * randomMultiplier * residentsMultiplier * surfaceMultiplier * apartmentMultiplier);
            int maintenanceWaterTax = Convert.ToInt32(370 * randomMultiplier * residentsMultiplier * apartmentMultiplier);
            int electricityTax = Convert.ToInt32(110 * randomMultiplier * residentsMultiplier * surfaceMultiplier * apartmentMultiplier);
            int internet = Convert.ToInt32(310 * randomMultiplier * residentsMultiplier * apartmentMultiplier);
            int total = gasTax + maintenanceWaterTax + electricityTax + internet;

            monthPayment.Add("Gas", gasTax);
            monthPayment.Add("Maintenance & water", maintenanceWaterTax);
            monthPayment.Add("Electricity", electricityTax);
            monthPayment.Add("Internet", internet);
            monthPayment.Add("Total", total);

            return monthPayment;
        }
    }
}
