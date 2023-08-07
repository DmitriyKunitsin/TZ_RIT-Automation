using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RIT_Automation
{
    internal class DataBase : DataSet
    {
        public static void Created_Data_Table_Markers()
        { //Создание БД
            ApplicationConntext conn = new ApplicationConntext();
            string comandCreat_Markers = "CREATE TABLE Markers " +
                "(Id INTEGER NOT NULL IDENTITY(1, 1), " +
                "Lat REAL," +
                "Lng REAL, " +
                "Text VARCHAR(50)," +
                "PRIMARY KEY (ID) )";
            
            SqlCommand command = new SqlCommand(comandCreat_Markers, conn.myConnection);

            conn.myConnection.Open();
            command.ExecuteNonQuery();
            conn.myConnection.Close();
        }
        public static void Insert_Markers_in_DataBase(double lat, double lng , string text)
        {// Добавление в бд координат маркера
            ApplicationConntext conn = new ApplicationConntext();
            conn.OpenConnection();
            string add_table = @"INSERT INTO dbo.Markers" +
                " VALUES (@Lat, @Lng, @Text)";
            SqlCommand myCommand = new SqlCommand(add_table, conn.myConnection);
            myCommand.Parameters.AddWithValue("@Lat", lat);
            myCommand.Parameters.AddWithValue("@Lng", lng);
            myCommand.Parameters.AddWithValue("@Text", text);
            myCommand.ExecuteNonQuery();
            conn.CloseConnection();
        }
        public static List<Markers> Search_LatLng_Markers(double Lat, double Lng)
        {// Изменение координат выбранного маркера
            ApplicationConntext conn = new ApplicationConntext(); 
            conn.OpenConnection();
            // Исправляю запяиую на точку, ругается T-SQL
            string textLat = Convert.ToString(Lat);
            string textLng = Convert.ToString(Lng);
            textLat = textLat.Replace(",",".");
            textLng = textLng.Replace(",",".");
            SqlDataReader reader = null;
            string use_Marker = $"SELECT * FROM Markers" +
                $" WHERE Lat={textLat} AND Lng={textLng}";
            SqlCommand command = new SqlCommand(use_Marker, conn.myConnection);
            // Выгрузка в ридер запроса
            List<Markers> mark= new List<Markers>();
            reader = command.ExecuteReader();
            while (reader.Read()) 
            {// Добавение в Лист нужного маркера
                mark.Add(new Markers 
                {
                    Id = reader.GetInt32(0),
                    lat= Convert.ToDouble(reader.GetFloat(1)),
                    lng= Convert.ToDouble(reader.GetFloat(2)),
                    text= reader.GetString(3)
                });
            }
            conn.CloseConnection();
            return mark;
        }
        public static void Chancge_LatLng_Marker(int id, double Lat, double Lng)
        {
            ApplicationConntext conn = new ApplicationConntext(); 
            conn.OpenConnection();
            // Исправляю запяиую на точку, ругается T-SQL
            string textLat = Convert.ToString(Lat);
            string textLng = Convert.ToString(Lng);
            textLat = textLat.Replace(",", ".");
            textLng = textLng.Replace(",", ".");
            // Исправление координат нужного маркера
            string update_Marker = $"UPDATE Markers SET Lat={textLat} , Lng={textLng} WHERE Id={id}";
            SqlCommand command = new SqlCommand(update_Marker, conn.myConnection); 
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }
        public static void Deleted_Selected_Marker( List<Markers> mark)
        {
            int id = 0;
            foreach (Markers m in mark)
            {
                id = m.Id;
                break;
            }
            ApplicationConntext conn = new ApplicationConntext();
            conn.OpenConnection();
            string deletedMarker = $"DELETE Markers WHERE Id={id}";
            SqlCommand command = new SqlCommand(deletedMarker, conn.myConnection);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        } 
        public static IList<Markers> Unload_Existing_Markers()
        {
            // Выгрузка данных обо всех маркерах в бд
            ApplicationConntext conn = new ApplicationConntext();
            conn.OpenConnection();
            SqlDataReader reader = null;
            string unload_marker = "SELECT * FROM Markers";
            SqlCommand command = new SqlCommand(unload_marker, conn.myConnection);
            
            reader = command.ExecuteReader();
            List<Markers> mark = new List<Markers>();
            while (reader.Read())
            {
                mark.Add(new Markers() 
                { 
                    lat = Convert.ToDouble(reader.GetFloat(1)),
                    lng = Convert.ToDouble(reader.GetFloat(2)),
                    text = reader.GetString(3)
                });
            }
            conn.CloseConnection() ;
            return mark;
        }
    }
}
