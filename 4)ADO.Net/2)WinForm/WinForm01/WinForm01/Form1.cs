using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WinForm01 {
   public partial class Form_MainScreen : Form {
      SqlConnection sqlConnectionForm1 = new SqlConnection(@"Server=localhost; Database=FormsDay1; User=sa; Password=1234;");

      public Form_MainScreen() {
         InitializeComponent();
      }

      private void btn_register_Click(object sender, EventArgs e) {
         SqlCommand sqlCommandForm1 = new SqlCommand($"INSERT INTO Users VALUES ('{txt_id.Text}','{txt_Name.Text}','{txt_Surname.Text}','{dtp_Birthday.Value.ToString("yyyy-MM-dd")}')", sqlConnectionForm1);
         sqlConnectionForm1.Open();
         int tempint = sqlCommandForm1.ExecuteNonQuery();
         if ( tempint > 0 ) MessageBox.Show("Registration Complete");
         else MessageBox.Show("Cant Complete Registration");
         sqlConnectionForm1.Close();
      }
   }
}
