using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace XML01 {
   public partial class XMLAdd : Form {
      public XMLAdd() {
         InitializeComponent();
      }

      XmlDocument filex;
      XmlElement schoolNode01;

      private void btn_add_Click(object sender, EventArgs e) {
         XmlElement maingen = filex.CreateElement("student");
         schoolNode01.AppendChild(maingen);

         XmlElement subgen = filex.CreateElement("studentno");
         subgen.InnerText = input_studentno.Text;
         maingen.AppendChild(subgen);

         subgen = filex.CreateElement("studentname");
         subgen.InnerText = input_studentname.Text;
         maingen.AppendChild(subgen);

         subgen = filex.CreateElement("studentclass");
         subgen.InnerText = input_studentclass.Text;
         maingen.AppendChild(subgen);

         subgen = filex.CreateElement("studentbirthday");
         subgen.InnerText = input_studentbirthday.Value.ToString("dd.MM.yyyy");
         maingen.AppendChild(subgen);

         filex.Save(@"..\..\School.xml");
      }

      private void XMLAdd_Load(object sender, EventArgs e) {
         filex = new XmlDocument();

         if ( !File.Exists(@"..\..\School.xml") ) {
            XmlElement schoolNode01 = filex.CreateElement("schoolname");
            filex.AppendChild(schoolNode01);
         }
         else {
            filex.Load(@"..\..\School.xml");
            schoolNode01 = (XmlElement)filex.SelectSingleNode("schoolname");
         }
      }
   }
}
