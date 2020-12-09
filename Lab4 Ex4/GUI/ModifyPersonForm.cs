using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq.Expressions;
using Lab4_Ex4.Validator;

namespace Lab4_Ex4.GUI
{
    public partial class ModifyPersonForm : Form
    {
        private Service service;


        public ModifyPersonForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }


        private void nameTextbox_TextChanged(object sender, EventArgs e) {
            /// <summary>
            /// Handler for nameTextbox text update event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            searchedPersonGrid.Rows.Clear();
            List<Person> people = new List<Person>(this.service.getPeople());
            foreach (Person person in people) {
                if (person.getFullName().ToLower().Contains(nameTextbox.Text.ToLower()))
                    searchedPersonGrid.Rows.Add(person.surname, person.forename, person.noApartment, person.birthdate, person.job);
            }
        }


        private void searchedPersonGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            /// <summary>
            /// Handler for searchedPersonGrid cell click event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            modifyPersonGrid.Rows.Clear();
            modifyPersonGrid.Rows.Add();
            modifyPersonGrid.Rows[0].Cells[0].Value = searchedPersonGrid.SelectedRows[0].Cells[0].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[1].Value = searchedPersonGrid.SelectedRows[0].Cells[1].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[2].Value = searchedPersonGrid.SelectedRows[0].Cells[2].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[3].Value = searchedPersonGrid.SelectedRows[0].Cells[3].Value.ToString();
            modifyPersonGrid.Rows[0].Cells[4].Value = searchedPersonGrid.SelectedRows[0].Cells[4].Value.ToString();
        }


        private void cancelButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for cancel button event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            this.Close();
        }


        private void applyButton_Click(object sender, EventArgs e) {
            /// <summary>
            /// Handler for apply button event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            handleModifyPerson();
        }


        private void handleModifyPerson() {
            /// <summary>
            /// Handler for person modify
            /// </summary>

            ModelValidator modelValidator = new ModelValidator(this.service);
            List<String> errorMessage = new List<String>();

            errorMessage.AddRange(modelValidator.validatePerson(searchedPersonGrid, modifyPersonGrid));

            try {
                if (errorMessage.Count != 0) {
                    throw new ArgumentException();
                }
                int index = searchedPersonGrid.CurrentCell.RowIndex;

                String oldSurname = searchedPersonGrid.Rows[index].Cells[0].Value.ToString();
                String oldForename = searchedPersonGrid.Rows[index].Cells[1].Value.ToString();
                int oldNoApartment = Convert.ToInt32(searchedPersonGrid.Rows[index].Cells[2].Value.ToString());
                String oldBirthdate = searchedPersonGrid.Rows[index].Cells[3].Value.ToString();
                String oldJob= searchedPersonGrid.Rows[index].Cells[4].Value.ToString();

                String newSurname = modifyPersonGrid.Rows[0].Cells[0].Value.ToString();
                String newForename = modifyPersonGrid.Rows[0].Cells[1].Value.ToString();
                int newNoApartment = Convert.ToInt32(modifyPersonGrid.Rows[0].Cells[2].Value.ToString());
                String newBirthdate = modifyPersonGrid.Rows[0].Cells[3].Value.ToString();
                String newJob = modifyPersonGrid.Rows[0].Cells[4].Value.ToString();

                Person oldPerson = new Person(oldForename, oldSurname, oldNoApartment, oldBirthdate, oldJob);
                Person newPerson = new Person(newForename, newSurname, newNoApartment, newBirthdate, newJob);

                this.service.updatePerson(oldPerson,newPerson);

                errorMessageLabel.Text = "Persoana a fost modificata.";
                errorMessageLabel.ForeColor = Color.DarkGreen;
            } catch (ArgumentException) {
                errorMessageLabel.Text = "";
                errorMessageLabel.ForeColor = Color.DarkRed;
                foreach (String error in errorMessage) {
                    errorMessageLabel.Text += error;
                }
            } catch (Exception) {
                errorMessageLabel.Text = "Alegeti persoana de modificat.";
                errorMessageLabel.ForeColor = Color.DarkRed;
            }
        }
    }
}
