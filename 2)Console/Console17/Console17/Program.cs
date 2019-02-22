using System;
using System.IO;
using System.Text;

namespace Console17 {
   class Program {
      static void Main(string[] args) {

         //string filepath = $@"{Directory.GetCurrentDirectory()}\BroBurger.txt";

         //BroBurger broburger = new BroBurger();
         //broburger.Owner = "Ege"; broburger.TaxNumber = 155;
         //broburger.OwnerRegister(filepath);
         //broburger.Name = "BroBurger Kadıköy"; broburger.ID = 3; broburger.Country = "Turkey"; broburger.City = "İstanbul"; broburger.District = "Kadıköy"; broburger.Adress = "Kadıköy and some other adress stuff"; 
         //broburger.StoreRegister(filepath);
         //broburger.OwnerChange(filepath, "Ege", "Turan");

         //BroBurger.WriteInfo(filepath);

         string[] files = Directory.GetFiles(@"C:\TEST");

         FileStream filestream2 = new FileStream(@"C:\HEDEF\logs.txt", FileMode.Append);
         StreamWriter streamwriter2 = new StreamWriter(filestream2, Encoding.Default);

         for ( int i = 0; i < files.Length; i++ ) {
            if ( File.GetLastWriteTime(files[i]) < DateTime.Now.AddDays(-1) && File.GetLastWriteTime(files[i]) > DateTime.Now.AddDays(-2) ) {
               File.Copy(files[i], @"C:\HEDEF\"+files[i].Substring(files[i].LastIndexOf("\\")+1), true);
               streamwriter2.WriteLine($"{DateTime.Now} \t MOVED  \t {files[i]} => {@"C:\HEDEF" + files[i].Substring(files[i].LastIndexOf("\\"))}");
            }
            else if ( File.GetLastWriteTime(files[i]) < DateTime.Now.AddDays(-5)) {
               File.Delete(files[i]);
               streamwriter2.WriteLine($"{DateTime.Now} \t DELETED \t {files[i]}");
            }
         }
         streamwriter2.Flush(); streamwriter2.Close(); filestream2.Close();
         Console.WriteLine("Done.");

         Console.ReadKey();
      }
   }
   //interface IOwenerInfo {
   //   string Owner { get; set; }
   //   int TaxNumber { get; set; }

   //   void OwnerRegister(string filepath);
   //}
   //interface IStoreInfo {
   //   string Name { get; set; }
   //   int ID { get; set; }
   //   string Country { get; set; }
   //   string City { get; set; }
   //   string District { get; set; }
   //   string Adress { get; set; }

   //   void StoreRegister(string filepath);
   //}
   //class BroBurger : IOwenerInfo, IStoreInfo{
   //   protected string BOwner, BName, BCountry, BCity, BDistrict, BAdress; protected int BTaxNumber, BID;
   //   public string Owner { get { return BOwner; } set { BOwner = value; } }
   //   public int TaxNumber { get { return BTaxNumber; } set { BTaxNumber = value; } }
   //   public string Name { get { return BName; } set { BName = value; } }
   //   public int ID { get { return BID; } set { BID = value; } }
   //   public string Country { get { return BCountry; } set { BCountry = value; } }
   //   public string City { get { return BCity; } set { BCity = value; } }
   //   public string District { get { return BDistrict; } set { BDistrict = value; } }
   //   public string Adress { get { return BAdress; } set { BAdress = value; } }
   //   public void OwnerRegister(string filepath) {
   //      FileStream fileStream1 = new FileStream(filepath, FileMode.Append, FileAccess.Write);
   //      StreamWriter streamWriter1 = new StreamWriter(fileStream1, Encoding.Default);
   //      streamWriter1.Write($"Owner: {Owner} | Owner Tax Number: {TaxNumber} | ");
   //      streamWriter1.Flush(); streamWriter1.Close(); fileStream1.Close();
   //   }
   //   public void StoreRegister(string filepath) {
   //      FileStream fileStream1 = new FileStream(filepath, FileMode.Append, FileAccess.Write);
   //      StreamWriter streamWriter1 = new StreamWriter(fileStream1, Encoding.Default);
   //      streamWriter1.WriteLine($"Store Name: {Name} | Store ID: {ID} | Store Country: {Country} | Store City: {City} | Store District: {District} | Store Adress: {Adress}");
   //      streamWriter1.Flush(); streamWriter1.Close(); fileStream1.Close();
   //   }
   //   public static void WriteInfo(string filepath) {
   //      FileStream fileStream1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
   //      StreamReader streamReader1 = new StreamReader(fileStream1, Encoding.Default);
   //      string templine;
   //      while ( ( templine = streamReader1.ReadLine() ) != null ) {
   //         Console.WriteLine(templine);
   //      }
   //      streamReader1.Close(); fileStream1.Close();
   //   }
   //   public void OwnerChange(string filepath,string oldowner,string newowner) {
   //      string temptext = File.ReadAllText(filepath, Encoding.Default);
   //      File.WriteAllText(filepath, temptext.Replace(oldowner, newowner), Encoding.Default);
   //   }
   //}
}
