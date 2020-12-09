using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lab4_Ex4.Domain
{
    /// <summary>
    /// Apartment class
    /// </summary>
    public class Apartment
    {
        /// <summary>
        /// Object attributes and model binding
        /// </summary>
        
        public int noApartment { get; set; }

        public String owner { get; set; }

        public int noResidents { get; set; }

        public int surface { get; set; }



        public Apartment() {
            /// <summary>
            /// Default constructor
            /// </summary>
            
            this.noApartment = 0;
            this.owner = "noowner";
            this.noResidents = 0;
            this.surface = 0;
        }
        
        public Apartment(int noApartment, String owner, int noResidents, int surface) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="noApartment">Apartment's number - (used as ID)</param>
            /// <param name="owner">Apartment's owner</param>
            /// <param name="noResidents">Apartment's number of residents</param>
            /// <param name="surface">Apartment's surface (squared meters)</param>
            
            this.noApartment = noApartment;
            this.owner = owner;
            this.noResidents = noResidents;
            this.surface = surface;
        }

        public Apartment(String[] apartmentData) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="apartmentData">String of apartment's properties</param>
            /// <remarks>Order of string array: noApartment, owner, noResidents, surface</remarks>

            this.noApartment = Convert.ToInt32(apartmentData[0]);
            this.owner = apartmentData[1];
            this.noResidents = Convert.ToInt32(apartmentData[2]);
            this.surface = Convert.ToInt32(apartmentData[3]);
        }

        public String[] toStringArray() {
            /// <summary>
            /// Transforms the object into an string array of it's properties
            /// </summary>
            /// <returns>String array of apartment's properties</returns>
            /// <remarks>Order is specified above</remarks>

            String[] apartmentData = new String[4];
            apartmentData[0] = Convert.ToString(this.noApartment);
            apartmentData[1] = this.owner;
            apartmentData[2] = Convert.ToString(this.noResidents);
            apartmentData[3] = Convert.ToString(this.surface);
            return apartmentData;
        }

        public String toCSVString() {
            /// <summary>
            /// Converts an apartment's data to a CSV type string.
            /// </summary>
            /// <returns>CSV type string of the apartment's data</returns>

            return Convert.ToString(this.noApartment) + "," + this.owner + "," + Convert.ToString(this.noResidents) + "," + Convert.ToString(this.surface);
        }


        /// <summary>
        /// Overloaders for apartment comparisons (== ; !=)
        /// </summary>
        /// <param name="a">Apartment a</param>
        /// <param name="b">Apartment b</param>
        /// <returns>Boolean values depending on a's and b's data</returns>
        public static bool operator ==(Apartment a, Apartment b) => a.toStringArray().SequenceEqual(b.toStringArray());
        public static bool operator !=(Apartment a, Apartment b) => !(a.toStringArray().SequenceEqual(b.toStringArray()));

    }
}
