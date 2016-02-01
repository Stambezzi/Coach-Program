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
    public partial class Add_Client : Form
    {
        public delegate void userAddedHandler();

        public event userAddedHandler userAdded; 

        private DateTime dateSelected = new DateTime();
        private DBconnect cnn;

        public Add_Client()
        {
            InitializeComponent();

            cnn = new DBconnect();
        }

        private void dateSelectedFunc(object sender, DateRangeEventArgs e)
        {
            string insertText;
            dateSelected = monthCalendar.SelectionRange.Start;
            insertText = dateSelected.Day + "." + dateSelected.Month + "." + dateSelected.Year;
            txtBoxInsertDate.Text = insertText;
        }

        private void AddClientFunc(object sender, EventArgs e)
        {
            string date = dateSelected.Year +"-"+ dateSelected.Month +"-"+ dateSelected.Day;
            string cycLength = txtBoxInsertCycle.Text;
            int len;
            if(txtBoxInsertName.Text != "" && txtBoxInsertDate.Text != "")
            {
                try
                {
                    len= Convert.ToInt32(cycLength);
                    cnn.Insert(txtBoxInsertName.Text, date, len);
                    userAdded();
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
    }
}
