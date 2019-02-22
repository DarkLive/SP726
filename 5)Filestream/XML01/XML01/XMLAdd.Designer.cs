namespace XML01 {
   partial class XMLAdd {
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
         this.btn_add = new System.Windows.Forms.Button();
         this.input_studentno = new System.Windows.Forms.TextBox();
         this.input_studentname = new System.Windows.Forms.TextBox();
         this.input_studentclass = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.input_studentbirthday = new System.Windows.Forms.DateTimePicker();
         this.SuspendLayout();
         // 
         // btn_add
         // 
         this.btn_add.Location = new System.Drawing.Point(81, 124);
         this.btn_add.Name = "btn_add";
         this.btn_add.Size = new System.Drawing.Size(75, 23);
         this.btn_add.TabIndex = 5;
         this.btn_add.Text = "Add";
         this.btn_add.UseVisualStyleBackColor = true;
         this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
         // 
         // input_studentno
         // 
         this.input_studentno.Location = new System.Drawing.Point(80, 12);
         this.input_studentno.Name = "input_studentno";
         this.input_studentno.Size = new System.Drawing.Size(100, 20);
         this.input_studentno.TabIndex = 1;
         // 
         // input_studentname
         // 
         this.input_studentname.Location = new System.Drawing.Point(80, 38);
         this.input_studentname.Name = "input_studentname";
         this.input_studentname.Size = new System.Drawing.Size(100, 20);
         this.input_studentname.TabIndex = 2;
         // 
         // input_studentclass
         // 
         this.input_studentclass.Location = new System.Drawing.Point(80, 64);
         this.input_studentclass.Name = "input_studentclass";
         this.input_studentclass.Size = new System.Drawing.Size(100, 20);
         this.input_studentclass.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(36, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Name:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(50, 15);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(24, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "No:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(39, 67);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(35, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Class:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(26, 93);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(48, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "Birthday:";
         // 
         // input_studentbirthday
         // 
         this.input_studentbirthday.CustomFormat = "dd / MM / yyyy";
         this.input_studentbirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.input_studentbirthday.Location = new System.Drawing.Point(81, 93);
         this.input_studentbirthday.Name = "input_studentbirthday";
         this.input_studentbirthday.Size = new System.Drawing.Size(99, 20);
         this.input_studentbirthday.TabIndex = 4;
         // 
         // XMLAdd
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(226, 170);
         this.Controls.Add(this.input_studentbirthday);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.input_studentclass);
         this.Controls.Add(this.input_studentname);
         this.Controls.Add(this.input_studentno);
         this.Controls.Add(this.btn_add);
         this.Name = "XMLAdd";
         this.Text = "XMLAdd";
         this.Load += new System.EventHandler(this.XMLAdd_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btn_add;
      private System.Windows.Forms.TextBox input_studentno;
      private System.Windows.Forms.TextBox input_studentname;
      private System.Windows.Forms.TextBox input_studentclass;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.DateTimePicker input_studentbirthday;
   }
}