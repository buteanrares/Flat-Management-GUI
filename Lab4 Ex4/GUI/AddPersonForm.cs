using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ex4.GUI
{
    public partial class AddPersonForm : Form
    {
        private Service service;

        public AddPersonForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Event handler for add button
            /// </summary>

            this.birthdateDatePicker.CustomFormat = "dd/MM/yyyy";
            this.handleAddPerson();
        }
        private void handleAddPerson() {
            /// <summary>
            /// Handler for add person operation
            /// </summary>
            
            List<String> errorMessage = new List<String>(validateAllInput());
            try {
                if (errorMessage.Count!=0) {
                    throw new ArgumentException();
                }
                String surname = personSurnameTextbox.Text;
                String forename = personForenameTextbox.Text;
                String noApartment = noApartmentTextbox.Text;
                String birthdate = birthdateDatePicker.Value.ToString("dd/MM/yyyy");
                String job = jobTextbox.Text;
                this.service.addPerson(forename, surname, noApartment, birthdate, job);

                errorLabel.Text = "Persoana a fost adaugata.";
                errorLabel.ForeColor = Color.DarkGreen;
            } catch (ArgumentException) {
                errorLabel.Text = "";
                errorLabel.ForeColor = Color.DarkRed;
                foreach(String error in errorMessage) {
                    errorLabel.Text += error;
                }
            };
        }

        private List<String> validateAllInput() {
            /// <summary>
            /// Model binding and validation to person
            /// </summary>
            /// <returns>Error list</returns>

            List<String> errorMessage = new List<String>();

            // Verificare prenume
            if (!Regex.IsMatch(personForenameTextbox.Text, @"^[a-zA-Z]+$")) {
                errorMessage.Add("Prenumele persoanei este invalid. ");
            }

            // Verificare nume
            if (!Regex.IsMatch(personSurnameTextbox.Text, @"^[a-zA-Z]+$")) {
                errorMessage.Add("Numele persoanei este invalid. ");
            }

            // Verificare nr apartament
            if (!Regex.IsMatch(noApartmentTextbox.Text, @"^\d+$") || noApartmentTextbox.TextLength == 0) {
                errorMessage.Add("Numarul apartamentului este invalid. ");
            } else if (!this.service.getNoApartments().Contains(Convert.ToInt32(noApartmentTextbox.Text))) {
                errorMessage.Add("Nu exista niciun apartament cu numarul dat. ");
            }
            
            // Verificare eligibilitate de a detine un apartament
            if (this.service.getApartment(Convert.ToInt32(noApartmentTextbox.Text)).owner.Equals("fara") && (DateTime.Now - birthdateDatePicker.Value).TotalDays < 6570) {
                errorMessage.Add("Persoana este un minor si nu poate detine un apartament. ");
            }
            if (!Regex.IsMatch(jobTextbox.Text, @"^[a-zA-Z]+$")) {
                errorMessage.Add("Job-ul persoanei este invalid. ");
            }

            // Verificare duplicat
            String surname = personSurnameTextbox.Text;
            String forename = personForenameTextbox.Text;
            if (this.service.exists(forename + " " + surname)) {
                errorMessage.Add("Persoana exista deja. ");
            }
            return errorMessage;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Event handler for cancel button
            /// </summary>
            
            this.Close();
        }
    }
}
