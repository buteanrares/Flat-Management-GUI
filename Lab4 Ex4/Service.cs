using Lab4_Ex4.Domain;
using Lab4_Ex4.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lab4_Ex4
{
    /// <summary>
    /// Service class
    /// </summary>
    public class Service
    {
        Repository repository;

        public Service(Repository repository) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="repository">Repository containing the database</param>

            this.repository = repository;
        }

        public void delete(Person person) {
            /// <summary>
            /// Deletes a person
            /// </summary>
            /// <param name="person">Person to be deleted</param>
            /// <remarks>
            /// If the person is also the owner of an apartment, another resident of that apartment will become the owner
            /// If the person is the only resident of an apartment, that apartment's owner will be set to "fara" (none)
            /// </remarks>

            Apartment apartment = this.getApartment(person.noApartment);
            Apartment updateApartment = this.getApartment(person.noApartment);
            updateApartment.noResidents--;
            if (updateApartment.owner.Equals(person.getFullName("FS"))){
                // THIS THROWS EXCEPTION
                String newOwner = this.findNewOwner(updateApartment.noApartment,person);
                //
                updateApartment.owner = newOwner;
            }
            this.repository.update(apartment, updateApartment);
            this.repository.delete(person);
        }

        public void delete(Apartment apartment) {
            /// <summary>
            /// Deletes an apartment
            /// </summary>
            /// <param name="apartment">Apartment to be deleted</param>

            this.repository.delete(apartment);
        }
        
        public bool exists(String fullName) {
            /// <summary>
            /// Checks if a person with that fullName exists
            /// </summary>
            /// <param name="fullName">Persons's fullName</param>
            /// <returns>Boolean valeus depending if that person exists or not</returns>

            String[] name = fullName.Split(' ');
            foreach(Person person in this.repository.getPeople()) {
                if (person.forename.Equals(name[0]) && person.surname.Equals(name[1]))
                    return true;
            }
            return false;
        }

        public List<int> getNoApartments() {
            /// <summary>
            /// Getter for the list of apartments
            /// </summary>
            /// <returns>The list of apartments</returns>

            List<int> noApartmentsList = new List<int>();
            foreach(Apartment apartment in this.repository.getApartments()) {
                noApartmentsList.Add(apartment.noApartment);
            }
            return noApartmentsList;
        }

        public Apartment getApartment(int noApartment) {
            /// <summary>
            /// Getter of a single apartment
            /// </summary>
            /// <param name="noApartment">Number of the apartment to get</param>
            /// <returns>The apartment with that number</returns>

            return this.repository.read(noApartment);
        }

        public void addPerson(String forename, String surname, int noApartment, String birthdate, String job) {
            /// <summary>
            /// Adds a person
            /// </summary>
            /// <param name="forename">Person's forename</param>
            /// <param name="surname">Person's surname</param>
            /// <param name="noApartment">Person's apartment number</param>
            /// <param name="birthdate">Person's birthdate</param>
            /// <param name="job">Person's job</param>

            Person person = new Person(forename, surname, noApartment, birthdate, job);
            Apartment apartment = this.repository.read(noApartment);
            if (apartment.owner.Equals("fara"))
                apartment.owner = person.forename + " " + person.surname;
            apartment.noResidents++;
            this.repository.update(this.repository.read(noApartment), apartment);
            this.repository.create(person);
        }

        public void addApartment(int noApartment, String owner, int noResidents, int surface) {
            /// <summary>
            /// Adds an apartment
            /// </summary>
            /// <param name="noApartment">Apartment's number</param>
            /// <param name="owner">Apartment's owner</param>
            /// <param name="noResidents">Apartment's number of residents</param>
            /// <param name="surface">Apartment's surface</param>
            
            Apartment apartment = new Apartment(noApartment, owner, noResidents, surface);
            this.repository.create(apartment);
        }

        public void updatePerson(Person oldPerson, Person newPerson) {
            /// <summary>
            /// Updates a person
            /// </summary>
            /// <param name="oldPerson">Person to be updated</param>
            /// <param name="newPerson">Person to replace the old one</param>

            this.repository.update(oldPerson, newPerson);
            if (newPerson.noApartment != oldPerson.noApartment) {
                incrementNoResidents(this.repository.read(newPerson.noApartment));
                decrementNoResidents(this.repository.read(oldPerson.noApartment));

                Apartment oldApartment = this.repository.read(oldPerson.noApartment);
                Apartment newApartment = this.repository.read(oldPerson.noApartment);
                String newOwner = this.findNewOwner(oldPerson.noApartment, oldPerson);
                newApartment.owner = newOwner;
                this.repository.update(oldApartment, newApartment);
            }
        }

        public void updateApartment(Apartment oldApartment, Apartment newApartment) {
            /// <summary>
            /// Updates an apartment
            /// </summary>
            /// <param name="oldApartment">Apartment to be updated</param>
            /// <param name="newApartment">Apartment to replace the old one</param>
            /// <remarks>Updating the number will also update all it's residents</remarks>

            //Copying the list of people. Changing the main list while browsing it throws an exception.
            List<Person> peopleCopy = this.getPeople();

            //Updating people apartment number if it changes
            if (oldApartment.noApartment != newApartment.noApartment) {
                for (int i = 0; i < peopleCopy.Count; i++) {
                    if (peopleCopy[i].noApartment == oldApartment.noApartment) {
                        Person newPerson = new Person(peopleCopy[i]);
                        newPerson.noApartment = newApartment.noApartment;
                        this.repository.update(peopleCopy[i], newPerson);
                    }
                }
            }

            //Changing the owner of an apartment will automatically move that person into the apartment

            if (oldApartment.owner != newApartment.owner) {
                Person oldPerson = new Person(this.repository.read(newApartment.owner));
                Person newPerson = new Person(oldPerson);
                newPerson.noApartment = newApartment.noApartment;


                if (oldApartment.noResidents == 0) {
                    oldApartment.owner = "fara";
                }

                this.repository.update(oldApartment, newApartment);
                this.updatePerson(oldPerson, newPerson);
                return;

            }
            this.repository.update(oldApartment, newApartment);
        }

        public List<Person> getPeople() {
            /// <summary>
            /// Getter for the list of people
            /// </summary>
            /// <returns>List of people</returns>

            return this.repository.getPeople();
        }

        public List<Apartment> getApartments() {
            /// <summary>
            /// Getter for the list of apartments
            /// </summary>
            /// <returns>List of apartments</returns>

            return this.repository.getApartments();
        }

        public MonthlyPayment getMonthlyPayment(Apartment apartment) {
            /// <summary>
            /// Getter for the monthly payment of an apartment
            /// </summary>
            /// <param name="apartment">The apartment calculate taxes of</param>
            /// <returns>MonthlyPayment</returns>

            return this.repository.getMonthlyPayment(apartment);
        }

        private void incrementNoResidents(Apartment apartment) {
            /// <summary>
            /// Increments the number of residents of an apartment
            /// </summary>
            /// <param name="apartment">The apartment explained above</param>

            Apartment newApartment = this.repository.read(apartment.noApartment);
            newApartment.noResidents++;
            this.repository.update(apartment, newApartment);
        }

        private void decrementNoResidents(Apartment apartment) {
            /// <summary>
            /// Decrements the number of residents of an apartment
            /// </summary>
            /// <param name="apartment">The apartment explained above</param>
            
            Apartment newApartment = this.repository.read(apartment.noApartment);
            newApartment.noResidents--;
            if (newApartment.noResidents == 0) {
                newApartment.owner = "fara";
            }
            this.repository.update(apartment, newApartment);
        }

        public List<Person> getResidents(int noApartment) {
            /// <summary>
            /// Getter for the list of residents of an apartment
            /// </summary>
            /// <param name="noApartment">Number of the apartment explained above</param>
            /// <returns>Persons living in an specific apartment</returns>

            List<Person> residents = new List<Person>();
            foreach(Person person in this.getPeople()) {
                if (person.noApartment == noApartment)
                    residents.Add(person);
            }
            return residents;
        }

        public String findNewOwner(int noApartment, Person exOwner) {
            /// <summary>
            /// Finds a new owner of an an apartment
            /// </summary>
            /// <param name="noApartment">Number of the apartment which gets the new owner</param>
            /// <param name="exOwner">Owner who moved or got deleted</param>
            /// <returns>String with new owner's full name</returns>

            List<Person> people = new List<Person>(this.getPeople());
            var personVar = people.Find(person => person == exOwner);
            people.Remove(personVar);

            foreach (Person person in people) {
                //TODO Verify eligibility of apartment ownership
                if (person.noApartment == noApartment) {
                    return person.getFullName();
                }
            }
            return "fara";
        }
    }
}
