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

namespace WinForm04 {
   public partial class Form1 : Form {
      SqlConnection conn = new SqlConnection() {
      ConnectionString= "Server=.; Database=TEST; User=sa; Pwd=1234;" //IntegratedSecurity=TRUE
      };

      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         DoList();
      }

      private void DoList() {
         SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("ElemanListele", conn);
         sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

         DataTable TableContent = new DataTable();
         sqlDataAdapter.Fill(TableContent);
         dataGridView1.DataSource = TableContent;
      }

      private void btn_Add_Click(object sender, EventArgs e) {
         SqlCommand sqlCommand = new SqlCommand("SP_Eleman_Kaydet", conn);
         sqlCommand.Parameters.AddWithValue("@ad", namebox.Text);
         sqlCommand.Parameters.AddWithValue("@soyad", surnamebox.Text);
         sqlCommand.Parameters.AddWithValue("@sehir", citybox.SelectedItem.ToString());
         sqlCommand.CommandType = CommandType.StoredProcedure;
         conn.Open();
         int temp = sqlCommand.ExecuteNonQuery();
         conn.Close();
         if ( temp > 0 ) { MessageBox.Show("Registration Complete"); DoList(); }
         else MessageBox.Show("Registration Failed");
      }

      private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
         namebox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         surnamebox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
         citybox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
      }

      private void btn_Update_Click(object sender, EventArgs e) {
         SqlCommand sqlCommand = new SqlCommand("SP_Eleman_Guncelle", conn);
         sqlCommand.Parameters.AddWithValue("@name", namebox.Text);
         sqlCommand.Parameters.AddWithValue("@surname", surnamebox.Text);
         sqlCommand.Parameters.AddWithValue("@city", citybox.SelectedItem.ToString());
         sqlCommand.Parameters.AddWithValue("@index", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
         sqlCommand.CommandType = CommandType.StoredProcedure;
         conn.Open();
         int temp = sqlCommand.ExecuteNonQuery();
         conn.Close();
         if ( temp > 0 ) { MessageBox.Show("Update Complete"); DoList(); }
         else MessageBox.Show("Update Failed");
      }
   }
}
