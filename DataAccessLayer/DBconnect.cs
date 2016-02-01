using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DBconnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBconnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "clientsdb";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Database=" + database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string name, string startingDate, int cycleLength)
        {
            string query = "INSERT INTO clients (clientName, startingDate, cycleLength) VALUES ('" + name + "','" + startingDate + "','" + cycleLength + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(int id, string name, string date, int cycleLength)
        {
            string query = "UPDATE clients SET clientName = '" + name + "', startingDate='"+ date +"',cycleLength='"+cycleLength+"' WHERE idClients = '"+ id +"'";

            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(int id)
        {
            string query = "DELETE FROM clients WHERE idClients = '" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<Client> Select()
        {
            string query = "SELECT * FROM clients";

            //Create a list to store the result
            List<Client> list = new List<Client>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    
                    Client row = new Client();
                    row.ClientId = (Int32)dataReader["idClients"];
                    row.ClientName = dataReader["clientName"].ToString();
                    row.DateStarted = (DateTime)dataReader["startingDate"];
                    row.CycleLength = (Int32)dataReader["cycleLength"];
                    list.Add(row);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Select statement with condition
        public List<Client> SelectWithCond(string name)
        {            
            string query = "SELECT * FROM clients WHERE clientName LIKE'%" + name + "%';";
            
            //Create a list to store the result
            List<Client> list = new List<Client>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    Client row = new Client();
                    row.ClientId = (Int32)dataReader["idClients"];
                    row.ClientName = dataReader["clientName"].ToString();
                    row.DateStarted = (DateTime)dataReader["startingDate"];
                    row.CycleLength = (Int32)dataReader["cycleLength"];
                    list.Add(row);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public Client SelectId(int id)
        {
            string query = "SELECT * FROM clients WHERE idClients ='" + id + "';";

            //Create a list to store the result
            Client cli = new Client();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    //Client row = new Client();
                    cli.ClientId = (Int32)dataReader["idClients"];
                    cli.ClientName = dataReader["clientName"].ToString();
                    cli.DateStarted = (DateTime)dataReader["startingDate"];
                    cli.CycleLength = (Int32)dataReader["cycleLength"];
                    //list.Add(row);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return cli;
            }
            else
            {
                return cli;
            }
        }
        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}

