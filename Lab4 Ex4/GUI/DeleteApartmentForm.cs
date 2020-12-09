using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ex4.GUI
{
    public partial class DeleteApartmentForm : Form
    {
        private Service service;

        public DeleteApartmentForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }


        private void deleteButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for delete button event
            /// </summary>

            try {
                int index = deleteApartmentGrid.CurrentCell.RowIndex;

                int noApartment = Convert.ToInt32(deleteApartmentGrid.Rows[index].Cells[0].Value.ToString());
                String owner = deleteApartmentGrid.Rows[index].Cells[1].Value.ToString();
                int noResidents = Convert.ToInt32(deleteApartmentGrid.Rows[index].Cells[2].Value.ToString());
                int surface = Convert.ToInt32(deleteApartmentGrid.Rows[index].Cells[3].Value.ToString());

                Apartment apartment = new Apartment(noApartment, owner, noResidents, surface);
                this.service.delete(apartment);

                errorMessageLabel.Text = "Apartamentul a fost sters.";
                errorMessageLabel.ForeColor = Color.DarkGreen;

                warningLabel.Text = "Atentie! Locatarii acelui apartament au fost stersi.";
                warningLabel.ForeColor = Color.DarkOrange;
            } catch (Exception) {
                errorMessageLabel.Text = "Selectati mai intai apartamentul. ";
                errorMessageLabel.ForeColor = Color.DarkRed;
                warningLabel.Text = "";
            }
        }


        private void apartmentInfoTextbox_TextChanged(object sender, EventArgs e) {
            /// <summary>
            /// Handler for apartmentInfoTextbox text update
            /// </summary>

            deleteApartmentGrid.Rows.Clear();
            List<Apartment> apartments = new List<Apartment>(this.service.getApartments());
            foreach (Apartment apartment in apartments) {
                if (apartment.noApartment.ToString() == apartmentInfoTextbox.Text || apartment.owner.ToLower().Contains(apartmentInfoTextbox.Text.ToLower())) {
                    deleteApartmentGrid.Rows.Add(apartment.noApartment, apartment.owner, apartment.noResidents, apartment.surface);
                }
            }
        }


        private void cancelButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for cancel button event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            this.Close();
        }
    }
}
