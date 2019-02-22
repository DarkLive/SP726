namespace Entity01 {
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
         this.b_tea_add = new System.Windows.Forms.Button();
         this.i_tea_name = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.i_stu_grad = new System.Windows.Forms.CheckBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.i_stu_name = new System.Windows.Forms.TextBox();
         this.i_tea_bday = new System.Windows.Forms.DateTimePicker();
         this.label5 = new System.Windows.Forms.Label();
         this.b_tea_upd = new System.Windows.Forms.Button();
         this.b_tea_rem = new System.Windows.Forms.Button();
         this.b_stu_rem = new System.Windows.Forms.Button();
         this.b_stu_upd = new System.Windows.Forms.Button();
         this.b_stu_add = new System.Windows.Forms.Button();
         this.o_tea = new System.Windows.Forms.DataGridView();
         this.o_stu = new System.Windows.Forms.DataGridView();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.o_tea)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.o_stu)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.i_tea_bday);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.label5);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.i_tea_name);
         this.panel1.Controls.Add(this.b_tea_rem);
         this.panel1.Controls.Add(this.b_tea_upd);
         this.panel1.Controls.Add(this.b_tea_add);
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(167, 153);
         this.panel1.TabIndex = 0;
         // 
         // b_tea_add
         // 
         this.b_tea_add.Location = new System.Drawing.Point(46, 90);
         this.b_tea_add.Name = "b_tea_add";
         this.b_tea_add.Size = new System.Drawing.Size(75, 23);
         this.b_tea_add.TabIndex = 3;
         this.b_tea_add.Text = "Add";
         this.b_tea_add.UseVisualStyleBackColor = true;
         this.b_tea_add.Click += new System.EventHandler(this.b_tea_add_Click);
         // 
         // i_tea_name
         // 
         this.i_tea_name.Location = new System.Drawing.Point(56, 34);
         this.i_tea_name.Name = "i_tea_name";
         this.i_tea_name.Size = new System.Drawing.Size(100, 20);
         this.i_tea_name.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 37);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Name:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(61, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Teacher";
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.b_stu_rem);
         this.panel2.Controls.Add(this.b_stu_upd);
         this.panel2.Controls.Add(this.b_stu_add);
         this.panel2.Controls.Add(this.i_stu_grad);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Controls.Add(this.label4);
         this.panel2.Controls.Add(this.i_stu_name);
         this.panel2.Location = new System.Drawing.Point(12, 171);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(167, 145);
         this.panel2.TabIndex = 1;
         // 
         // i_stu_grad
         // 
         this.i_stu_grad.AutoSize = true;
         this.i_stu_grad.Location = new System.Drawing.Point(46, 62);
         this.i_stu_grad.Name = "i_stu_grad";
         this.i_stu_grad.Size = new System.Drawing.Size(76, 17);
         this.i_stu_grad.TabIndex = 2;
         this.i_stu_grad.Text = "Graduated";
         this.i_stu_grad.UseVisualStyleBackColor = true;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(62, 9);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(44, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Student";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 37);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(38, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "Name:";
         // 
         // i_stu_name
         // 
         this.i_stu_name.Location = new System.Drawing.Point(56, 34);
         this.i_stu_name.Name = "i_stu_name";
         this.i_stu_name.Size = new System.Drawing.Size(100, 20);
         this.i_stu_name.TabIndex = 1;
         // 
         // i_tea_bday
         // 
         this.i_tea_bday.CustomFormat = "dd / MM / yyyy";
         this.i_tea_bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.i_tea_bday.Location = new System.Drawing.Point(54, 60);
         this.i_tea_bday.Name = "i_tea_bday";
         this.i_tea_bday.Size = new System.Drawing.Size(102, 20);
         this.i_tea_bday.TabIndex = 2;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(5, 63);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(48, 13);
         this.label5.TabIndex = 2;
         this.label5.Text = "Birthday:";
         // 
         // b_tea_upd
         // 
         this.b_tea_upd.Location = new System.Drawing.Point(7, 119);
         this.b_tea_upd.Name = "b_tea_upd";
         this.b_tea_upd.Size = new System.Drawing.Size(75, 23);
         this.b_tea_upd.TabIndex = 4;
         this.b_tea_upd.Text = "Update";
         this.b_tea_upd.UseVisualStyleBackColor = true;
         this.b_tea_upd.Click += new System.EventHandler(this.b_tea_upd_Click);
         // 
         // b_tea_rem
         // 
         this.b_tea_rem.Location = new System.Drawing.Point(87, 119);
         this.b_tea_rem.Name = "b_tea_rem";
         this.b_tea_rem.Size = new System.Drawing.Size(75, 23);
         this.b_tea_rem.TabIndex = 5;
         this.b_tea_rem.Text = "Remove";
         this.b_tea_rem.UseVisualStyleBackColor = true;
         this.b_tea_rem.Click += new System.EventHandler(this.b_tea_rem_Click);
         // 
         // b_stu_rem
         // 
         this.b_stu_rem.Location = new System.Drawing.Point(83, 114);
         this.b_stu_rem.Name = "b_stu_rem";
         this.b_stu_rem.Size = new System.Drawing.Size(75, 23);
         this.b_stu_rem.TabIndex = 5;
         this.b_stu_rem.Text = "Remove";
         this.b_stu_rem.UseVisualStyleBackColor = true;
         this.b_stu_rem.Click += new System.EventHandler(this.b_stu_rem_Click);
         // 
         // b_stu_upd
         // 
         this.b_stu_upd.Location = new System.Drawing.Point(3, 114);
         this.b_stu_upd.Name = "b_stu_upd";
         this.b_stu_upd.Size = new System.Drawing.Size(75, 23);
         this.b_stu_upd.TabIndex = 4;
         this.b_stu_upd.Text = "Update";
         this.b_stu_upd.UseVisualStyleBackColor = true;
         this.b_stu_upd.Click += new System.EventHandler(this.b_stu_upd_Click);
         // 
         // b_stu_add
         // 
         this.b_stu_add.Location = new System.Drawing.Point(42, 85);
         this.b_stu_add.Name = "b_stu_add";
         this.b_stu_add.Size = new System.Drawing.Size(75, 23);
         this.b_stu_add.TabIndex = 3;
         this.b_stu_add.Text = "Add";
         this.b_stu_add.UseVisualStyleBackColor = true;
         this.b_stu_add.Click += new System.EventHandler(this.b_stu_add_Click);
         // 
         // o_tea
         // 
         this.o_tea.AllowUserToAddRows = false;
         this.o_tea.AllowUserToDeleteRows = false;
         this.o_tea.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.o_tea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.o_tea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
         this.o_tea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.o_tea.Location = new System.Drawing.Point(185, 12);
         this.o_tea.Name = "o_tea";
         this.o_tea.Size = new System.Drawing.Size(262, 153);
         this.o_tea.TabIndex = 5;
         this.o_tea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.o_tea_CellClick);
         // 
         // o_stu
         // 
         this.o_stu.AllowUserToAddRows = false;
         this.o_stu.AllowUserToDeleteRows = false;
         this.o_stu.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.o_stu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.o_stu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
         this.o_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.o_stu.Location = new System.Drawing.Point(185, 171);
         this.o_stu.Name = "o_stu";
         this.o_stu.Size = new System.Drawing.Size(262, 145);
         this.o_stu.TabIndex = 5;
         this.o_stu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.o_stu_CellClick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(459, 327);
         this.Controls.Add(this.o_stu);
         this.Controls.Add(this.o_tea);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.o_tea)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.o_stu)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox i_tea_name;
      private System.Windows.Forms.Button b_tea_add;
      private System.Windows.Forms.DateTimePicker i_tea_bday;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.CheckBox i_stu_grad;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox i_stu_name;
      private System.Windows.Forms.Button b_tea_rem;
      private System.Windows.Forms.Button b_tea_upd;
      private System.Windows.Forms.Button b_stu_rem;
      private System.Windows.Forms.Button b_stu_upd;
      private System.Windows.Forms.Button b_stu_add;
      private System.Windows.Forms.DataGridView o_tea;
      private System.Windows.Forms.DataGridView o_stu;
   }
}

