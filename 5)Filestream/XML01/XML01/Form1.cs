using System;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace XML01 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {

      }

      private void btn_add_Click(object sender, EventArgs e) {
         xmlInfoListBox.Items.Clear();

         XmlDocument xmlFile01 = new XmlDocument();
         xmlFile01.Load(@"..\..\School.xml");
         XmlNode xmlNode01 = xmlFile01.SelectSingleNode("schoolname");
         XmlNodeList xmlNodeList01 = xmlNode01.SelectNodes("student");

         foreach ( XmlNode item in xmlNodeList01 ) {
            if ( input_stuno.Text == item.SelectSingleNode("studentno").InnerText ) {
               xmlInfoListBox.Items.Add(item.SelectSingleNode("studentno").InnerText);
               xmlInfoListBox.Items.Add(item.SelectSingleNode("studentname").InnerText);
               xmlInfoListBox.Items.Add(item.SelectSingleNode("studentclass").InnerText);
               xmlInfoListBox.Items.Add(item.SelectSingleNode("studentbirthday").InnerText);
            }
         }
      }

      private void newpage_Click(object sender, EventArgs e) {
         XMLAdd newpage = new XMLAdd();
         newpage.Show();
         
      }
   }
}
