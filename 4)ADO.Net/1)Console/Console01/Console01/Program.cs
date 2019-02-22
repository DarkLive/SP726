using System;
using System.Data.SqlClient;

namespace Console01 {
   class Program {
      static void Main(string[] args) {
         //SqlConnection connection_Okul_VT = new SqlConnection();
         //connection_Okul_VT.ConnectionString = @"Server=localhost; Database=Okul_VT; User ID=sa; Password=1234;";
         //connection_Okul_VT.Open();
         //SqlCommand command1 = new SqlCommand();
         //command1.CommandText = "SELECT * FROM Ogretmenler"; command1.Connection = connection_Okul_VT;

         //SqlDataReader SqlReader1 = command1.ExecuteReader();
         //while ( SqlReader1.Read() ) {
         //   Console.WriteLine(SqlReader1[0] + " | " + SqlReader1["OgretmenAdi"] + " | " + SqlReader1[2]);
         //}
         //SqlReader1.Close();

         //SqlCommand command2 = new SqlCommand();
         //command2.Connection = connection_Okul_VT; command2.CommandText = "INSERT INTO Ogretmenler (OgretmenAdi) VALUES('Hasan KOYUNCU')";
         //command2.ExecuteNonQuery();

         //connection_Okul_VT.Close();

         Staff sta = new Staff();
         //sta.AddStaff();
         //sta.RemoveStaff();
         sta.ListStaff();

         Console.ReadKey();
      }

      class Staff {
         protected string StaffName, StaffSurname, StaffID; protected DateTime StaffStartDate;

         public void AddStaff() {
            SqlConnection SqlConnection01 = new SqlConnection();
            SqlConnection01.ConnectionString = @"Server=localhost; Database=egeturan; User ID=sa; Password=1234;";
            SqlCommand SqlCommand01 = new SqlCommand(); SqlCommand01.Connection = SqlConnection01;
            Console.Write("Please enter staff name: ");
            StaffName = Console.ReadLine();
            Console.Write("Please enter staff surname: ");
            StaffSurname = Console.ReadLine();
            Console.Write("Please enter staff start date: ");
            try { StaffStartDate = DateTime.Parse(Console.ReadLine()); } catch { StaffStartDate = DateTime.Today; }
            SqlCommand01.CommandText = $"INSERT INTO Staff VALUES ('{StaffName}','{StaffSurname}','{StaffStartDate.ToString("yyyy-MM-dd")}',1)";
            SqlConnection01.Open(); SqlCommand01.ExecuteNonQuery(); SqlConnection01.Close();
         }
         public void RemoveStaff() {
            SqlConnection SqlConnection01 = new SqlConnection();
            SqlConnection01.ConnectionString = @"Server=localhost; Database=egeturan; User ID=sa; Password=1234;";
            SqlCommand SqlCommand01 = new SqlCommand(); SqlCommand01.Connection = SqlConnection01;
            Console.Write("Please enter staff id: ");
            StaffID = Console.ReadLine();
            SqlCommand01.CommandText = $"UPDATE Staff SET StaffActive = 0 WHERE StaffID = {StaffID}";
            SqlConnection01.Open(); SqlCommand01.ExecuteNonQuery(); SqlConnection01.Close();
         }
         public void ListStaff() {
            SqlConnection SqlConnection01 = new SqlConnection();
            SqlConnection01.ConnectionString = @"Server=localhost; Database=egeturan; User ID=sa; Password=1234;";
            SqlCommand SqlCommand01 = new SqlCommand(); SqlCommand01.Connection = SqlConnection01;
            SqlCommand01.CommandText = "SELECT * FROM Staff";
            SqlConnection01.Open();
            SqlDataReader SqlDataReader01 = SqlCommand01.ExecuteReader();
            while ( SqlDataReader01.Read() ) {
               if ( (bool)SqlDataReader01[4] == true )
                  Console.WriteLine($"ID: {SqlDataReader01[0].ToString().PadRight(3)}|  Name: {SqlDataReader01[1].ToString().PadRight(15)} | Surname: {SqlDataReader01[2].ToString().PadRight(15)} | StartDate: {( (DateTime)SqlDataReader01[3] ).ToString("yyyy-MM-dd")}");
            }
            SqlDataReader01.Close(); SqlConnection01.Close();
         }
      }
   }
}

