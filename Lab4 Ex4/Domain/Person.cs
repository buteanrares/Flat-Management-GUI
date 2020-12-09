using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab4_Ex4.Domain
{
    /// <summary>
    /// Person class
    /// </summary>
    public class Person
    {

        ///<summary>
        /// Object attributes and model binding
        ///</summary>

        public String forename { get; set; }

        public String surname { get; set; }

        public int noApartment { get; set; }

        public String birthdate { get; set; }

        public String job { get; set; }



        public Person() {
            /// <summary>
            /// Default constructor
            /// </summary>

            this.forename = "noforename";
            this.surname = "nosurname";
            this.noApartment = 0;
            this.birthdate = "00/00/0000";
            this.job = "nojob";
        }


        public Person(Person p) {
            /// <summary>
            /// Copy constructor
            /// </summary>
            /// <param name="p">The person who is being cloned</param>

            this.forename = p.forename;
            this.surname = p.surname;
            this.noApartment = p.noApartment;
            this.birthdate = p.birthdate;
            this.job = p.job;
        }


        public Person(String forename, String surname, int noApartment, String birthdate, String job) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="forename">Person's forename</param>
            /// <param name="surname">Person's surname</param>
            /// <param name="noApartment">Person's apartment</param>
            /// <param name="birthdate">Person's birthdate</param>
            /// <param name="job">Person's job</param>

            this.forename = forename;
            this.surname = surname;
            this.noApartment = noApartment;
            this.birthdate = birthdate;
            this.job = job;
        }


        public Person(String[] personData) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="personData">String array containing a person's data</param>
            /// <remarks>Order: forename, surname, noApartment, birthdate, job</remarks>

            this.forename = personData[0];
            this.surname = personData[1];
            this.noApartment = Convert.ToInt32(personData[2]);
            this.birthdate = personData[3];
            this.job = personData[4];
        }


        public String[] toStringArray() {
            /// <summary>
            /// Converts a person's data into a string array
            /// </summary>
            /// <returns>String array of person's data</returns>
            /// <remarks>Order is explained above</remarks>

            String[] personData = new String[5];
            personData[0] = this.forename;
            personData[1] = this.surname;
            personData[2] = Convert.ToString(this.noApartment);
            personData[3] = this.birthdate;
            personData[4] = this.job;
            return personData;
        }
        

        public String getFullName(String format="FS") {
            /// <summary>
            /// Getter for person's full name
            /// </summary>
            /// <param name="format">Output format</param>
            /// <returns>Person's full name</returns>
            /// <remarks>
            /// format can be:
            /// "FS" => forename + " " + surname
            /// "SF" => surname + " " + forename
            /// </remarks>

            if (format.Equals("FS"))
                return this.forename + " " + this.surname;
            else if (format.Equals("SF"))
                return this.surname + " " + this.forename;
            throw new ArgumentException("Wrong format");
        }
        

        public String toCSVString() {
            /// <summary>
            /// Converts person's data into a CSV type string
            /// </summary>
            /// <returns>CSV type string of person's data</returns>

            return this.forename + "," + this.surname + "," + Convert.ToString(this.noApartment) + "," + this.birthdate + "," + this.job;
        }

        public DateTime getDateTime() {
            String[] data = birthdate.Split('/');
            int day = Convert.ToInt32(data[0]);
            int month = Convert.ToInt32(data[1]);
            int year = Convert.ToInt32(data[2]);
            DateTime birthdateDT = new DateTime(year, month, day);
            if (birthdateDT > DateTime.Today) {
                return DateTime.Today;
            }
            return birthdateDT;
        }


        /// <summary>
        /// Overloaders for person comparisons (== ; !=)
        /// </summary>
        /// <param name="a">Person a</param>
        /// <param name="b">Person b</param>
        /// <returns>Boolean values depending on a's and b's data</returns>
        public static bool operator ==(Person a, Person b) => a.toStringArray().SequenceEqual(b.toStringArray());

        public static bool operator !=(Person a, Person b) => !(a.toStringArray().SequenceEqual(b.toStringArray()));
    }
}
