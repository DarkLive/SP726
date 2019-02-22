namespace WinForm01 {
   partial class Form_MainScreen {
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainScreen));
         this.label_PunchLine = new System.Windows.Forms.Label();
         this.txt_Name = new System.Windows.Forms.TextBox();
         this.label_Name = new System.Windows.Forms.Label();
         this.txt_Surname = new System.Windows.Forms.TextBox();
         this.label_Birthday = new System.Windows.Forms.Label();
         this.btn_Register = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label_id = new System.Windows.Forms.Label();
         this.txt_id = new System.Windows.Forms.TextBox();
         this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
         this.label_Surname = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label_PunchLine
         // 
         this.label_PunchLine.AutoSize = true;
         this.label_PunchLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.label_PunchLine.Location = new System.Drawing.Point(59, 19);
         this.label_PunchLine.Name = "label_PunchLine";
         this.label_PunchLine.Size = new System.Drawing.Size(149, 22);
         this.label_PunchLine.TabIndex = 0;
         this.label_PunchLine.Text = "User Registration";
         // 
         // txt_Name
         // 
         this.txt_Name.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.txt_Name.Location = new System.Drawing.Point(80, 109);
         this.txt_Name.Name = "txt_Name";
         this.txt_Name.Size = new System.Drawing.Size(100, 29);
         this.txt_Name.TabIndex = 2;
         // 
         // label_Name
         // 
         this.label_Name.AutoSize = true;
         this.label_Name.Location = new System.Drawing.Point(29, 119);
         this.label_Name.Name = "label_Name";
         this.label_Name.Size = new System.Drawing.Size(45, 14);
         this.label_Name.TabIndex = 2;
         this.label_Name.Text = "Name:";
         // 
         // txt_Surname
         // 
         this.txt_Surname.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.txt_Surname.Location = new System.Drawing.Point(80, 154);
         this.txt_Surname.Name = "txt_Surname";
         this.txt_Surname.Size = new System.Drawing.Size(100, 29);
         this.txt_Surname.TabIndex = 3;
         // 
         // label_Birthday
         // 
         this.label_Birthday.AutoSize = true;
         this.label_Birthday.Location = new System.Drawing.Point(11, 201);
         this.label_Birthday.Name = "label_Birthday";
         this.label_Birthday.Size = new System.Drawing.Size(63, 14);
         this.label_Birthday.TabIndex = 2;
         this.label_Birthday.Text = "Birthday:";
         // 
         // btn_Register
         // 
         this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.btn_Register.Location = new System.Drawing.Point(91, 238);
         this.btn_Register.Name = "btn_Register";
         this.btn_Register.Size = new System.Drawing.Size(79, 37);
         this.btn_Register.TabIndex = 5;
         this.btn_Register.Text = "Register";
         this.btn_Register.UseVisualStyleBackColor = true;
         this.btn_Register.Click += new System.EventHandler(this.btn_register_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(244, 9);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(367, 308);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 4;
         this.pictureBox1.TabStop = false;
         // 
         // label_id
         // 
         this.label_id.AutoSize = true;
         this.label_id.Location = new System.Drawing.Point(51, 71);
         this.label_id.Name = "label_id";
         this.label_id.Size = new System.Drawing.Size(23, 14);
         this.label_id.TabIndex = 13;
         this.label_id.Text = "ID:";
         // 
         // txt_id
         // 
         this.txt_id.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.txt_id.Location = new System.Drawing.Point(80, 61);
         this.txt_id.Name = "txt_id";
         this.txt_id.Size = new System.Drawing.Size(100, 29);
         this.txt_id.TabIndex = 1;
         // 
         // dtp_Birthday
         // 
         this.dtp_Birthday.CalendarFont = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtp_Birthday.CustomFormat = " dd / MM / yyyy";
         this.dtp_Birthday.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtp_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtp_Birthday.Location = new System.Drawing.Point(80, 199);
         this.dtp_Birthday.Name = "dtp_Birthday";
         this.dtp_Birthday.ShowUpDown = true;
         this.dtp_Birthday.Size = new System.Drawing.Size(90, 20);
         this.dtp_Birthday.TabIndex = 4;
         // 
         // label_Surname
         // 
         this.label_Surname.AutoSize = true;
         this.label_Surname.Location = new System.Drawing.Point(12, 164);
         this.label_Surname.Name = "label_Surname";
         this.label_Surname.Size = new System.Drawing.Size(61, 14);
         this.label_Surname.TabIndex = 2;
         this.label_Surname.Text = "Surname";
         // 
         // Form_MainScreen
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(618, 325);
         this.Controls.Add(this.dtp_Birthday);
         this.Controls.Add(this.label_id);
         this.Controls.Add(this.btn_Register);
         this.Controls.Add(this.label_Surname);
         this.Controls.Add(this.label_Birthday);
         this.Controls.Add(this.label_Name);
         this.Controls.Add(this.txt_Surname);
         this.Controls.Add(this.txt_id);
         this.Controls.Add(this.txt_Name);
         this.Controls.Add(this.label_PunchLine);
         this.Controls.Add(this.pictureBox1);
         this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Form_MainScreen";
         this.Text = "404 First Form";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txt_Name;
      private System.Windows.Forms.TextBox txt_Surname;
      private System.Windows.Forms.TextBox txt_id;
      private System.Windows.Forms.DateTimePicker dtp_Birthday;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label_Surname;
      private System.Windows.Forms.Label label_id;
      private System.Windows.Forms.Label label_Birthday;
      private System.Windows.Forms.Label label_Name;
      private System.Windows.Forms.Label label_PunchLine;
      private System.Windows.Forms.Button btn_Register;
   }
}

