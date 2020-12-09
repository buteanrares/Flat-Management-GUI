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
    public partial class ShowApartmentsForm : Form
    {
        private Service service;

        public ShowApartmentsForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }


        private void ShowApartmentsForm_Load(object sender, EventArgs e) {
            /// <summary>
            /// Handler for Form Load event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            handleShowApartments();
        }


        private void handleShowApartments() {
            /// <summary>
            /// Handler for apartment display
            /// </summary>

            List<Apartment> apartments = new List<Apartment>(this.service.getApartments());
            foreach(Apartment apartment in apartments) {
                apartmentsGridView.Rows.Add(apartment.noApartment, apartment.owner, apartment.noResidents, apartment.surface);
            }
        }


        private void apartmentInfoTextbox_TextChanged(object sender, EventArgs e) {
            /// <summary>
            /// Handler for apartmentInfoTextbox text update
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            apartmentsGridView.Rows.Clear();
            List<Apartment> apartments = new List<Apartment>(this.service.getApartments());
            foreach(Apartment apartment in apartments) {
                if(apartment.noApartment.ToString() == apartmentInfoTextbox.Text || apartment.owner.ToLower().Contains(apartmentInfoTextbox.Text.ToLower())) {
                    apartmentsGridView.Rows.Add(apartment.noApartment, apartment.owner, apartment.noResidents, apartment.surface);
                }
            }
        }
    }
}
