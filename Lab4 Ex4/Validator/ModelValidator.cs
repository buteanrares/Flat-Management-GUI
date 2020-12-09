using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab4_Ex4.Validator
{
    class ModelBinder
    {
        public List<String> bindPerson(Person person) {
            List<String> result = new List<String>();

            //Forename 
            if (!Regex.IsMatch(person.forename, @"^[a-zA-Z]+$")) {
                result.Add("Prenumele persoanei este invalid. ");
            }

            //Surname
            if (!Regex.IsMatch(person.surname, @"^[a-zA-Z]+$")) {
                result.Add("Numele persoanei este invalid. ");
            }

            //NoApartment
            if (person.noApartment < 1) {
                result.Add("Numarul apartamentului este invalid. ");
            }

            //Job
            if (!Regex.IsMatch(person.job, @"^[a-zA-Z]+$")) {
                result.Add("Job-ul persoanei este invalid. ");
            }

            return result;
        }

        public List<String> bindApartment(Apartment apartment) {
            List<String> errorMessage = new List<String>();

            //NoApartment
            if (apartment.noApartment < 1) {
                errorMessage.Add("Numarul apartamentului este invalid. ");
            }

            //Surface
            if (apartment.surface < 1) {
                errorMessage.Add("Suprafata apartamentului este invalida. ");
            }

            return errorMessage;
        }
    }
}
