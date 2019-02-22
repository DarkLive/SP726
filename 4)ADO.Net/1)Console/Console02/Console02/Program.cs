using System;
using System.Data.SqlClient;

namespace Console02 {
   class Program {
      static void Main(string[] args) {

         Toshiba tsh = new Toshiba();
         //tsh.ReviewProduct(5); tsh.ReviewProduct(2); tsh.ReviewProduct(3);
         //tsh.Brand = "Vestel"; tsh.ItemName = "Z40"; tsh.Resolution = "1336X768"; tsh.ScreenSize = 8; tsh.Receiver = true; tsh.Price = 3000;
         //tsh.AddItem();
         //tsh.ListItem();
         //tsh.ShowReviews();

         Console.ReadKey();
      }

      interface IDisplayandSound {
         string Brand { get; set; }
         string ItemName { get; set; }
         int Price { get; set; }
         int Reviews { get; set; }

         double TotalReview { get; set; }
         double TotalPoint { get; set; }

         void ReviewProduct(byte points);
         void ShowReviews();
         void AddItem();
      }
      interface ITelevision : IDisplayandSound {
         string Resolution { get; set; }
         byte ScreenSize { get; set; }
         bool Receiver { get; set; }
      }

      class Toshiba : ITelevision {
         protected SqlConnection SqlConnectionDisplayandSound = new SqlConnection() {
            ConnectionString = @"Server=localhost; Database=DisplayandSound; User ID=sa; Password=1234;"
         };
         SqlCommand SqlCommandDisplayandSound = new SqlCommand();

         private string TBrand, TResolution, TItemName; private int TPrice, TReviews; private byte TScreenSize; private bool TReceiver;
         public string Brand { get { return TBrand; } set { TBrand = value; } }
         public string ItemName { get { return TItemName; } set { TItemName = value; } }
         public int Price { get { return TPrice; } set { TPrice = value; } }
         public int Reviews { get { return TReviews; } set { TReviews = value; } }
         public string Resolution { get { return TResolution; } set { TResolution = value; } }
         public byte ScreenSize { get { return TScreenSize; } set { TScreenSize = value; } }
         public bool Receiver { get { return TReceiver; } set { TReceiver = value; } }

         private double TTotalReview, TTotalPoint;
         public double TotalReview { get { return TTotalReview; } set { TTotalReview = value; } }
         public double TotalPoint { get { return TTotalPoint; } set { TTotalPoint = value; } }

         public void ReviewProduct(byte point) {
            SqlCommandDisplayandSound.Connection = SqlConnectionDisplayandSound;
            Console.Write("Please enter Item ID: "); int tempindex = int.Parse(Console.ReadLine());
            SqlCommandDisplayandSound.CommandText = $"SELECT ItemID FROM Reviews";
            SqlConnectionDisplayandSound.Open();

            SqlDataReader SqlDataReaderDisplayandSound = SqlCommandDisplayandSound.ExecuteReader();
            bool tempboll = false;
            while ( SqlDataReaderDisplayandSound.Read() ) {
               if ( (int)SqlDataReaderDisplayandSound[0] == tempindex ) tempboll = true;
            }
            SqlDataReaderDisplayandSound.Close();

            if (tempboll == true ) SqlCommandDisplayandSound.CommandText = $"UPDATE Reviews SET ReviewPoint += {point}, ReviewerTotal += 1 WHERE ItemID = {tempindex}";
            else SqlCommandDisplayandSound.CommandText = $"INSERT INTO Reviews VALUES ({point},1,{tempindex})";

            SqlCommandDisplayandSound.ExecuteNonQuery();
            SqlConnectionDisplayandSound.Close();
         }
         public void ShowReviews() {
            Console.Write("Please enter Item ID: "); int tempindex = int.Parse(Console.ReadLine());
            SqlCommandDisplayandSound.Connection = SqlConnectionDisplayandSound;
            SqlCommandDisplayandSound.CommandText = $"SELECT ItemName , (ReviewPoint/ReviewerTotal) FROM Reviews INNER JOIN Items ON Reviews.ItemID = Items.ItemID";
            SqlConnectionDisplayandSound.Open();
            SqlDataReader SqlDataReaderDisplayandSound = SqlCommandDisplayandSound.ExecuteReader();
            SqlDataReaderDisplayandSound.Read();
            Console.WriteLine($"Item Name: {SqlDataReaderDisplayandSound[0]} | Item Point: {SqlDataReaderDisplayandSound[1]}");
            SqlDataReaderDisplayandSound.Close(); SqlConnectionDisplayandSound.Close();
         }
         public void AddItem() {
            SqlCommandDisplayandSound.Connection = SqlConnectionDisplayandSound;
            SqlCommandDisplayandSound.CommandText = "SELECT * FROM Brands";
            SqlConnectionDisplayandSound.Open();
            SqlDataReader SqlDataReaderDisplayandSound = SqlCommandDisplayandSound.ExecuteReader();
            bool tempboll = false; int tempint; int lastindex = 1;
            while ( SqlDataReaderDisplayandSound.Read() ) {
               if ( (string)SqlDataReaderDisplayandSound[1] == Brand ) { tempint = (int)SqlDataReaderDisplayandSound[0]; tempboll = true; break; }
               lastindex++;
            }
            SqlDataReaderDisplayandSound.Close();

            if ( tempboll == false ) {
               SqlCommandDisplayandSound.CommandText = $"INSERT INTO Brands VALUES ('{Brand}')";
               SqlCommandDisplayandSound.ExecuteNonQuery();
            }

            SqlCommandDisplayandSound.CommandText = $"INSERT INTO Items VALUES ('{ItemName}',{lastindex},'{Resolution}',{ScreenSize},'{Receiver}')";
            SqlCommandDisplayandSound.ExecuteNonQuery(); SqlConnectionDisplayandSound.Close();
         }
         public void ListItem() {
            SqlCommandDisplayandSound.Connection = SqlConnectionDisplayandSound;
            SqlCommandDisplayandSound.CommandText = $"SELECT BrandName,ItemName,ScreenSize,Resolution,Receiver FROM Items INNER JOIN Brands ON Items.ItemBrand = Brands.BrandID";
            SqlConnectionDisplayandSound.Open();
            SqlDataReader SqlDataReaderDisplayandSound = SqlCommandDisplayandSound.ExecuteReader();
            while ( SqlDataReaderDisplayandSound.Read() ) {
               Console.WriteLine($"Brand: {SqlDataReaderDisplayandSound[0]}\nItem Name: {SqlDataReaderDisplayandSound[1]}\nScreen Size: {SqlDataReaderDisplayandSound[2]}\nResolution: {SqlDataReaderDisplayandSound[3]}\nReceiver: {SqlDataReaderDisplayandSound[4]}\n");
            }
            SqlDataReaderDisplayandSound.Close(); SqlConnectionDisplayandSound.Close();
         }
      }
   }
}
