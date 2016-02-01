using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DataAccessLayer
{
    public class Client
    {
        private int clientId;     
        private string clientName;      
        private DateTime dateStarted;       
        private int cycleLength;
        private int currentWeek;
        
        public int ClientId { get { return clientId; } set { clientId = value; } }
        public string ClientName { get { return clientName; } set { clientName = value; } }
        public DateTime DateStarted { get { return dateStarted; } set { dateStarted = value; } }
        public int CycleLength { get { return cycleLength; } set { cycleLength = value; } }
        public int CurrentWeek { get { return currentWeek; } set { currentWeek = value; } }
        public Client()
        {

        }
        public Client(int id, string name, DateTime date, int length)
        {
            clientId = id;
            clientName = name;
            dateStarted = date;
            cycleLength = length;
        }

        public void calculateCurrentWeek(DateTime currentDate)
        {
            double daysPassedd;
            int daysPassed;
            daysPassedd = (currentDate - DateStarted).TotalDays;
            daysPassed = (Int32)daysPassedd;
            daysPassed = daysPassed % (CycleLength * 7);
            if (daysPassed < 7) CurrentWeek = 1;
            else if (daysPassed < 14) CurrentWeek = 2;
            else if (daysPassed < 21) CurrentWeek = 3;
            else if (daysPassed < 28) CurrentWeek = 4;
            else if (daysPassed < 35) CurrentWeek = 5;
            else if (daysPassed < 42) CurrentWeek = 6;
            else if (daysPassed < 49) CurrentWeek = 7;
            else if (daysPassed > 48) CurrentWeek = 8;
        } 
    }
}
