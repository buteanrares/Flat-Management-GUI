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

            List<String> errorMessage = new List<String>(validateAllInput());
            try {
                if (errorMessage.Count != 0) {
                    throw new ArgumentException();
                }

                this.service.addApartment(noApartmentTextbox.Text, "fara", "0", surfaceTextbox.Text);

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


        private List<String> validateAllInput() {
            List<String> result = new List<String>();

            String noApartment = noApartmentTextbox.Text;
            String surface = surfaceTextbox.Text;
            result.AddRange(this.service.validateApartment(noApartment, "fara", "0", surface));

            return result;
        }
    }
}
