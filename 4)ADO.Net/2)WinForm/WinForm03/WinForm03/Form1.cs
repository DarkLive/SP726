using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm03 {
   public partial class Form1 : Form {
      SqlConnection sqlConnectionLogin = new SqlConnection {
         ConnectionString = @"Server=localhost; Database=FormsDay2; User ID=sa; Password=1234;"
      };

      public Form1() {
         InitializeComponent();
      }

      private void btn_login_Click(object sender, EventArgs e) {
         SqlCommand sqlCommandLogin = new SqlCommand();
         sqlCommandLogin.Connection = sqlConnectionLogin;
         sqlCommandLogin.CommandText = $"SELECT * FROM UserTable WHERE uName = @name AND uPass = @pass";
         sqlCommandLogin.Parameters.AddWithValue("@name", tb_uName.Text);
         sqlCommandLogin.Parameters.AddWithValue("@pass", tb_uPass.Text);
         sqlConnectionLogin.Open();
         SqlDataReader sqlDataReader = sqlCommandLogin.ExecuteReader();
         if ( sqlDataReader.Read() ) MessageBox.Show("Login Successful");
         else MessageBox.Show("Login Unsuccessful");
         sqlDataReader.Close(); sqlConnectionLogin.Close();
      }
   }
}
