using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DataAccessLayer;
using System.Text.RegularExpressions;

namespace Coach_Program
{
    public partial class Form1 : Form
    {      
        private DBconnect cnn;
        
        public Form1()
        {
            InitializeComponent();
            cnn = new DBconnect();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("420","About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Client frm = new Add_Client();
            frm.userAdded += new Add_Client.userAddedHandler(refresh);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Client> list = new List<Client>();
            list = cnn.Select();
            foreach (Client cli in list)
            {
                cli.calculateCurrentWeek(DateTime.Now);
            }
            dataGridClients.DataSource = list;

            if (list.Count != 0)
            {
                int id = (Int32)dataGridClients.Rows[0].Cells[0].Value;

                Client clie = new Client();
                clie = cnn.SelectId(id);

                mpK_Calendar.SelectedDate = DateTime.Now;
                mpK_Calendar.StartingDateClient = clie.DateStarted;
                mpK_Calendar.CycleLength = clie.CycleLength;
                mpK_Calendar.Refresh();
            }
            else
            {
                mpK_Calendar.SelectedDate = DateTime.Now;
            }
        }
        public void refresh()
        {
            int value;
            List<Client> list = new List<Client>();
            if (int.TryParse(searchBox.Text, out value))
            {
                List<Client> filterList = new List<Client>();
                list = cnn.Select();
                foreach (Client cli in list)
                {
                    cli.calculateCurrentWeek(DateTime.Now);
                    if (cli.CurrentWeek == value) filterList.Add(cli);
                }
                dataGridClients.DataSource = filterList;
            }
            else
            {
                list = cnn.SelectWithCond(searchBox.Text);
                foreach (Client cli in list)
                {
                    cli.calculateCurrentWeek(DateTime.Now);
                }
                dataGridClients.DataSource = list;
            }
        }

        private void dataGridViewBinding(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridClients.Columns["ClientId"].Visible = false;
            this.dataGridClients.Columns["DateStarted"].Visible = false;
            foreach (DataGridViewRow row in dataGridClients.Rows)
            {
                if ((Int32)row.Cells[4].Value == 1) row.DefaultCellStyle.BackColor = Color.Red;
                else if ((Int32)row.Cells[4].Value == 2) row.DefaultCellStyle.BackColor = Color.Green;
                else if ((Int32)row.Cells[4].Value == 3) row.DefaultCellStyle.BackColor = Color.Blue;
                else if ((Int32)row.Cells[4].Value == 4) row.DefaultCellStyle.BackColor = Color.Yellow;
                else if ((Int32)row.Cells[4].Value == 5) row.DefaultCellStyle.BackColor = Color.Pink;
                else if ((Int32)row.Cells[4].Value == 6) row.DefaultCellStyle.BackColor = Color.Orange;
                else if ((Int32)row.Cells[4].Value == 7) row.DefaultCellStyle.BackColor = Color.LightBlue;
                else if ((Int32)row.Cells[4].Value == 8) row.DefaultCellStyle.BackColor = Color.White;
            } 
        }

        private void dataGridClients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            switch ((Int32)e.ColumnIndex)
            { 
                case 1:
                    if (dataGridClients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        DateTime dateStarted = (DateTime)dataGridClients.Rows[e.RowIndex].Cells[2].Value;
                        string date = dateStarted.Year + "-" + dateStarted.Month + "-" + dateStarted.Day;
                        string name = dataGridClients.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int id = (Int32)dataGridClients.Rows[e.RowIndex].Cells[0].Value;
                        int cyc = (Int32)dataGridClients.Rows[e.RowIndex].Cells[3].Value;
                        cnn.Update(id, name, date, cyc);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Field cannot be empty!", "Error");
                        refresh();
                    }
                    break;
                case 3:
                    if (checkForCorrectInput(e))
                    {
                        DateTime dateStarted = (DateTime)dataGridClients.Rows[e.RowIndex].Cells[2].Value;
                        string date = dateStarted.Year + "-" + dateStarted.Month + "-" + dateStarted.Day;
                        string name = dataGridClients.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int id = (Int32)dataGridClients.Rows[e.RowIndex].Cells[0].Value;
                        int cyc = (Int32)dataGridClients.Rows[e.RowIndex].Cells[3].Value;
                        cnn.Update(id, name, date, cyc);
                        refresh();
                    }
                    break;
                case 4:
                    if (checkForCorrectInput(e))
                    {                      
                        DateTime dateStarted = new DateTime();                
                        dateStarted = calculateNewStartingDate((Int32)dataGridClients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        string date = dateStarted.Year + "-" + dateStarted.Month + "-" + dateStarted.Day;
                        string name = dataGridClients.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int id = (Int32)dataGridClients.Rows[e.RowIndex].Cells[0].Value;
                        int cyc = (Int32)dataGridClients.Rows[e.RowIndex].Cells[3].Value;
                        cnn.Update(id, name, date, cyc);
                        refresh();
                    }
                    break;
            } 
        }
        private bool checkForCorrectInput(DataGridViewCellEventArgs e)
        {
            int value;
            if (int.TryParse(dataGridClients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value)) return true;
            return false;

        }
        private DateTime calculateNewStartingDate(int newWeek)
        {
            newWeek = (newWeek - 1) * 7; 
            DateTime today = DateTime.Today;
            today = today.AddDays(-1 * newWeek);
            return today;
        }
        private void dataGridClients_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
                int pos = dataGridClients.HitTest(e.X, e.Y).RowIndex;

                if(pos >= 0)
                {
                    //rightClickMenu.Items.Add("Delete User");
                    //rightClickMenu.Items.Add("Update User");
                    dataGridClients.ClearSelection();
                    dataGridClients.Rows[pos].Selected = true;
                }

                rightClickMenu.Show(dataGridClients, new Point(e.X, e.Y));
            }
            else
            {
                dataGridClients.ContextMenuStrip = null;
            }
        }

