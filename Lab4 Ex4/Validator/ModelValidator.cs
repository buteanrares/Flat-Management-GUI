using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lab4_Ex4.Domain;

namespace Lab4_Ex4.Validator
{
    /// <summary>
    /// Validator class for Person and Apartment
    /// </summary>
    class ModelValidator
    {
        private Service service;

        public ModelValidator(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
        }


        public List<String> validatePerson(TextBox forenameTextbox, TextBox surnameTextbox, TextBox noApartmentTextbox, DateTimePicker birthdateDatePicker, TextBox jobTextbox) {
            /// <summary>
            /// Person validator for AddPersonForm
            /// </summary>
            /// <param name="forenameTextbox"></param>
            /// <param name="surnameTextbox"></param>
            /// <param name="noApartmentTextbox"></param>
            /// <param name="birthdateDatePicker"></param>
            /// <param name="jobTextbox"></param>
            /// <returns>Lists of string of errors. These errors are displayed for the user.</returns>

            List<String> result = new List<String>();

            // Forename validator
            if (!Regex.IsMatch(forenameTextbox.Text, @"^[a-zA-Z]+$")) {
                result.Add("Prenumele persoanei este invalid. ");
            }

            // Surname validator
            if (!Regex.IsMatch(surnameTextbox.Text, @"^[a-zA-Z]+$")) {
                result.Add("Numele persoanei este invalid. ");
            }

            // NoApartment validator
            if (!Regex.IsMatch(noApartmentTextbox.Text, @"^\d+$") || noApartmentTextbox.TextLength == 0) {
                result.Add("Numarul apartamentului este invalid. ");
            } else if (!this.service.getNoApartments().Contains(Convert.ToInt32(noApartmentTextbox.Text))) {
                result.Add("Nu exista niciun apartament cu numarul dat. ");
            }

            // Apartment ownership eligibility validation
            else if (this.service.getApartment(Convert.ToInt32(noApartmentTextbox.Text)).owner.Equals("fara") && (DateTime.Now - birthdateDatePicker.Value).TotalDays < 6570) {
                result.Add("Persoana este un minor si nu poate detine un apartament. ");
            }
            if (!Regex.IsMatch(jobTextbox.Text, @"^[a-zA-Z]+$")) {
                result.Add("Job-ul persoanei este invalid. ");
            }

            // Duplicate validation
            String surname = surnameTextbox.Text;
            String forename = forenameTextbox.Text;
            if (this.service.exists(forename + " " + surname)) {
                result.Add("Persoana exista deja. ");
            }

            return result;
        }


        public List<String> validateApartment(TextBox noApartmentTextbox, TextBox surfaceTextbox) {
            /// <summary>
            /// Apartment validator for AddApartmentForm
            /// </summary>
            /// <param name="noApartmentTextbox"></param>
            /// <param name="surfaceTextbox"></param>
            /// <returns>List of errors. These are displayed to the user.</returns>

            List<String> result = new List<String>();

            // NoApartment validation
            if (!Regex.IsMatch(noApartmentTextbox.Text, @"^\d+$") || noApartmentTextbox.TextLength == 0) {
                result.Add("Numarul apartamentului este invalid. ");
            } else if (this.service.getNoApartments().Contains(Convert.ToInt32(noApartmentTextbox.Text)))
                result.Add("Un apartament cu acel numar exista deja. ");

            // Surface validation
            if (!Regex.IsMatch(surfaceTextbox.Text, @"^\d+$") || surfaceTextbox.TextLength == 0) {
                result.Add("Suprafata este invalida. ");
            } else if (Convert.ToInt32(surfaceTextbox.Text) <= 0) {
                result.Add("Suprafata trebuie sa fie mai mare decat zero. ");
            }

            return result;
        }


