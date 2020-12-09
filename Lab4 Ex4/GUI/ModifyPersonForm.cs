using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Lab4_Ex4.GUI
{
    public partial class ModifyPersonForm : Form
    {
        private Service service;


        public ModifyPersonForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }


        private void nameTextbox_TextChanged(object sender, EventArgs e) {
            /// <summary>
            /// Handler for nameTextbox text update event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            searchedPersonGrid.Rows.Clear();
            List<Person> people = new List<Person>(this.service.getPeople());
            foreach (Person person in people) {
                if (person.getFullName().ToLower().Contains(nameTextbox.Text.ToLower()))
                    searchedPersonGrid.Rows.Add(person.surname, person.forename, person.noApartment, person.birthdate, person.job);
            }
        }


        private void searchedPersonGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            /// <summary>
            /// Handler for searchedPersonGrid cell click event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            modifyPersonGrid.Rows.Clear();
            modifyPersonGrid.Rows.Add();
            modifyPersonGrid.Rows[0].Cells[0].Value = searchedPersonGrid.SelectedRows[0].Cells[0].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[1].Value = searchedPersonGrid.SelectedRows[0].Cells[1].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[2].Value = searchedPersonGrid.SelectedRows[0].Cells[2].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[3].Value = searchedPersonGrid.SelectedRows[0].Cells[3].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[4].Value = searchedPersonGrid.SelectedRows[0].Cells[4].Value.ToString();
        }


        private void cancelButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for cancel button event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            this.Close();
        }


        private void applyButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for apply button event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            handleModifyPerson();
        }


        private void handleModifyPerson() {
            /// <summary>
            /// Handler for person modify
            /// </summary>

            List<String> errorMessage = new List<String>(validateAllInput());
            try {
                if (errorMessage.Count != 0) {
                    throw new ArgumentException();
                }
                int index = searchedPersonGrid.CurrentCell.RowIndex;

                String oldSurname = searchedPersonGrid.Rows[index].Cells[0].Value.ToString();
                String oldForename = searchedPersonGrid.Rows[index].Cells[1].Value.ToString();
                int oldNoApartment = Convert.ToInt32(searchedPersonGrid.Rows[index].Cells[2].Value.ToString());
                String oldBirthdate = searchedPersonGrid.Rows[index].Cells[3].Value.ToString();
                String oldJob= searchedPersonGrid.Rows[index].Cells[4].Value.ToString();

                String newSurname = modifyPersonGrid.Rows[0].Cells[0].Value.ToString();
                String newForename = modifyPersonGrid.Rows[0].Cells[1].Value.ToString();
                int newNoApartment = Convert.ToInt32(modifyPersonGrid.Rows[0].Cells[2].Value.ToString());
                String newBirthdate = modifyPersonGrid.Rows[0].Cells[3].Value.ToString();
                String newJob = modifyPersonGrid.Rows[0].Cells[4].Value.ToString();

                Person oldPerson = new Person(oldForename, oldSurname, oldNoApartment, oldBirthdate, oldJob);
                Person newPerson = new Person(newForename, newSurname, newNoApartment, newBirthdate, newJob);

                this.service.updatePerson(oldPerson,newPerson);

                errorMessageLabel.Text = "Persoana a fost modificata.";
                errorMessageLabel.ForeColor = Color.DarkGreen;
            } catch (ArgumentException) {
                errorMessageLabel.Text = "";
                errorMessageLabel.ForeColor = Color.DarkRed;
                foreach (String error in errorMessage) {
                    errorMessageLabel.Text += error;
                }
            } catch (Exception) {
                errorMessageLabel.Text = "Alegeti persoana de modificat.";
                errorMessageLabel.ForeColor = Color.DarkRed;
            }
        }


        private List<String> validateAllInput() {
            /// <summary>
            /// Model binding and validation to person
            /// </summary>
            /// <returns>Error list</returns>

            List<String> errorMessage = new List<String>();
            if (searchedPersonGrid.SelectedRows.Count == 0)
                errorMessage.Add("Selectati mai intai persoana. ");
            else {
                String surname = modifyPersonGrid.Rows[0].Cells[0].Value.ToString();
                String forename = modifyPersonGrid.Rows[0].Cells[1].Value.ToString();
                String noApartment = modifyPersonGrid.Rows[0].Cells[2].Value.ToString();
                String birthdate = modifyPersonGrid.Rows[0].Cells[3].Value.ToString();

                // Verificare prenume
                if (!Regex.IsMatch(forename, @"^[a-zA-Z]+$")) {
                    errorMessage.Add("Prenumele persoanei este invalid. ");
                }

                // Verificare nume
                if (!Regex.IsMatch(surname, @"^[a-zA-Z]+$")) {
                    errorMessage.Add("Numele persoanei este invalid. ");
                }

                // Verificare nr apartament
                if (!Regex.IsMatch(noApartment, @"^\d+$")) {
                    errorMessage.Add("Numarul apartamentului este invalid. ");
                } else if (!this.service.getNoApartments().Contains(Convert.ToInt32(noApartment))) {
                    errorMessage.Add("Nu exista niciun apartament cu numarul dat. ");
                }

                // Verificare data nasterii
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
                    if (this.service.getApartment(Convert.ToInt32(noApartment)).owner.Equals("fara") && (DateTime.Now - birthdateDT).TotalDays < 6570)
                        errorMessage.Add("Persoana este un minor si nu poate detine un apartament. ");
                } catch (Exception) {
                    errorMessage.Add("Data nasterii este invalida. ");
                }

                // Verificare duplicat
                int index = searchedPersonGrid.CurrentCell.RowIndex;
                if (this.service.exists(forename + " " + surname)) {
                    if(forename!=searchedPersonGrid.SelectedRows[index].Cells[1].Value.ToString() && surname!=searchedPersonGrid.SelectedRows[index].Cells[0].Value.ToString())
                        errorMessage.Add("Persoana exista deja. ");
                }
            }
            return errorMessage;
        }
    }
}
