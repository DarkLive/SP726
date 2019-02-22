using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsHomework01 {
    public partial class Form1: Form {
        SqlConnection Conn = new SqlConnection() { ConnectionString = "Server=localhost; Database=Homework; User=sa; Password=1234;"
    };

        public Form1() {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e) {
            SqlCommand sqlCommand = new SqlCommand("InsertStudent", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@no", int.Parse(input_number.Text));
            sqlCommand.Parameters.AddWithValue("@name", input_fullname.Text);
            sqlCommand.Parameters.AddWithValue("@prog", input_programs.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@facul", input_faculty.Text.ToString());
            Conn.Open(); int temp = sqlCommand.ExecuteNonQuery(); Conn.Close();
            if ( temp > 0 ) MessageBox.Show("Student Registered");
            else MessageBox.Show("Error");
            ClearInput();
            ListStudents();
        }

        private void updbtn_Click(object sender, EventArgs e) {
            SqlCommand sqlCommand = new SqlCommand("UpdateStudent") { CommandType = CommandType.StoredProcedure, Connection = Conn };
            sqlCommand.Parameters.AddWithValue("@index", int.Parse(grid_student.CurrentRow.Cells[0].Value.ToString()));
            sqlCommand.Parameters.AddWithValue("@no", int.Parse(input_number.Text));
            sqlCommand.Parameters.AddWithValue("@name", input_fullname.Text);
            sqlCommand.Parameters.AddWithValue("@prog", input_programs.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@facul", input_faculty.SelectedItem.ToString());
            try {
                Conn.Open(); int temp = sqlCommand.ExecuteNonQuery(); Conn.Close();
                if ( temp > 0 ) MessageBox.Show("Student Registered");
                else MessageBox.Show("Error");
                ClearInput();
                ListStudents();
            }
            catch { MessageBox.Show("Error"); ClearInput(); }
        }

        private void Form1_Load(object sender, EventArgs e) {
            ListStudents();
        }

        private void ListStudents() {
            try {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Students", Conn);
                DataTable dataSet = new DataTable();
                sqlDataAdapter.Fill(dataSet);
                grid_student.DataSource = dataSet;
            }
            catch { }
        }

        private void grid_student_CellClick(object sender, DataGridViewCellEventArgs e) {
            input_number.Text = grid_student.CurrentRow.Cells[1].Value.ToString();
            input_fullname.Text = grid_student.CurrentRow.Cells[2].Value.ToString();
            input_programs.SelectedItem = grid_student.CurrentRow.Cells[3].Value.ToString();
            input_faculty.SelectedItem = grid_student.CurrentRow.Cells[4].Value.ToString();
        }

        private void ClearInput() {
            input_number.Text = "";
            input_fullname.Text = "";
            input_programs.SelectedItem = "";
            input_faculty.SelectedItem = "";
        }
    }
}
