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
    public partial class ShowEventsForm : Form {
        private Service service;
        private int rowIndex=1;


        public ShowEventsForm(Service service) {
            /// <summary>
            /// Parameterized constructor
            /// </summary>
            /// <param name="service"></param>

            this.service = service;
            InitializeComponent();
        }


        private void ShowEventsForm_Load(object sender, EventArgs e) {
            /// <summary>
            /// Handler for Form Load event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            handleShowEvents();
        }


        private void handleShowEvents() {
            /// <summary>
            /// Handler for events display
            /// </summary>

            List<Person> people = new List<Person>(this.service.getPeople());
            List<Apartment> apartments = new List<Apartment>(this.service.getApartments());

            foreach (Person person in people) {
                String[] data = person.birthdate.Split('/');
                int day = Convert.ToInt32(data[0]);
                int month = Convert.ToInt32(data[1]);
                int year = Convert.ToInt32(data[2]);
                DateTime birthdateDT = new DateTime(year, month, day);
                if (birthdateDT.Day == DateTime.Now.Day && birthdateDT.Month == DateTime.Now.Month) {
                    dgvAddEvent(person.getFullName() + " implineste azi " + (DateTime.Now.Year - birthdateDT.Year).ToString() + " ani");
                }
                if ((DateTime.Now.Year - birthdateDT.Year) >= 18) {
                    dgvAddEvent(person.getFullName() + " este adult.");
                } else {
                    dgvAddEvent(person.getFullName() + " este minor.");
                }
                if (person.job == "pensionar") {
                    dgvAddEvent(person.getFullName() + " este pensionar.");
                }
            }

            foreach (Apartment apartment in apartments) {
                if (apartment.owner == "fara") {
                    dgvAddEvent("Apartamentul cu numarul " + apartment.noApartment.ToString() + " este de vanzare");
                }
            }
        }


        private void dgvAddEvent(String eventDescription){
            /// <summary>
            /// Handler for event add into the Events DataGridView
            /// </summary>
            /// <param name="eventDescription"></param>
            
            eventsDataGrid.Rows.Add(rowIndex++, eventDescription);
        }

    }
}
