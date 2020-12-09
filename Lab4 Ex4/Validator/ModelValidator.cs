﻿using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab4_Ex4.Validator
{
    public class ModelValidator
    {

        public ModelValidator() { }


        public List<String> bindPerson(String forename, String surname, String noApartment, String birthdate, String job) {
            List<String> result = new List<String>();

            // Verificare prenume
            if (!Regex.IsMatch(forename, @"^[a-zA-Z]+$")) {
                result.Add("Prenumele persoanei este invalid. ");
            }

            // Verificare nume
            if (!Regex.IsMatch(surname, @"^[a-zA-Z]+$")) {
                result.Add("Numele persoanei este invalid. ");
            }

            // Verificare nr apartament
            if (!Regex.IsMatch(noApartment, @"^\d+$") || noApartment.Length == 0) {
                result.Add("Numarul apartamentului este invalid. ");
            }

            // Verificare job
            if (!Regex.IsMatch(job, @"^[a-zA-Z]+$")) {
                result.Add("Job-ul persoanei este invalid. ");
            }

            return result;
        }


        public List<String> bindApartment(String noApartment, String owner, String noResidents, String surface) {
            List<String> result = new List<String>();

            //Verificare numar apartament
            if (!Regex.IsMatch(noApartment, @"^\d+$") || noApartment.Length == 0) {
                result.Add("Numarul apartamentului este invalid. ");
            }

            if (!Regex.IsMatch(noResidents, @"^\d+$") || noResidents.Length == 0) {
                result.Add("Numarul locatarilor este invalid. ");
            }

            //Verificare suprafata
            if (!Regex.IsMatch(surface, @"^\d+$") || surface.Length == 0) {
                result.Add("Suprafata este invalida. ");
            } else if (Convert.ToInt32(surface) <= 0) {
                    result.Add("Suprafata trebuie sa fie mai mare decat zero. ");
            }

            return result;
            
        }


        public List<String> validatePerson(Service service, String forename, String surname, String noApartment, String birthdate, String job, String operation="add") {
            List<String> result = new List<String>();

            //Verificare nr apartament.
            if (!service.getNoApartments().Contains(Convert.ToInt32(noApartment))) {
                result.Add("Nu exista niciun apartament cu numarul dat. ");
            }

            //Verificare data nastere
            try {
                String[] data = birthdate.Split('/');
                if (data.Length > 3)
                    throw new Exception();
                int day = Convert.ToInt32(data[0]);
                int month = Convert.ToInt32(data[1]);
                int year = Convert.ToInt32(data[2]);
                DateTime birthdateDT = new DateTime(year, month, day);
                if (birthdateDT > DateTime.Today) {
                    throw new Exception();
                }

                // Verificare eligibilitate de a detine un apartament
                if (service.getApartment(Convert.ToInt32(noApartment)).owner.Equals("fara") && (DateTime.Now - birthdateDT).TotalDays < 6570)
                    result.Add("Persoana este un minor si nu poate detine un apartament. ");
            } catch (Exception) {
                result.Add("Data nasterii este invalida. ");
            }

            //Verificare duplicat
            if (service.exists(forename + " " + surname) && operation=="add") {
                result.Add("Persoana exista deja. ");
            }

            return result;
        }


        public List<String> validateApartment(Service service, String noApartment, String owner, String noResidents, String surface, String operation="add") {
            List<String> result = new List<String>();

            //Verificare duplicat
            if (service.getNoApartments().Contains(Convert.ToInt32(noApartment)))
                result.Add("Un apartament cu acel numar exista deja. ");

            //Verificare proprietar
            List<String> personNames = new List<String>();
            foreach (Person person in service.getPeople()) {
                personNames.Add(person.getFullName("FS"));
            }
            if (!personNames.Contains(owner))
                result.Add("Persoana nu exista.");

            return result;
        }
    }
}
