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
    class ModelValidator
    {
        private Service service;
        public ModelValidator(Service service) {
            this.service = service;
        }


        public List<String> validatePerson(TextBox forenameTextbox, TextBox surnameTextbox, TextBox noApartmentTextbox, DateTimePicker birthdateDatePicker, TextBox jobTextbox) {
            List<String> result = new List<String>();

            // Verificare prenume
            if (!Regex.IsMatch(surnameTextbox.Text, @"^[a-zA-Z]+$")) {
                result.Add("Prenumele persoanei este invalid. ");
            }

            // Verificare nume
            if (!Regex.IsMatch(surnameTextbox.Text, @"^[a-zA-Z]+$")) {
                result.Add("Numele persoanei este invalid. ");
            }

            // Verificare nr apartament
            if (!Regex.IsMatch(noApartmentTextbox.Text, @"^\d+$") || noApartmentTextbox.TextLength == 0) {
                result.Add("Numarul apartamentului este invalid. ");
            } else if (!this.service.getNoApartments().Contains(Convert.ToInt32(noApartmentTextbox.Text))) {
                result.Add("Nu exista niciun apartament cu numarul dat. ");
            }

            // Verificare eligibilitate de a detine un apartament
            else if (this.service.getApartment(Convert.ToInt32(noApartmentTextbox.Text)).owner.Equals("fara") && (DateTime.Now - birthdateDatePicker.Value).TotalDays < 6570) {
                result.Add("Persoana este un minor si nu poate detine un apartament. ");
            }
            if (!Regex.IsMatch(jobTextbox.Text, @"^[a-zA-Z]+$")) {
                result.Add("Job-ul persoanei este invalid. ");
            }

            // Verificare duplicat
            String surname = surnameTextbox.Text;
            String forename = forenameTextbox.Text;
            if (this.service.exists(forename + " " + surname)) {
                result.Add("Persoana exista deja. ");
            }

            return result;
        }


        public List<String> validateApartment(TextBox noApartmentTextbox, TextBox surfaceTextbox) {
            List<String> result = new List<String>();

            //Verificare numar apartament
            if (!Regex.IsMatch(noApartmentTextbox.Text, @"^\d+$") || noApartmentTextbox.TextLength == 0) {
                result.Add("Numarul apartamentului este invalid. ");
            } else if (this.service.getNoApartments().Contains(Convert.ToInt32(noApartmentTextbox.Text)))
                result.Add("Un apartament cu acel numar exista deja. ");

            //Verificare suprafata
            if (!Regex.IsMatch(surfaceTextbox.Text, @"^\d+$") || surfaceTextbox.TextLength == 0) {
                result.Add("Suprafata este invalida. ");
            } else if (Convert.ToInt32(surfaceTextbox.Text) <= 0) {
                result.Add("Suprafata trebuie sa fie mai mare decat zero. ");
            }

            return result;
        }


        public List<String> validateApartment(DataGridView searchApartmentDGV, DataGridView modifyApartmentDGV) {
            List<String> result = new List<String>();

            if (searchApartmentDGV.SelectedRows.Count == 0)
                result.Add("Selectati mai intai apartamentul. ");
            else {
                String noApartment = modifyApartmentDGV.Rows[0].Cells[0].Value.ToString();
                String owner = modifyApartmentDGV.Rows[0].Cells[1].Value.ToString();
                String noResidents = modifyApartmentDGV.Rows[0].Cells[2].Value.ToString();
                String surface = modifyApartmentDGV.Rows[0].Cells[3].Value.ToString();

                //Verificare numar apartament
                if (!Regex.IsMatch(noApartment, @"^\d+$") || noApartment.Length == 0) {
                    result.Add("Numarul apartamentului este invalid. ");
                } else if (this.service.getNoApartments().Contains(Convert.ToInt32(noApartment)) && !noApartment.Equals(searchApartmentDGV.SelectedRows[0].Cells[0].Value.ToString()))
                    result.Add("Un apartament cu acel numar exista deja. ");

                //Verificare persoana
                List<String> personNames = new List<String>();
                foreach (Person person in this.service.getPeople()) {
                    personNames.Add(person.getFullName("FS"));
                }
                if (!personNames.Contains(owner))
                    result.Add("Persoana nu exista. ");

                //Verificare numar locatar
                if (!Regex.IsMatch(noResidents, @"^\d+$") || noResidents.Length == 0) {
                    result.Add("Numarul locatarilor este invalid. ");
                } else if (noResidents != searchApartmentDGV.SelectedRows[0].Cells[2].Value.ToString()) {
                    result.Add("Nu puteti modifica numarul de locatari. ");
                }

                //Verificare suprafata
                if (!Regex.IsMatch(surface, @"^\d+$") || surface.Length == 0) {
                    result.Add("Suprafata este invalida. ");
                } else if (Convert.ToInt32(surface) <= 0) {
                    result.Add("Suprafata trebuie sa fie mai mare decat zero. ");
                }
            }

            return result;
        }


        public List<String> validatePerson(DataGridView searchPersonDGV, DataGridView modifyPersonDGV) {
            List<String> result = new List<string>();

            if (searchPersonDGV.SelectedRows.Count == 0)
                result.Add("Selectati mai intai persoana. ");
            else {
                String surname = modifyPersonDGV.Rows[0].Cells[0].Value.ToString();
                String forename = modifyPersonDGV.Rows[0].Cells[1].Value.ToString();
                String noApartment = modifyPersonDGV.Rows[0].Cells[2].Value.ToString();
                String birthdate = modifyPersonDGV.Rows[0].Cells[3].Value.ToString();

                // Verificare prenume
                if (!Regex.IsMatch(forename, @"^[a-zA-Z]+$")) {
                    result.Add("Prenumele persoanei este invalid. ");
                }

                // Verificare nume
                if (!Regex.IsMatch(surname, @"^[a-zA-Z]+$")) {
                    result.Add("Numele persoanei este invalid. ");
                }

                // Verificare nr apartament
                if (!Regex.IsMatch(noApartment, @"^\d+$")) {
                    result.Add("Numarul apartamentului este invalid. ");
                } else if (!this.service.getNoApartments().Contains(Convert.ToInt32(noApartment))) {
                    result.Add("Nu exista niciun apartament cu numarul dat. ");
                }

                // Verificare data nasterii
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

                    // Verificare eligibilitate de a detine un apartament
                    if (this.service.getApartment(Convert.ToInt32(noApartment)).owner.Equals("fara") && (DateTime.Now - birthdateDT).TotalDays < 6570)
                        result.Add("Persoana este un minor si nu poate detine un apartament. ");
                } catch (ArgumentException) {
                    result.Add("Data nasterii este invalida. ");
                } catch (FormatException) {
                    // If noApartment conversion fails.
                    // noApartment validation is already handled above
                }

                // Verificare duplicat
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
