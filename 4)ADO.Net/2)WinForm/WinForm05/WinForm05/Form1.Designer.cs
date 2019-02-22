namespace WinForm05 {
   partial class Form1 {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if ( disposing && ( components != null ) ) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.panel1 = new System.Windows.Forms.Panel();
         this.btn_update = new System.Windows.Forms.Button();
         this.btn_add = new System.Windows.Forms.Button();
         this.input_Faculty = new System.Windows.Forms.ComboBox();
         this.input_Program = new System.Windows.Forms.ComboBox();
         this.input_Name = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.input_No = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btn_update);
         this.panel1.Controls.Add(this.btn_add);
         this.panel1.Controls.Add(this.input_Faculty);
         this.panel1.Controls.Add(this.input_Program);
         this.panel1.Controls.Add(this.input_Name);
         this.panel1.Controls.Add(this.label4);
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.input_No);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Location = new System.Drawing.Point(22, 102);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(208, 178);
         this.panel1.TabIndex = 0;
         // 
         // btn_update
         // 
         this.btn_update.Location = new System.Drawing.Point(107, 139);
         this.btn_update.Name = "btn_update";
         this.btn_update.Size = new System.Drawing.Size(75, 23);
         this.btn_update.TabIndex = 6;
         this.btn_update.Text = "Update";
         this.btn_update.UseVisualStyleBackColor = true;
         this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
         // 
         // btn_add
         // 
         this.btn_add.Location = new System.Drawing.Point(26, 139);
         this.btn_add.Name = "btn_add";
         this.btn_add.Size = new System.Drawing.Size(75, 23);
         this.btn_add.TabIndex = 5;
         this.btn_add.Text = "Add";
         this.btn_add.UseVisualStyleBackColor = true;
         this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
         // 
         // input_Faculty
         // 
         this.input_Faculty.FormattingEnabled = true;
         this.input_Faculty.Items.AddRange(new object[] {
            "Distance Learning",
            "Graduate Learning",
            "Undergraduate Learning"});
         this.input_Faculty.Location = new System.Drawing.Point(73, 99);
         this.input_Faculty.Name = "input_Faculty";
         this.input_Faculty.Size = new System.Drawing.Size(121, 21);
         this.input_Faculty.Sorted = true;
         this.input_Faculty.TabIndex = 4;
         // 
         // input_Program
         // 
         this.input_Program.FormattingEnabled = true;
         this.input_Program.Items.AddRange(new object[] {
            "Biochemistry",
            "Machine Learning",
            "Programming"});
         this.input_Program.Location = new System.Drawing.Point(73, 72);
         this.input_Program.Name = "input_Program";
         this.input_Program.Size = new System.Drawing.Size(121, 21);
         this.input_Program.Sorted = true;
         this.input_Program.TabIndex = 3;
         // 
         // input_Name
         // 
         this.input_Name.Location = new System.Drawing.Point(73, 46);
         this.input_Name.Name = "input_Name";
         this.input_Name.Size = new System.Drawing.Size(121, 20);
         this.input_Name.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(23, 102);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(48, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "*Faculty:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(19, 75);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(49, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Program:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(10, 49);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(61, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "*Full Name:";
         // 
         // input_No
         // 
         this.input_No.Location = new System.Drawing.Point(73, 20);
         this.input_No.Name = "input_No";
         this.input_No.Size = new System.Drawing.Size(121, 20);
         this.input_No.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(20, 23);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(51, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "*Number:";
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToDeleteRows = false;
         this.dataGridView1.AllowUserToResizeColumns = false;
         this.dataGridView1.AllowUserToResizeRows = false;
         this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(250, 12);
         this.dataGridView1.MultiSelect = false;
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.Size = new System.Drawing.Size(366, 360);
         this.dataGridView1.TabIndex = 1;
         this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(628, 384);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btn_update;
      private System.Windows.Forms.Button btn_add;
      private System.Windows.Forms.ComboBox input_Faculty;
      private System.Windows.Forms.ComboBox input_Program;
      private System.Windows.Forms.TextBox input_Name;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox input_No;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView dataGridView1;
   }
}

