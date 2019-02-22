using System;
using System.Windows.Forms;
using Business.Entity;
using Business.Facade;

namespace WinForm05 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         List();
      }

      private void List() {
         dataGridView1.DataSource = Student_DBExec.List();
      }

      private void btn_add_Click(object sender, EventArgs e) {
         if ( CheckNull() == true ) { MessageBox.Show("You must enter all the asterisk marked inputs."); }
         else {
            Student stu = new Student();
            stu.StuNo = input_No.Text;
            stu.StuName = input_Name.Text;
            stu.StuProgram = input_Program.Text;
            stu.StuFaculty = input_Faculty.Text;
            int temp = Student_DBExec.Insert(stu);
            if ( temp > 0 ) MessageBox.Show("Student added.");
            else MessageBox.Show("Student can't be added.");
            List();
            ClearInputs();
         }
      }

      private void btn_update_Click(object sender, EventArgs e) {
         if ( CheckNull() == true ) { MessageBox.Show("You must enter all the asterisk marked inputs."); }
         else { 
         Student stu = new Student();
         stu.StuIndex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
         stu.StuNo = input_No.Text;
         stu.StuName = input_Name.Text;
         stu.StuProgram = input_Program.Text;
         stu.StuFaculty = input_Faculty.Text; 
         int temp = Student_DBExec.Update(stu);
         if ( temp > 0 ) MessageBox.Show("Student updated.");
         else MessageBox.Show("Student can't be updated.");
         List();
         ClearInputs();
         }
      }

      private void ClearInputs() {
         input_No.Clear();
         input_Name.Clear();
         input_Program.ResetText();
         input_Faculty.ResetText();
      }

      private bool CheckNull() {
         if ( input_No.Text == "" || input_No.Text == null ) return true;
         else if ( input_Name.Text ==  "" || input_Name.Text == null ) return true;
         else if ( input_Faculty.Text == "" || input_Faculty.Text == null ) return true;
         else return false;
      }

      private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
         input_No.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
         input_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         input_Program.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
         input_Faculty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
      }
   }
}
