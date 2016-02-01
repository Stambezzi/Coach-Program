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
    public partial class Delete_User : Form
    {
        public delegate void userDeletedHandler();

        public event userDeletedHandler userDeleted;

        private DBconnect cnn;
        private int id;
        public Delete_User()
        {
            InitializeComponent();

            cnn = new DBconnect();
            id = 999999;
        }

        public Delete_User(int idToDelete)
        {
            InitializeComponent();

            cnn = new DBconnect();
            id = idToDelete;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            cnn.Delete(id);
            userDeleted();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
