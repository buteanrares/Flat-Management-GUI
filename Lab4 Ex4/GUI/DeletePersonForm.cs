using Lab4_Ex4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ex4.GUI
{
    public partial class DeletePersonForm : Form
    {
        private Service service;

        public DeletePersonForm(Service service) {
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
            /// <param name="sender"></param>
            /// <param name="e"></param>

            try {
                int index = deletePersonGrid.CurrentCell.RowIndex;

                String surname = deletePersonGrid.Rows[index].Cells[0].Value.ToString();
                String forename = deletePersonGrid.Rows[index].Cells[1].Value.ToString();
                int noApartment = Convert.ToInt32(deletePersonGrid.Rows[index].Cells[2].Value.ToString());
                String birthdate = deletePersonGrid.Rows[index].Cells[3].Value.ToString();
                String job = deletePersonGrid.Rows[index].Cells[4].Value.ToString();

                Person person = new Person(forename, surname, noApartment, birthdate, job);
                this.service.delete(person);

                errorMessageLabel.Text = "Persoana a fost stearsa.";
                errorMessageLabel.ForeColor = Color.DarkGreen;
            } catch (Exception) {
                errorMessageLabel.Text = "Selectati mai intai persoana. ";
                errorMessageLabel.ForeColor = Color.DarkRed;
            }
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e) {
            /// <summary>
            /// Handler for nameTextbox text update
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            
            errorMessageLabel.Text = "";
            deletePersonGrid.Rows.Clear();
            List<Person> people = new List<Person>(this.service.getPeople());
            foreach (Person person in people) {
                if (person.getFullName().ToLower().Contains(nameTextbox.Text.ToLower()))
                    deletePersonGrid.Rows.Add(person.surname, person.forename, person.noApartment, person.birthdate, person.job);
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
