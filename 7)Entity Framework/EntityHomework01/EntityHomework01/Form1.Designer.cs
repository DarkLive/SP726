namespace EntityHomework01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               this.ic_cpu = new System.Windows.Forms.ComboBox();
               this.label1 = new System.Windows.Forms.Label();
               this.ic_os = new System.Windows.Forms.ComboBox();
               this.label2 = new System.Windows.Forms.Label();
               this.ic_ram = new System.Windows.Forms.ComboBox();
               this.label3 = new System.Windows.Forms.Label();
               this.ic_hdd = new System.Windows.Forms.ComboBox();
               this.label4 = new System.Windows.Forms.Label();
               this.ic_ssd = new System.Windows.Forms.ComboBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.i_price = new System.Windows.Forms.TextBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.b_add = new System.Windows.Forms.Button();
               this.b_update = new System.Windows.Forms.Button();
               this.b_remove = new System.Windows.Forms.Button();
               this.output = new System.Windows.Forms.DataGridView();
               this.outputDESC = new System.Windows.Forms.Button();
               this.outputASC = new System.Windows.Forms.Button();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
               this.SuspendLayout();
               // 
               // ic_cpu
               // 
               this.ic_cpu.FormattingEnabled = true;
               this.ic_cpu.Location = new System.Drawing.Point(105, 20);
               this.ic_cpu.Name = "ic_cpu";
               this.ic_cpu.Size = new System.Drawing.Size(121, 21);
               this.ic_cpu.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(70, 24);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(32, 13);
               this.label1.TabIndex = 1;
               this.label1.Text = "CPU:";
               // 
               // ic_os
               // 
               this.ic_os.FormattingEnabled = true;
               this.ic_os.Location = new System.Drawing.Point(105, 47);
               this.ic_os.Name = "ic_os";
               this.ic_os.Size = new System.Drawing.Size(121, 21);
               this.ic_os.TabIndex = 0;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(9, 51);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(93, 13);
               this.label2.TabIndex = 1;
               this.label2.Text = "Operating System:";
               // 
               // ic_ram
               // 
               this.ic_ram.FormattingEnabled = true;
               this.ic_ram.Location = new System.Drawing.Point(105, 74);
               this.ic_ram.Name = "ic_ram";
               this.ic_ram.Size = new System.Drawing.Size(121, 21);
               this.ic_ram.TabIndex = 0;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(47, 78);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(55, 13);
               this.label3.TabIndex = 1;
               this.label3.Text = "Ram Size:";
               // 
               // ic_hdd
               // 
               this.ic_hdd.FormattingEnabled = true;
               this.ic_hdd.Location = new System.Drawing.Point(105, 101);
               this.ic_hdd.Name = "ic_hdd";
               this.ic_hdd.Size = new System.Drawing.Size(121, 21);
               this.ic_hdd.TabIndex = 0;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(45, 105);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(57, 13);
               this.label4.TabIndex = 1;
               this.label4.Text = "HDD Size:";
               // 
               // ic_ssd
               // 
               this.ic_ssd.FormattingEnabled = true;
               this.ic_ssd.Location = new System.Drawing.Point(105, 128);
               this.ic_ssd.Name = "ic_ssd";
               this.ic_ssd.Size = new System.Drawing.Size(121, 21);
               this.ic_ssd.TabIndex = 0;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(47, 132);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(55, 13);
               this.label5.TabIndex = 1;
               this.label5.Text = "SSD Size:";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(68, 159);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(34, 13);
               this.label6.TabIndex = 1;
               this.label6.Text = "Price:";
               // 
               // i_price
               // 
               this.i_price.Location = new System.Drawing.Point(105, 156);
               this.i_price.Name = "i_price";
               this.i_price.Size = new System.Drawing.Size(121, 20);
               this.i_price.TabIndex = 2;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.b_remove);
               this.panel1.Controls.Add(this.b_update);
               this.panel1.Controls.Add(this.b_add);
               this.panel1.Controls.Add(this.i_price);
               this.panel1.Controls.Add(this.ic_cpu);
               this.panel1.Controls.Add(this.label6);
               this.panel1.Controls.Add(this.ic_os);
               this.panel1.Controls.Add(this.label5);
               this.panel1.Controls.Add(this.ic_ram);
               this.panel1.Controls.Add(this.label4);
               this.panel1.Controls.Add(this.ic_hdd);
               this.panel1.Controls.Add(this.label3);
               this.panel1.Controls.Add(this.ic_ssd);
               this.panel1.Controls.Add(this.label2);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Location = new System.Drawing.Point(12, 12);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(249, 259);
               this.panel1.TabIndex = 3;
               // 
               // b_add
               // 
               this.b_add.Location = new System.Drawing.Point(83, 194);
               this.b_add.Name = "b_add";
               this.b_add.Size = new System.Drawing.Size(75, 23);
               this.b_add.TabIndex = 3;
               this.b_add.Text = "Add";
               this.b_add.UseVisualStyleBackColor = true;
               this.b_add.Click += new System.EventHandler(this.b_add_Click);
               // 
               // b_update
               // 
               this.b_update.Enabled = false;
               this.b_update.Location = new System.Drawing.Point(42, 223);
               this.b_update.Name = "b_update";
               this.b_update.Size = new System.Drawing.Size(75, 23);
               this.b_update.TabIndex = 3;
               this.b_update.Text = "Update";
               this.b_update.UseVisualStyleBackColor = true;
               this.b_update.Click += new System.EventHandler(this.b_update_Click);
               // 
               // b_remove
               // 
               this.b_remove.Enabled = false;
               this.b_remove.Location = new System.Drawing.Point(123, 223);
               this.b_remove.Name = "b_remove";
               this.b_remove.Size = new System.Drawing.Size(75, 23);
               this.b_remove.TabIndex = 3;
               this.b_remove.Text = "Remove";
               this.b_remove.UseVisualStyleBackColor = true;
               this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
               // 
               // output
               // 
               this.output.AllowUserToAddRows = false;
               this.output.AllowUserToDeleteRows = false;
               this.output.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.output.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
               this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.output.Location = new System.Drawing.Point(267, 12);
               this.output.Name = "output";
               this.output.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
               this.output.Size = new System.Drawing.Size(475, 393);
               this.output.TabIndex = 4;
               this.output.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.output_CellClick);
               // 
               // outputDESC
               // 
               this.outputDESC.Location = new System.Drawing.Point(215, 380);
               this.outputDESC.Name = "outputDESC";
               this.outputDESC.Size = new System.Drawing.Size(46, 23);
               this.outputDESC.TabIndex = 3;
               this.outputDESC.Text = "DESC";
               this.outputDESC.UseVisualStyleBackColor = true;
               this.outputDESC.Click += new System.EventHandler(this.outputDESC_Click);
               // 
               // outputASC
               // 
               this.outputASC.Location = new System.Drawing.Point(215, 351);
               this.outputASC.Name = "outputASC";
               this.outputASC.Size = new System.Drawing.Size(46, 23);
               this.outputASC.TabIndex = 3;
               this.outputASC.Text = "ASC";
               this.outputASC.UseVisualStyleBackColor = true;
               this.outputASC.Click += new System.EventHandler(this.outputASC_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(754, 417);
               this.Controls.Add(this.outputASC);
               this.Controls.Add(this.outputDESC);
               this.Controls.Add(this.output);
               this.Controls.Add(this.panel1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
               this.ResumeLayout(false);

        }

          #endregion

          private System.Windows.Forms.ComboBox ic_cpu;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox ic_os;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.ComboBox ic_ram;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.ComboBox ic_hdd;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.ComboBox ic_ssd;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.TextBox i_price;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Button b_remove;
          private System.Windows.Forms.Button b_update;
          private System.Windows.Forms.Button b_add;
          private System.Windows.Forms.DataGridView output;
          private System.Windows.Forms.Button outputDESC;
          private System.Windows.Forms.Button outputASC;
     }
}

