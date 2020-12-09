using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4_Ex4.GUI
{
    public partial class ModifyApartmentForm : Form
    {
        private Service service;

        public ModifyApartmentForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }


        private void apartmentInfoTextbox_TextChanged(object sender, EventArgs e) {
            /// <summary>
            /// Event handler for apartmentInfoTextbox text update
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            apartmentsGridView.Rows.Clear();
            List<Apartment> apartments = new List<Apartment>(this.service.getApartments());
            foreach (Apartment apartment in apartments) {
                if (apartment.noApartment.ToString() == apartmentInfoTextbox.Text || apartment.owner.ToLower().Contains(apartmentInfoTextbox.Text.ToLower())) {
                    apartmentsGridView.Rows.Add(apartment.noApartment, apartment.owner, apartment.noResidents, apartment.surface);
                }
            }
        }


        private void applyButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for apply button event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            this.handleModifyApartment();
        }


        private void handleModifyApartment() {
            /// <summary>
            /// Handler for apartment modify
            /// </summary>

            List<String> errorMessage = new List<String>(validateAllInput());
            try { 
                if (errorMessage.Count != 0) {
                    throw new ArgumentException();
                }
                int index = apartmentsGridView.CurrentCell.RowIndex;

                int oldNoApartment = Convert.ToInt32(apartmentsGridView.Rows[index].Cells[0].Value.ToString());
                String oldOwner = apartmentsGridView.Rows[index].Cells[1].Value.ToString();
                int oldNoResidents = Convert.ToInt32(apartmentsGridView.Rows[index].Cells[2].Value.ToString());
                int oldSurface = Convert.ToInt32(apartmentsGridView.Rows[index].Cells[3].Value.ToString());

                int newNoApartment = Convert.ToInt32(modifyApartmentGrid.Rows[0].Cells[0].Value.ToString());
                String newOwner = modifyApartmentGrid.Rows[0].Cells[1].Value.ToString();
                int newNoResidents = Convert.ToInt32(modifyApartmentGrid.Rows[0].Cells[2].Value.ToString());
                int newSurface = Convert.ToInt32(modifyApartmentGrid.Rows[0].Cells[3].Value.ToString());

                Apartment oldApartment = new Apartment(oldNoApartment, oldOwner, oldNoResidents, oldSurface);
                Apartment newApartment = new Apartment(newNoApartment, newOwner, newNoResidents, newSurface);

                this.service.updateApartment(oldApartment, newApartment);

                errorMessageLabel.Text = "Apartamentul a fost modificat.";
                errorMessageLabel.ForeColor = Color.DarkGreen;

            } catch (ArgumentException) {
                errorMessageLabel.Text = "";
                errorMessageLabel.ForeColor = Color.DarkRed;
                foreach(String error in errorMessage) {
                    errorMessageLabel.Text += error;
                }
            }
        }


        private List<String> validateAllInput() {
            /// <summary>
            /// Model binding and validation to apartment
            /// </summary>
            /// <returns>Error list</returns>
            
            List<String> errorMessage = new List<String>();
            if (apartmentsGridView.SelectedRows.Count == 0)
                errorMessage.Add("Selectati mai intai apartamentul. ");
            else {
                String noApartment = modifyApartmentGrid.Rows[0].Cells[0].Value.ToString();
                String owner = modifyApartmentGrid.Rows[0].Cells[1].Value.ToString();
                String noResidents = modifyApartmentGrid.Rows[0].Cells[2].Value.ToString();
                String surface = modifyApartmentGrid.Rows[0].Cells[3].Value.ToString();

                //Verificare numar apartament
                if (!Regex.IsMatch(noApartment, @"^\d+$") || noApartment.Length == 0) {
                    errorMessage.Add("Numarul apartamentului este invalid. ");
                } else if (this.service.getNoApartments().Contains(Convert.ToInt32(noApartment)) && !noApartment.Equals(apartmentsGridView.SelectedRows[0].Cells[0].Value.ToString()))
                    errorMessage.Add("Un apartament cu acel numar exista deja. ");

                //Verificare persoana
                List<String> personNames = new List<String>();
                foreach (Person person in this.service.getPeople()) {
                    personNames.Add(person.getFullName("FS"));
                }
                if (!personNames.Contains(owner))
                    errorMessage.Add("Persoana nu exista.");

                //Verificare numar locatar
                if (!Regex.IsMatch(noResidents, @"^\d+$") || noResidents.Length == 0) {
                    errorMessage.Add("Numarul locatarilor este invalid. ");
                } else if (noResidents != apartmentsGridView.SelectedRows[0].Cells[2].Value.ToString()) {
                    errorMessage.Add("Nu puteti modifica numarul de locatari. ");
                }

                //Verificare suprafata
                if (!Regex.IsMatch(surface, @"^\d+$") || surface.Length == 0) {
                    errorMessage.Add("Suprafata este invalida. ");
                } else if (Convert.ToInt32(surface) <= 0) {
                    errorMessage.Add("Suprafata trebuie sa fie mai mare decat zero. ");
                }
            }
            return errorMessage;
        }


        private void cancelButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for cancel button event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            this.Close();
        }

        private void apartmentsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            /// <summary>
            /// Handler for apartmentsGridView cell click
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            
            modifyApartmentGrid.Rows.Clear();
            modifyApartmentGrid.Rows.Add();
            modifyApartmentGrid.Rows[0].Cells[0].Value = apartmentsGridView.SelectedRows[0].Cells[0].Value.ToString();
            modifyApartmentGrid.Rows[0].Cells[1].Value = apartmentsGridView.SelectedRows[0].Cells[1].Value.ToString();
            modifyApartmentGrid.Rows[0].Cells[2].Value = apartmentsGridView.SelectedRows[0].Cells[2].Value.ToString();
            modifyApartmentGrid.Rows[0].Cells[3].Value = apartmentsGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