        private void dataGridClients_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Field should be filled with positive integer!", "Error");
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            List<Client> list = new List<Client>();
            if (int.TryParse(searchBox.Text, out value))
            {
                List<Client> filterList = new List<Client>();
                list = cnn.Select();
                foreach (Client cli in list)
                {
                    cli.calculateCurrentWeek(DateTime.Now);
                    if (cli.CurrentWeek == value) filterList.Add(cli);
                }
                dataGridClients.DataSource = filterList;
            }
            else
            {
                list = cnn.SelectWithCond(searchBox.Text);
                foreach (Client cli in list)
                {
                    cli.calculateCurrentWeek(DateTime.Now);
                }
                dataGridClients.DataSource = list;
            }
        }

        private void rightClickMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Equals(delete))
            {
                int rowToDelete = dataGridClients.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int idToDelete = (Int32)dataGridClients.Rows[rowToDelete].Cells[0].Value;
                Delete_User frm = new Delete_User(idToDelete);
                frm.userDeleted += new Delete_User.userDeletedHandler(refresh);
                frm.Show();
            }
            if(e.ClickedItem.Equals(update))
            {
                int rowToUpdate = dataGridClients.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int idToUpdate = (Int32)dataGridClients.Rows[rowToUpdate].Cells[0].Value;
                string name = dataGridClients.Rows[rowToUpdate].Cells[1].Value.ToString();
                string date = dataGridClients.Rows[rowToUpdate].Cells[2].Value.ToString();
                int cyc = (Int32)dataGridClients.Rows[rowToUpdate].Cells[3].Value;
                Update_User frm = new Update_User(idToUpdate, name, date, cyc);
                frm.userUpdated += new Update_User.userUpdatedHandler(refresh);
                frm.Show();
            }
        }

        private void dataGridClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int rowClicked = e.RowIndex;
                int id = (Int32)dataGridClients.Rows[rowClicked].Cells[0].Value;

                Client cli = new Client();
                cli = cnn.SelectId(id);

                mpK_Calendar.SelectedDate = DateTime.Now;
                mpK_Calendar.StartingDateClient = cli.DateStarted;
                mpK_Calendar.CycleLength = cli.CycleLength;
                mpK_Calendar.Refresh();
            }
        }
    }
}
