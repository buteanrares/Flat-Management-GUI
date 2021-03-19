using Lab4_Ex4.GUI;
using System;
using System.IO;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ex4
{
    public partial class MainGUI : Form
    {
        public Service service;

        public MainGUI(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>
            
            this.service = service;
            InitializeComponent();
        }


        private void butonAddPerson_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for AddPersonForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var addPersonForm = new AddPersonForm(service);
            addPersonForm.Show();
        }


        private void buttonAddApartment_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for AddApartmentForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            
            var addApartmentForm = new AddApartmentForm(service);
            addApartmentForm.Show();
        }


        private void showPeopleButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for ShowPeopleForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var showPeopleForm = new ShowPeopleForm(service);
            showPeopleForm.Show();
        }


        private void showApartmentsButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for ShowApartmentsForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var showApartmentsForm = new ShowApartmentsForm(service);
            showApartmentsForm.Show();
        }


        private void buttonMonthlyPayments_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for MonthlyPaymentsForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var monthlyPaymentsForm = new MonthlyPaymentsForm(service);
            monthlyPaymentsForm.Show();
        }


        private void modifyPersonButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for ModifyPersonForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var modifyPersonForm = new ModifyPersonForm(service);
            modifyPersonForm.Show();
        }


        private void modifyApartmentButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for ModifyApartmentForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var modifyApartmentForm = new ModifyApartmentForm(service);
            modifyApartmentForm.Show();
        }


        private void deletePersonButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for DeletePersonForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var deletePersonForm = new DeletePersonForm(service);
            deletePersonForm.Show();
        }


        private void deleteApartmentButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for DeleteApartmentForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var deleteApartmentForm = new DeleteApartmentForm(service);
            deleteApartmentForm.Show();
        }


        private void showEventsButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler and form creator for ShowEventsForm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            var showEventsForm = new ShowEventsForm(service);
            showEventsForm.Show();
        }

        private void setDBbutton_Click(object sender, EventArgs e)
        {
            String exitMessage = this.service.selectDB(this.folderBrowserDialog);
            System.Windows.Forms.MessageBox.Show(exitMessage);

        }
    }
}
