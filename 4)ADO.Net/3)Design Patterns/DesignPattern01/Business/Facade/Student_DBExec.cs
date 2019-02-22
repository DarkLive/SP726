using System.Data;
using System.Data.SqlClient;
using Business.Entity;
using Business.SharedProcesses;

namespace Business.Facade {
   public static class Student_DBExec {

      public static DataTable List() {
         SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("ListStudent", SharedProcess.Conn);
         DataTable dataSet = new DataTable();
         sqlDataAdapter.Fill(dataSet);
         return dataSet;
      }

      public static int Insert(Student stu) {
         SqlCommand sqlCommand01 = new SqlCommand() { CommandText = "InsertStudent", CommandType = CommandType.StoredProcedure, Connection = SharedProcess.Conn };
         sqlCommand01.Parameters.AddWithValue("@no", stu.StuNo);
         sqlCommand01.Parameters.AddWithValue("@name", stu.StuName);
         sqlCommand01.Parameters.AddWithValue("@prog", stu.StuProgram);
         sqlCommand01.Parameters.AddWithValue("@facul", stu.StuFaculty);
         return SharedProcess.ExecuteSQL(sqlCommand01);
      }

      public static int Update(Student stu) {
         SqlCommand sqlCommand01 = new SqlCommand() { CommandText = "UpdateStudent", CommandType = CommandType.StoredProcedure, Connection = SharedProcess.Conn };
         sqlCommand01.Parameters.AddWithValue("@index", stu.StuIndex);
         sqlCommand01.Parameters.AddWithValue("@no", stu.StuNo);
         sqlCommand01.Parameters.AddWithValue("@name", stu.StuName);
         sqlCommand01.Parameters.AddWithValue("@prog", stu.StuProgram);
         sqlCommand01.Parameters.AddWithValue("@facul", stu.StuFaculty);
         return SharedProcess.ExecuteSQL(sqlCommand01);
      }
   }
}
