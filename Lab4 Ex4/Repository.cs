using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ex4
{
    /// <summary>
    /// Repository class
    /// </summary>
    public class Repository
    {
        List<Apartment> apartments = new List<Apartment>();
        List<Person> people = new List<Person>();
        String dbFilepath;

        public Repository(String dbFilepath) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="dbFilepath">String representing the filepath to the database</param>

            this.dbFilepath = dbFilepath;
        }


        public void loadFromFile() {
            /// <summary>
            /// Loads all data from the database
            /// </summary>

            String peopleFilepath = @dbFilepath + "\\people.csv";
            String apartmentsFilepath = @dbFilepath + "\\apartments.csv";
            apartments.Clear();
            people.Clear();
            if (File.Exists(peopleFilepath)) {
                people.Clear();
                foreach(var line in File.ReadAllLines(peopleFilepath)) {
                    String[] personData = line.Split(',');
                    Person person = new Person(personData);
                    // WARNING! Won't save persons who don't live in this flat.
                    if (person.noApartment != 0) {
                        people.Add(person);
                    }
                }
            }
            if (File.Exists(apartmentsFilepath)) {
                apartments.Clear();
                foreach(var line in File.ReadAllLines(apartmentsFilepath)) {
                    String[] apartmentData = line.Split(',');
                    Apartment apartment = new Apartment(apartmentData);
                    apartments.Add(apartment);
                }
            }
        }


        private void savePeople() {
            /// <summary>
            /// Saves all people into the database
            /// </summary>

            String peopleFilepath = @dbFilepath + "\\people.csv";
            if (File.Exists(peopleFilepath)) {
                File.WriteAllText(peopleFilepath, String.Empty);
                using (StreamWriter sw = File.AppendText(peopleFilepath)) {
                    foreach (Person person in people) {
                        sw.WriteLine(person.toCSVString());
                    }
                }
            }
        }


        private void saveApartments() {
            /// <summary>
            /// Saves all apartments into the database
            /// </summary>

            String apartmentsFilepath = @dbFilepath + "\\apartments.csv";
            if (File.Exists(apartmentsFilepath)) {
                File.WriteAllText(apartmentsFilepath, String.Empty);
                using (StreamWriter sw = File.AppendText(apartmentsFilepath)) {
                    foreach (Apartment apartment in apartments) {
                        sw.WriteLine(apartment.toCSVString());
                    }
                }
            }
        }


        public void create(Person person) {
            /// <summary>
            /// Creates and saves a person
            /// </summary>
            /// <param name="person">Person to be created</param>

            this.people.Add(person);
            this.savePeople();
        }


        public void create(Apartment apartment) {
            /// <summary>
            /// Creates and saves an apartment
            /// </summary>
            /// <param name="apartment">Apartment to be created</param>

            this.apartments.Add(apartment);
            this.saveApartments();
        }


        public Person read(String fullName) {
            /// <summary>
            /// Reads a person by their full name
            /// </summary>
            /// <param name="fullName">Fullname of the person to look for</param>
            /// <returns>
            /// Default person, if no person has that fullName
            /// Searched person, otherwise
            /// </returns>

            String[] name = fullName.Split(' ');
            foreach(Person person in this.people) {
                if (person.forename == name[0] && person.surname == name[1])
                    return person;
            }
            return new Person();
        }

        
        public Apartment read(int noApartment) {
            /// <summary>
            /// Reads an apartment by it's number
            /// </summary>
            /// <param name="noApartment">Number of the apartment to look for</param>
            /// <returns>
            /// Default apartment, if no apartment has that number
            /// Searched apartment, otherwise
            /// </returns>

            foreach (Apartment apartment in apartments) {
                if (apartment.noApartment == noApartment) {
                    return apartment;
                }
            }
            return new Apartment();
        }


        public void update(Person oldPerson, Person newPerson) {
            /// <summary>
            /// Updates a person and saves the changes
            /// </summary>
            /// <param name="oldPerson">Person to be updated</param>
            /// <param name="newPerson">Person to replace the old one</param>
            
            people[people.FindIndex(person => person == oldPerson)]=newPerson;
            savePeople();
        }


        public void update(Apartment oldApartment, Apartment newApartment) {
            /// <summary>
            /// Updates an apartment and saves the changes
            /// </summary>
            /// <param name="oldApartment">Apartment to be updated</param>
            /// <param name="newApartment">Apartment to replace the old one</param>

            apartments[apartments.FindIndex(apartment => apartment == oldApartment)] = newApartment;
            saveApartments();
        }


        public void delete(Person personToDelete) {
            /// <summary>
            /// Deletes a person and saves the changes
            /// </summary>
            /// <param name="personToDelete">Person to be deleted</param>

            var personVar = people.Find(person => person==personToDelete);
            people.Remove(personVar);

            this.savePeople();
        }


        public void delete(Apartment apartmentToDelete) {
            /// <summary>
            /// Deletes an apartment and saves the changes
            /// </summary>
            /// <param name="apartmentToDelete">Apartment to be deleted</param>
            /// <remarks>ALL the residents of that apartment will also be deleted</remarks>

            var apartmentVar = apartments.Find(apartment => apartment == apartmentToDelete);
            apartments.Remove(apartmentVar);
            people.RemoveAll(person => person.noApartment == apartmentToDelete.noApartment);

            this.saveApartments();
            this.savePeople();
        }


        public List<Apartment> getApartments() {
            /// <summary>
            /// Getter for the list of apartments
            /// </summary>
            /// <returns>List of apartments</returns>
            
            return this.apartments;
        }


        public List<Person> getPeople() {
            /// <summary>
            /// Getter for the list of people
            /// </summary>
            /// <returns>List of people</returns>

            return this.people;
        }


        public MonthlyPayment getMonthlyPayment(Apartment apartment) {
            /// <summary>
            /// Getter for the monthly payment of an apartment
            /// </summary>
            /// <param name="apartment">Apartment to get the monthly payment of</param>
            /// <returns>MonthyPayment of the apartment</returns>

            return new MonthlyPayment(apartment);
        }

    }
}
