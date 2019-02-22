using System.Configuration;
using System.Data.SqlClient;

namespace Business.SharedProcesses {
   class SharedProcess {
      private static SqlConnection PriConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_School"].ConnectionString);
      public static SqlConnection Conn { get { return PriConn; } }

      public static int ExecuteSQL(SqlCommand sqlCommand01) {
         Conn.Open(); int temp = sqlCommand01.ExecuteNonQuery(); Conn.Close(); return temp;
      }
   }
}
