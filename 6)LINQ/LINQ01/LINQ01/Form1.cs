using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace LINQ01 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      DatabaseCordDataContext Cord = new DatabaseCordDataContext();

      private void Form1_Load(object sender, EventArgs e) {
         Refresh();
      }

      private void Refresh() {
         DatabaseCordDataContext CordR = new DatabaseCordDataContext();
         output.DataSource = CordR.Ogrencis;
      }

      private void btn_add_Click(object sender, EventArgs e) {
         Ogrenci ogr = new Ogrenci() {
            OgrenciNumara = input_no.Text,
            OgrenciAdSoyad = input_name.Text,
            OgrenciBolum = input_program.Text,
            OgrenciFakulte = input_faculty.Text
         };

         Cord.Ogrencis.InsertOnSubmit(ogr);
         Cord.SubmitChanges();
         Refresh();
      }

      private void btn_upd_Click(object sender, EventArgs e) {
         Ogrenci ogr = Cord.Ogrencis.SingleOrDefault(stu => stu.OgrenciNumara == input_no.Tag);
         ogr.OgrenciAdSoyad = input_name.Text;
         ogr.OgrenciBolum = input_program.Text;
         ogr.OgrenciFakulte = input_faculty.Text;

         Cord.SubmitChanges();
         Refresh();
      }

      private void btn_remove_Click(object sender, EventArgs e) {
         Ogrenci ogr = Cord.Ogrencis.SingleOrDefault(stu => stu.OgrenciNumara == input_no.Tag);

         Cord.Ogrencis.DeleteOnSubmit(ogr);
         Cord.SubmitChanges();
         Refresh();
      }

      private void output_CellClick(object sender, DataGridViewCellEventArgs e) {
         DataGridViewRow dRow = output.CurrentRow;
         input_no.Tag = (string)dRow.Cells[0].Value;
         input_no.Text = (string)dRow.Cells[0].Value;
         input_name.Text = (string)dRow.Cells[1].Value;
         input_program.Text = (string)dRow.Cells[2].Value;
         input_faculty.Text = (string)dRow.Cells[3].Value;
      }
   }
}
