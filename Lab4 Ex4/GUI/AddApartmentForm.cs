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


        private List<String> validateAllInput() {
            /// <summary>
            /// Input model binding and validation to apartment
            /// </summary>
            /// <returns>Error results</returns>
            
            List<String> errorMessage = new List<String>();
            
            //Verificare numar apartament
            if (!Regex.IsMatch(noApartmentTextbox.Text, @"^\d+$") || noApartmentTextbox.TextLength == 0) {
                errorMessage.Add("Numarul apartamentului este invalid. ");
            } else if (this.service.getNoApartments().Contains(Convert.ToInt32(noApartmentTextbox.Text)))
                errorMessage.Add("Un apartament cu acel numar exista deja. ");

            //Verificare suprafata
            if (!Regex.IsMatch(surfaceTextbox.Text, @"^\d+$") || surfaceTextbox.TextLength == 0) {
                errorMessage.Add("Suprafata este invalida. ");
            } else if (Convert.ToInt32(surfaceTextbox.Text) <= 0) {
                errorMessage.Add("Suprafata trebuie sa fie mai mare decat zero. ");
            }
            return errorMessage;
        }
    }
}
