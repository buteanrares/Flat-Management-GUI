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
using Lab4_Ex4.Validator;

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
            
            ModelValidator modelValidator = new ModelValidator(this.service);
            List<String> errorMessage = new List<String>();

            errorMessage.AddRange(modelValidator.validatePerson(personForenameTextbox, personSurnameTextbox, noApartmentTextbox, birthdateDatePicker, jobTextbox));

            try {
                if (errorMessage.Count!=0) {
                    throw new ArgumentException();
                }
                String surname = personSurnameTextbox.Text;
                String forename = personForenameTextbox.Text;
                int noApartment = Convert.ToInt32(noApartmentTextbox.Text);
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


        private void cancelButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Event handler for cancel button
            /// </summary>

            this.Close();
        }
    }
}