        public List<String> validateApartment(DataGridView searchApartmentDGV, DataGridView modifyApartmentDGV) {
            /// <summary>
            /// Apartment validator for ModifyApartmentForm
            /// </summary>
            /// <param name="searchApartmentDGV"></param>
            /// <param name="modifyApartmentDGV"></param>
            /// <returns>List of errors. These are displayed to the user.</returns>

            List<String> result = new List<String>();

            // DGV Row selected check
            if (searchApartmentDGV.SelectedRows.Count == 0)
                result.Add("Selectati mai intai apartamentul. ");
            else {
                String noApartment = modifyApartmentDGV.Rows[0].Cells[0].Value.ToString();
                String owner = modifyApartmentDGV.Rows[0].Cells[1].Value.ToString();
                String noResidents = modifyApartmentDGV.Rows[0].Cells[2].Value.ToString();
                String surface = modifyApartmentDGV.Rows[0].Cells[3].Value.ToString();

                // NoApartment validation
                if (!Regex.IsMatch(noApartment, @"^\d+$") || noApartment.Length == 0) {
                    result.Add("Numarul apartamentului este invalid. ");
                } else if (this.service.getNoApartments().Contains(Convert.ToInt32(noApartment)) && !noApartment.Equals(searchApartmentDGV.SelectedRows[0].Cells[0].Value.ToString()))
                    result.Add("Un apartament cu acel numar exista deja. ");

                // Owner (FullName) validation
                List<String> personNames = new List<String>();
                foreach (Person person in this.service.getPeople()) {
                    personNames.Add(person.getFullName("FS"));
                }
                if (!personNames.Contains(owner))
                    result.Add("Persoana nu exista. ");

                // NoResidents validation
                if (!Regex.IsMatch(noResidents, @"^\d+$") || noResidents.Length == 0) {
                    result.Add("Numarul locatarilor este invalid. ");
                } else if (noResidents != searchApartmentDGV.SelectedRows[0].Cells[2].Value.ToString()) {
                    result.Add("Nu puteti modifica numarul de locatari. ");
                }

                // Surface validation
                if (!Regex.IsMatch(surface, @"^\d+$") || surface.Length == 0) {
                    result.Add("Suprafata este invalida. ");
                } else if (Convert.ToInt32(surface) <= 0) {
                    result.Add("Suprafata trebuie sa fie mai mare decat zero. ");
                }
            }

            return result;
        }


        public List<String> validatePerson(DataGridView searchPersonDGV, DataGridView modifyPersonDGV) {
            /// <summary>
            /// Person validator for ModifyPersonForm
            /// </summary>
            /// <param name="searchPersonDGV"></param>
            /// <param name="modifyPersonDGV"></param>
            /// <returns>List of errors. These are displayed to the user.</returns>

            List<String> result = new List<string>();

            // DGV Row selected check
            if (searchPersonDGV.SelectedRows.Count == 0)
                result.Add("Selectati mai intai persoana. ");
            else {
                String surname = modifyPersonDGV.Rows[0].Cells[0].Value.ToString();
                String forename = modifyPersonDGV.Rows[0].Cells[1].Value.ToString();
                String noApartment = modifyPersonDGV.Rows[0].Cells[2].Value.ToString();
                String birthdate = modifyPersonDGV.Rows[0].Cells[3].Value.ToString();

                // Forename validation
                if (!Regex.IsMatch(forename, @"^[a-zA-Z]+$")) {
                    result.Add("Prenumele persoanei este invalid. ");
                }

                // Surname validation
                if (!Regex.IsMatch(surname, @"^[a-zA-Z]+$")) {
                    result.Add("Numele persoanei este invalid. ");
                }

                // NoApartment validation
                if (!Regex.IsMatch(noApartment, @"^\d+$")) {
                    result.Add("Numarul apartamentului este invalid. ");
                } else if (!this.service.getNoApartments().Contains(Convert.ToInt32(noApartment))) {
                    result.Add("Nu exista niciun apartament cu numarul dat. ");
                }

                // Birthdate validation
                try {
                    String[] data = birthdate.Split('/');
                    if (data.Length > 3)
                        throw new ArgumentException();
                    int day = Convert.ToInt32(data[0]);
                    int month = Convert.ToInt32(data[1]);
                    int year = Convert.ToInt32(data[2]);
                    DateTime birthdateDT = new DateTime(year, month, day);
                    if (birthdateDT > DateTime.Today) {
                        throw new ArgumentException();
                    }

                    // Apartment ownership eligibility validation
                    if (this.service.getApartment(Convert.ToInt32(noApartment)).owner.Equals("fara") && (DateTime.Now - birthdateDT).TotalDays < 6570)
                        result.Add("Persoana este un minor si nu poate detine un apartament. ");
                } catch (ArgumentException) {
                    result.Add("Data nasterii este invalida. ");
                } catch (FormatException) {
                    // If noApartment conversion fails.
                    // noApartment validation is already handled above
                }

                // Duplicate validation
                int index = searchPersonDGV.CurrentCell.RowIndex;
                if (this.service.exists(forename + " " + surname)) {
                    if (forename != searchPersonDGV.SelectedRows[index].Cells[1].Value.ToString() && surname != searchPersonDGV.SelectedRows[index].Cells[0].Value.ToString())
                        result.Add("Persoana exista deja. ");
                }
            }

            return result;
        }
    }
}
