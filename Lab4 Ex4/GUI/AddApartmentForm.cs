using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Lab4_Ex4.Validator;

namespace Lab4_Ex4.GUI
{
    public partial class AddApartmentForm : Form
    {
        private Service service;

        public AddApartmentForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>
            
            this.service = service;
            InitializeComponent();
        }


        private void cancelButton_Click_1(object sender, EventArgs e) { 
            /// <summary>
            /// Event handling for cancel button
            /// </summary
            
            this.Close();
        }

        private void addApartmentButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Event handling for add button
            /// </summary

            handleAddApartment();
        }

        private void handleAddApartment() {
            /// <summary>
            /// Handler for add appartment operation
            /// </summary>
            
            ModelValidator modelValidator = new ModelValidator(this.service);
            List<String> errorMessage = new List<String>();

            errorMessage.AddRange(modelValidator.validateApartment(noApartmentTextbox,surfaceTextbox));

            try {
                if (errorMessage.Count != 0) {
                    throw new ArgumentException();
                }
                int noApartment = Convert.ToInt32(noApartmentTextbox.Text);
                int surface = Convert.ToInt32(surfaceTextbox.Text);
                this.service.addApartment(noApartment, "fara", 0, surface);

                errorMessageLabel.Text = "Apartamentul a fost adaugat.";
                errorMessageLabel.ForeColor = Color.DarkGreen;
            } catch (ArgumentException) {
                errorMessageLabel.Text = "";
                errorMessageLabel.ForeColor = Color.DarkRed;
                foreach (String error in errorMessage) {
                    errorMessageLabel.Text += error;
                }
            };
        }
    }
}
