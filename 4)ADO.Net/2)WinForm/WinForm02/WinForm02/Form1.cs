using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinForm02 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      SqlConnection sqlConnectionSchool = new SqlConnection() {
         ConnectionString = "Server=localhost; Database=FormsDay1; User ID=sa; Password=1234;"
      };
      SqlCommand sqlCommandSchool = new SqlCommand();

      private void calcButton_Click(object sender, EventArgs e) {
         sqlCommandSchool.Connection = sqlConnectionSchool;
         sqlCommandSchool.CommandText = $"INSERT INTO School VALUES (@stuNo,@stuCourse,@stuMid,@stuEnd)";
         sqlCommandSchool.Parameters.AddWithValue("@stuNo", int.Parse(stuNo.Text));
         sqlCommandSchool.Parameters.AddWithValue("@stuCourse", stuCourse.Text);
         sqlCommandSchool.Parameters.AddWithValue("@stuMid", int.Parse(stuMid.Text));
         sqlCommandSchool.Parameters.AddWithValue("@stuEnd", int.Parse(stuEnd.Text));
         sqlConnectionSchool.Open();
         double tempdouble = new double();
         int tempint = sqlCommandSchool.ExecuteNonQuery();
         if ( tempint > 0 ) { MessageBox.Show($"Student added to the Server."); tempdouble = Calculate(double.Parse(stuMid.Text), double.Parse(stuEnd.Text)); }
         else MessageBox.Show("Can't add student due to an error.");
         sqlConnectionSchool.Close();

         if ( tempdouble < 50 ) { MessageBox.Show($"Failed\n\n Avg: {tempdouble}"); }
         else if ( tempdouble < 60 && tempdouble > 50 ) { MessageBox.Show($"D\n\n Avg: {tempdouble}"); }
         else if ( tempdouble < 70 && tempdouble > 60 ) { MessageBox.Show($"C\n\n Avg: {tempdouble}"); }
         else if ( tempdouble < 80 && tempdouble > 70 ) { MessageBox.Show($"B\n\n Avg: {tempdouble}"); }
         else if ( tempdouble <= 100 && tempdouble >= 80 ) { MessageBox.Show($"A\n\n Avg: {tempdouble}"); }
         else { MessageBox.Show($"Calculation Error.\n\n Avg: {tempdouble}"); }
      }
      private double Calculate(double mid, double end) {
         return (( mid * 0.4d ) + ( end * 0.6d ));
      }
   }
}
