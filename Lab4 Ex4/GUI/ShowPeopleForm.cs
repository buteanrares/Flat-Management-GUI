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
    public partial class ShowPeopleForm : Form
    {
        private Service service;

        public ShowPeopleForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }


        private void ShowPeopleForm_Load(object sender, EventArgs e) {
            /// <summary>
            /// Handler for Form Load event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
             
            handleLoadPeople();
        }


        private void handleLoadPeople() {
            /// <summary>
            /// Handler for people load into People DataGridView
            /// </summary>

            List<Person> people = new List<Person>(this.service.getPeople());
            foreach(Person person in people) {
                peopleGridView.Rows.Add(person.surname, person.forename, person.noApartment, person.birthdate, person.job);
            }
        }


        private void nameTextbox_TextChanged(object sender, EventArgs e) {
            /// <summary>
            /// Handler for nameTextbox text update event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            peopleGridView.Rows.Clear();
            List<Person> people = new List<Person>(this.service.getPeople());
            foreach (Person person in people) {
                if (person.getFullName().ToLower().Contains(nameTextbox.Text.ToLower()))
                    peopleGridView.Rows.Add(person.surname, person.forename, person.noApartment, person.birthdate, person.job);
            }
        }
    }
}
