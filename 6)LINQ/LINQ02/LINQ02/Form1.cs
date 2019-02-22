using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Windows.Forms;

namespace LINQ02 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      DBCordDataContext Cord = new DBCordDataContext();

      private void btn_add_mov_Click(object sender, EventArgs e) {
         XmlDocument MoviesXML = new XmlDocument(); XmlElement RootNode;
         if ( !File.Exists(@"..\..\Movies.xml") ) { RootNode = MoviesXML.CreateElement("Movies"); MoviesXML.AppendChild(RootNode); }
         else { MoviesXML.Load(@"..\..\Movies.xml"); RootNode = (XmlElement)MoviesXML.SelectSingleNode("Movies"); }

         XmlElement root;
         root = MoviesXML.CreateElement("MovieName");
         root.InnerText = input_MovName.Text;
         RootNode.AppendChild(root);

         MoviesXML.Save(@"..\..\Movies.xml");

         //Movie mov = new Movie();
         //mov.movName = input_MovName.Text;
         //Cord.Movies.InsertOnSubmit(mov);

         Cord.SP_Insert_Movie(input_MovName.Text);
         Cord.SubmitChanges();

         RefreshCombobox();
      }

      private void btn_add_the_Click(object sender, EventArgs e) {
         Theater the = new Theater() {
            theName = input_TheName.Text
         };

         Cord.Theaters.InsertOnSubmit(the);
         Cord.SubmitChanges();
         RefreshCombobox();
      }

      private void btn_add_air_Click(object sender, EventArgs e) {
         Air air = new Air {
            airMovID = (int)input_cb_mov.SelectedValue,
            airTheID = (int)input_cb_the.SelectedValue,
            airTime = input_airdate.Value
         };

         Cord.Airs.InsertOnSubmit(air);
         Cord.SubmitChanges();

         RefreshOutput();
      }

      private void RefreshOutput() {
         DBCordDataContext CordN = new DBCordDataContext();

         //var query = from air in CordN.Airs
         //            join mov in CordN.Movies on air.airMovID equals mov.movID
         //            join the in CordN.Theaters on air.airTheID equals the.theID
         //            select new { MovieName = mov.movName, TheaterName = the.theName, AirTime = air.airTime };

         output.DataSource = CordN.AirOutputs;
      }

      private void Form1_Load(object sender, EventArgs e) {
         RefreshCombobox();
         RefreshOutput();
      }

      private void RefreshCombobox() {
         DBCordDataContext CordN = new DBCordDataContext();
         input_cb_mov.DataSource = CordN.Movies;
         input_cb_mov.DisplayMember = "movName";
         input_cb_mov.ValueMember = "movID";

         input_cb_the.DataSource = CordN.Theaters;
         input_cb_the.DisplayMember = "theName";
         input_cb_the.ValueMember = "theID";
      }
   }
}
