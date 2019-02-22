using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML02 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         Refresh();
      }

      private void Refresh() {
         output.Text = "";
         FileStream fStream = new FileStream(@"..\..\Cars.xml", FileMode.OpenOrCreate);
         XmlSerializer xDeSer = new XmlSerializer(typeof(brands));
         brands brs = new brands();

         brs = (brands)xDeSer.Deserialize(fStream);
         brs.brand.ForEach(car => output.Text += $"{car.BrandName} {car.Model} {car.EngineCap} \n");
         fStream.Close();
      }

      private void btn_add_Click(object sender, EventArgs e) {
         car br1 = new car();
         br1.BrandName = input_BrandName.Text;
         br1.Model = input_Model.Text;
         br1.EngineCap = input_EngCap.Text;

         car br2 = new car();
         br2.BrandName = "TOFAŞ";
         br2.Model = "Doğan SLX";
         br2.EngineCap = "1333";

         List<car> brlist = new List<car>();
         brlist.Add(br1);
         brlist.Add(br2);

         brands brs = new brands();
         brs.brand = brlist;

         FileStream fStream = new FileStream(@"..\..\Cars.xml", FileMode.Create);
         XmlSerializer xSer = new XmlSerializer(typeof(brands));
         xSer.Serialize(fStream, brs);
         fStream.Close();
         Refresh();
      }
   }
}
