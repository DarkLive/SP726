namespace LINQ02 {
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
         this.input_MovName = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btn_add_mov = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.btn_add_the = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.input_TheName = new System.Windows.Forms.TextBox();
         this.panel3 = new System.Windows.Forms.Panel();
         this.input_cb_mov = new System.Windows.Forms.ComboBox();
         this.input_cb_the = new System.Windows.Forms.ComboBox();
         this.input_airdate = new System.Windows.Forms.DateTimePicker();
         this.btn_add_air = new System.Windows.Forms.Button();
         this.label9 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.output = new System.Windows.Forms.DataGridView();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.panel3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
         this.SuspendLayout();
         // 
         // input_MovName
         // 
         this.input_MovName.Location = new System.Drawing.Point(45, 30);
         this.input_MovName.Name = "input_MovName";
         this.input_MovName.Size = new System.Drawing.Size(100, 20);
         this.input_MovName.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(60, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(36, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Movie";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btn_add_mov);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.input_MovName);
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(164, 100);
         this.panel1.TabIndex = 2;
         // 
         // btn_add_mov
         // 
         this.btn_add_mov.Location = new System.Drawing.Point(43, 67);
         this.btn_add_mov.Name = "btn_add_mov";
         this.btn_add_mov.Size = new System.Drawing.Size(75, 23);
         this.btn_add_mov.TabIndex = 0;
         this.btn_add_mov.Text = "Add";
         this.btn_add_mov.UseVisualStyleBackColor = true;
         this.btn_add_mov.Click += new System.EventHandler(this.btn_add_mov_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 33);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(38, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Name:";
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.btn_add_the);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Controls.Add(this.label4);
         this.panel2.Controls.Add(this.input_TheName);
         this.panel2.Location = new System.Drawing.Point(12, 130);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(164, 100);
         this.panel2.TabIndex = 3;
         // 
         // btn_add_the
         // 
         this.btn_add_the.Location = new System.Drawing.Point(43, 67);
         this.btn_add_the.Name = "btn_add_the";
         this.btn_add_the.Size = new System.Drawing.Size(75, 23);
         this.btn_add_the.TabIndex = 0;
         this.btn_add_the.Text = "Add";
         this.btn_add_the.UseVisualStyleBackColor = true;
         this.btn_add_the.Click += new System.EventHandler(this.btn_add_the_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 33);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Name:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(57, 8);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(44, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Theater";
         // 
         // input_TheName
         // 
         this.input_TheName.Location = new System.Drawing.Point(45, 30);
         this.input_TheName.Name = "input_TheName";
         this.input_TheName.Size = new System.Drawing.Size(100, 20);
         this.input_TheName.TabIndex = 0;
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.input_cb_mov);
         this.panel3.Controls.Add(this.input_cb_the);
         this.panel3.Controls.Add(this.input_airdate);
         this.panel3.Controls.Add(this.btn_add_air);
         this.panel3.Controls.Add(this.label9);
         this.panel3.Controls.Add(this.label8);
         this.panel3.Controls.Add(this.label7);
         this.panel3.Controls.Add(this.label6);
         this.panel3.Location = new System.Drawing.Point(191, 12);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(258, 168);
         this.panel3.TabIndex = 4;
         // 
         // input_cb_mov
         // 
         this.input_cb_mov.FormattingEnabled = true;
         this.input_cb_mov.Location = new System.Drawing.Point(72, 29);
         this.input_cb_mov.Name = "input_cb_mov";
         this.input_cb_mov.Size = new System.Drawing.Size(171, 21);
         this.input_cb_mov.TabIndex = 3;
         // 
         // input_cb_the
         // 
         this.input_cb_the.FormattingEnabled = true;
         this.input_cb_the.Location = new System.Drawing.Point(72, 58);
         this.input_cb_the.Name = "input_cb_the";
         this.input_cb_the.Size = new System.Drawing.Size(171, 21);
         this.input_cb_the.TabIndex = 3;
         // 
         // input_airdate
         // 
         this.input_airdate.CustomFormat = "dd / MM / yyyy  |  hh:mm tt";
         this.input_airdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.input_airdate.Location = new System.Drawing.Point(72, 89);
         this.input_airdate.Name = "input_airdate";
         this.input_airdate.Size = new System.Drawing.Size(171, 20);
         this.input_airdate.TabIndex = 2;
         // 
         // btn_add_air
         // 
         this.btn_add_air.Location = new System.Drawing.Point(78, 125);
         this.btn_add_air.Name = "btn_add_air";
         this.btn_add_air.Size = new System.Drawing.Size(75, 23);
         this.btn_add_air.TabIndex = 0;
         this.btn_add_air.Text = "Add";
         this.btn_add_air.UseVisualStyleBackColor = true;
         this.btn_add_air.Click += new System.EventHandler(this.btn_add_air_Click);
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(30, 33);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(39, 13);
         this.label9.TabIndex = 1;
         this.label9.Text = "Movie:";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(22, 62);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(47, 13);
         this.label8.TabIndex = 1;
         this.label8.Text = "Theater:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(5, 92);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(65, 13);
         this.label7.TabIndex = 1;
         this.label7.Text = "Date - Time:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(106, 8);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(33, 13);
         this.label6.TabIndex = 1;
         this.label6.Text = "Airing";
         // 
         // output
         // 
         this.output.AllowUserToAddRows = false;
         this.output.AllowUserToDeleteRows = false;
         this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.output.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.output.Location = new System.Drawing.Point(12, 244);
         this.output.Name = "output";
         this.output.Size = new System.Drawing.Size(437, 134);
         this.output.TabIndex = 5;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(461, 392);
         this.Controls.Add(this.output);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox input_MovName;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btn_add_mov;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button btn_add_the;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox input_TheName;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.ComboBox input_cb_mov;
      private System.Windows.Forms.ComboBox input_cb_the;
      private System.Windows.Forms.DateTimePicker input_airdate;
      private System.Windows.Forms.Button btn_add_air;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.DataGridView output;
   }
}

