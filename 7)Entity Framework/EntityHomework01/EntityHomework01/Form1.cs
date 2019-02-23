using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntityHomework01 {
     public partial class Form1: Form {
          public Form1() {
               InitializeComponent();
          }

          public bool SortingOrder = false;

          private void Form1_Load(object sender, EventArgs e) {
               var Cord = new EntityHomework01Entities();

               ic_cpu.DataSource = Cord.CPUs.ToList();
               ic_cpu.DisplayMember = "cpuName"; ic_cpu.ValueMember = "cpuID";

               ic_os.DataSource = Cord.OperatingSystems.ToList();
               ic_os.DisplayMember = "osName"; ic_os.ValueMember = "osID";

               ic_ram.DataSource = Enum.GetValues(typeof(SizeRAM));
               ic_hdd.DataSource = Enum.GetValues(typeof(SizeDISK));
               ic_ssd.DataSource = Enum.GetValues(typeof(SizeSSD));

               RefreshOutput();
          }

          private void b_add_Click(object sender, EventArgs e) {
               var Cord = new EntityHomework01Entities();
               var comp = new Computer();

               comp.cpuBrandID = (int)ic_cpu.SelectedValue;
               comp.opeSysID = (int)ic_cpu.SelectedValue;
               comp.ramSize = (SizeRAM)ic_ram.SelectedIndex;
               comp.diskSize = (SizeDISK)ic_hdd.SelectedIndex;
               comp.ssdSize = (SizeSSD)ic_ssd.SelectedIndex;
               comp.price = int.Parse(i_price.Text);

               Cord.Computers.Add(comp);
               Cord.SaveChanges();
               RefreshOutput();
          }

          private void b_update_Click(object sender, EventArgs e) {
               var Cord = new EntityHomework01Entities();

               var comp = Cord.Computers.Find(Convert.ToInt32(i_price.Tag));

               comp.cpuBrandID = (int)ic_cpu.SelectedValue;
               comp.opeSysID = (int)ic_os.SelectedValue;
               comp.ramSize = (SizeRAM)ic_ram.SelectedIndex;
               comp.diskSize = (SizeDISK)ic_hdd.SelectedIndex;
               comp.ssdSize = (SizeSSD)ic_ssd.SelectedIndex;
               comp.price = int.Parse(i_price.Text);

               Cord.SaveChanges();
               RefreshOutput();
          }

          private void b_remove_Click(object sender, EventArgs e) {
               var Cord = new EntityHomework01Entities();

               var comp = Cord.Computers.Find(Convert.ToInt32(i_price.Tag));

               Cord.Computers.Remove(comp);
               Cord.SaveChanges();
               RefreshOutput();
          }

          private void output_CellClick(object sender, DataGridViewCellEventArgs e) {
               DataGridViewRow dRow = output.CurrentRow;

               ic_cpu.Text = dRow.Cells[1].Value.ToString();
               ic_os.Text = dRow.Cells[2].Value.ToString();
               ic_ram.SelectedIndex = Convert.ToInt16(dRow.Cells[3].Value);
               ic_hdd.SelectedIndex = Convert.ToInt16(dRow.Cells[4].Value);
               ic_ssd.SelectedIndex = Convert.ToInt16(dRow.Cells[5].Value);
               i_price.Text = Convert.ToInt32(dRow.Cells[6].Value).ToString();
               i_price.Tag = dRow.Cells[0].Value;

               ComboButtonsEnable();
          }

          private void RefreshOutput() {
               var Cord = new EntityHomework01Entities();
               
               if (SortingOrder == false ) output.DataSource = Cord.ShowComputers.ToList().OrderBy(temp => temp.comID).ToList();
               else output.DataSource = Cord.ShowComputers.ToList().OrderByDescending(temp => temp.comID).ToList();

               output.Columns[0].Visible = false;
               output.ClearSelection();
               ComboButtonsDisable();
          }

          private void outputASC_Click(object sender, EventArgs e) {
               SortingOrder = false;
               RefreshOutput();
          }

          private void outputDESC_Click(object sender, EventArgs e) {
               SortingOrder = true;
               RefreshOutput();
          }

          private void ComboButtonsEnable() {
               b_remove.Enabled = true;
               b_update.Enabled = true;
          }

          private void ComboButtonsDisable() {
               b_remove.Enabled = false;
               b_update.Enabled = false;
          }
     }
}
