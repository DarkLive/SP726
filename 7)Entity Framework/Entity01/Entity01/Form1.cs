using System;
using System.Linq;
using System.Windows.Forms;

namespace Entity01 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         RefreshTeacher(); RefreshStudent();
      }

      private void RefreshTeacher() {
         var Cord = new Okul_VTEntities();
         o_tea.DataSource = Cord.Ogretmenlers.ToList();
      }

      private void RefreshStudent() {
         var Cord = new Okul_VTEntities();
         o_stu.DataSource = Cord.Ogrencilers.ToList();
      }

      private void b_tea_add_Click(object sender, EventArgs e) {
         var Cord = new Okul_VTEntities();

         var temp = Cord.Ogretmenlers.SingleOrDefault(tea => tea.OgretmenAdi == i_tea_name.Text);

         if ( i_tea_name.Text == null || i_tea_name.Text == "" ) MessageBox.Show("Teacher name can't be empty.");
         else if ( temp != null ) MessageBox.Show("Teacher is already in the database.");
         else {
            Ogretmenler tea = new Ogretmenler() {
               OgretmenAdi = i_tea_name.Text,
               DogumTarihi = i_tea_bday.Value
            };
            Cord.Ogretmenlers.Add(tea);
            Cord.SaveChanges();

            RefreshTeacher();
         }
      }

      private void b_tea_upd_Click(object sender, EventArgs e) {
         var Cord = new Okul_VTEntities();

         var tea = Cord.Ogretmenlers.Find(Convert.ToInt32(i_tea_name.Tag));
         tea.OgretmenAdi = i_tea_name.Text;
         tea.DogumTarihi = i_tea_bday.Value;

         Cord.SaveChanges();
         RefreshTeacher();
      }

      private void b_tea_rem_Click(object sender, EventArgs e) {
         var Cord = new Okul_VTEntities();

         var tea = Cord.Ogretmenlers.Find(Convert.ToInt32(i_tea_name.Tag));

         Cord.Ogretmenlers.Remove(tea);
         Cord.SaveChanges();
         RefreshTeacher();
      }

      private void b_stu_add_Click(object sender, EventArgs e) {
         var Cord = new Okul_VTEntities();

         Ogrenciler stu = new Ogrenciler() {
            OgrenciAdi = i_stu_name.Text,
            Mezun = i_stu_grad.Checked
         };

         Cord.Ogrencilers.Add(stu);
         Cord.SaveChanges();

         RefreshStudent();
      }

      private void b_stu_upd_Click(object sender, EventArgs e) {
         var Cord = new Okul_VTEntities();

         var stu = Cord.Ogrencilers.Find(Convert.ToInt32(i_stu_name.Tag));
         stu.OgrenciAdi = i_stu_name.Text;
         stu.Mezun = i_stu_grad.Checked;

         Cord.SaveChanges();
         RefreshStudent();
      }

      private void b_stu_rem_Click(object sender, EventArgs e) {
         var Cord = new Okul_VTEntities();

         var stu = Cord.Ogrencilers.Find(Convert.ToInt32(i_stu_name.Tag));

         Cord.Ogrencilers.Remove(stu);
         Cord.SaveChanges();
         RefreshStudent();
      }

      private void o_tea_CellClick(object sender, DataGridViewCellEventArgs e) {
         i_tea_name.Tag = o_tea.CurrentRow.Cells[0].Value;
         i_tea_name.Text = o_tea.CurrentRow.Cells[1].Value.ToString();
         if ( o_tea.CurrentRow.Cells[2].Value == null || o_tea.CurrentRow.Cells[2].Value == "")
            i_tea_bday.Value = DateTime.Today;
         else i_tea_bday.Value = Convert.ToDateTime(o_tea.CurrentRow.Cells[2].Value);
      }

      private void o_stu_CellClick(object sender, DataGridViewCellEventArgs e) {
         i_stu_name.Tag = o_stu.CurrentRow.Cells[0].Value;
         i_stu_name.Text = o_stu.CurrentRow.Cells[1].Value.ToString();
         i_stu_grad.Checked = Convert.ToBoolean(o_stu.CurrentRow.Cells[2].Value);
      }
   }
}
