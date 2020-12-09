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
    public partial class MonthlyPaymentsForm : Form
    {
        private Service service;


        public MonthlyPaymentsForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }

        private void MonthlyPaymentsForm_Load(object sender, EventArgs e) {
            /// <summary>
            /// Handler for Form Load event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            initializeMonthCombobox();
        }


        private void initializeMonthCombobox() {
            /// <summary>
            /// Initializator for ComboBox containing months
            /// </summary>

            monthsCombobox.Items.Add("Ianuarie");
            monthsCombobox.Items.Add("Februarie");
            monthsCombobox.Items.Add("Martie");
            monthsCombobox.Items.Add("Aprilie");
            monthsCombobox.Items.Add("Mai");
            monthsCombobox.Items.Add("Iunie");
            monthsCombobox.Items.Add("Iulie");
            monthsCombobox.Items.Add("August");
            monthsCombobox.Items.Add("Septembrie");
            monthsCombobox.Items.Add("Octombrie");
            monthsCombobox.Items.Add("Noiembrie");
            monthsCombobox.Items.Add("Decembrie");
        }


        private void monthsCombobox_SelectedIndexChanged(object sender, EventArgs e) {
            /// <summary>
            /// Handler for monthsCombobox index update
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            List<Apartment> apartments = new List<Apartment>(this.service.getApartments());
            int month = monthsCombobox.SelectedIndex;
            monthlyPaymentsGridView.Rows.Clear();
            foreach (Apartment apartment in apartments) {
                if (apartment.owner != "fara") {
                    MonthlyPayment monthlyPayment = this.service.getMonthlyPayment(apartment);

                    //Preluare dictionar cu categorie taxa (key) si valoare plata (value)
                    Dictionary<String, int> paymentDict = new Dictionary<String, int>(monthlyPayment.getMonthlyPayment(month));

                    //Introducere date in tabel
                    monthlyPaymentsGridView.Rows.Add(
                        apartment.noApartment,
                        apartment.owner,
                        paymentDict["Gas"],
                        paymentDict["Maintenance & water"],
                        paymentDict["Electricity"],
                        paymentDict["Internet"],
                        paymentDict["Total"]);
                }
            }
        }
    }
}
