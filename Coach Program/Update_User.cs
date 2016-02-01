using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Coach_Program
{
    public partial class Update_User : Form
    {
        public delegate void userUpdatedHandler();

        public event userUpdatedHandler userUpdated;

        private DBconnect cnn;
        private DateTime dateSelected;
        private int id;
        private int cyc;
        private string name;
        private string date;

        public Update_User()
        {
            InitializeComponent();

            cnn = new DBconnect();
            dateSelected = new DateTime();
            id = 999999;
        }

        public Update_User(int idToUpdate, string _name, string _date, int _cyc)
        {
            name = _name;
            date = _date;
            cyc = _cyc;

            InitializeComponent();

            cnn = new DBconnect();
            dateSelected = new DateTime();
            id = idToUpdate;
        }
        private void brnUpdate_Click(object sender, EventArgs e)
        {
            string date = dateSelected.Year + "-" + dateSelected.Month + "-" + dateSelected.Day;
            string cycLength = txtBoxCycle.Text;
            int len;
            if (txtBoxName.Text != "" && txtBoxDate.Text != "")
            {
                try
                {
                    len = Convert.ToInt32(cycLength);
                    cnn.Update(id, txtBoxName.Text, date, len);
                    userUpdated();
                    this.Close();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error");
            }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            string insertText;
            dateSelected = monthCalendar.SelectionRange.Start;
            insertText = dateSelected.Day + "." + dateSelected.Month + "." + dateSelected.Year;
            txtBoxDate.Text = insertText;
        }
    }
}
