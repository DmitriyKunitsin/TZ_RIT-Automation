using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIT_Automation
{
    internal class ApplicationConntext : DbContext
    {
        public SqlConnection myConnection;
        DbSet<Markers> markers { get; set; }
        public ApplicationConntext()
        {
            myConnection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=RIT;Trusted_Connection=True;");
        
        }
        public void OpenConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
                Console.WriteLine("Подключение открыто");
            }
        }
        public void CloseConnection() {
        if(myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
                Console.WriteLine("Подключение закрыто");
            }
        }
        
    }
}
