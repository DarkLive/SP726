namespace WinFormsHomework01 {
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
         this.input_number = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.input_faculty = new System.Windows.Forms.ComboBox();
         this.input_fullname = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.input_programs = new System.Windows.Forms.ComboBox();
         this.grid_student = new System.Windows.Forms.DataGridView();
         this.addbtn = new System.Windows.Forms.Button();
         this.updbtn = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.grid_student)).BeginInit();
         this.SuspendLayout();
         // 
         // input_number
         // 
         this.input_number.Location = new System.Drawing.Point(125, 64);
         this.input_number.Name = "input_number";
         this.input_number.Size = new System.Drawing.Size(100, 20);
         this.input_number.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(69, 67);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(50, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Number: ";
         // 
         // input_faculty
         // 
         this.input_faculty.FormattingEnabled = true;
         this.input_faculty.Items.AddRange(new object[] {
            "Distance Education",
            "Graduate Faculty",
            "Undergraduate Education"});
         this.input_faculty.Location = new System.Drawing.Point(125, 143);
         this.input_faculty.Name = "input_faculty";
         this.input_faculty.Size = new System.Drawing.Size(100, 21);
         this.input_faculty.Sorted = true;
         this.input_faculty.TabIndex = 4;
         // 
         // input_fullname
         // 
         this.input_fullname.Location = new System.Drawing.Point(125, 90);
         this.input_fullname.Name = "input_fullname";
         this.input_fullname.Size = new System.Drawing.Size(100, 20);
         this.input_fullname.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(59, 93);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(60, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Full Name: ";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(62, 119);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(57, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Programs: ";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(72, 146);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(47, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Faculty: ";
         // 
         // input_programs
         // 
         this.input_programs.FormattingEnabled = true;
         this.input_programs.Items.AddRange(new object[] {
            "Aerospace Science and Engineering",
            "Architecture",
            "Biochemistry",
            "Programming"});
         this.input_programs.Location = new System.Drawing.Point(125, 116);
         this.input_programs.Name = "input_programs";
         this.input_programs.Size = new System.Drawing.Size(100, 21);
         this.input_programs.Sorted = true;
         this.input_programs.TabIndex = 3;
         // 
         // grid_student
         // 
         this.grid_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.grid_student.Location = new System.Drawing.Point(295, 12);
         this.grid_student.MultiSelect = false;
         this.grid_student.Name = "grid_student";
         this.grid_student.Size = new System.Drawing.Size(493, 426);
         this.grid_student.TabIndex = 3;
         this.grid_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_student_CellClick);
         // 
         // addbtn
         // 
         this.addbtn.Location = new System.Drawing.Point(62, 180);
         this.addbtn.Name = "addbtn";
         this.addbtn.Size = new System.Drawing.Size(75, 23);
         this.addbtn.TabIndex = 5;
         this.addbtn.Text = "Add";
         this.addbtn.UseVisualStyleBackColor = true;
         this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
         // 
         // updbtn
         // 
         this.updbtn.Location = new System.Drawing.Point(143, 180);
         this.updbtn.Name = "updbtn";
         this.updbtn.Size = new System.Drawing.Size(75, 23);
         this.updbtn.TabIndex = 6;
         this.updbtn.Text = "Update";
         this.updbtn.UseVisualStyleBackColor = true;
         this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.updbtn);
         this.Controls.Add(this.addbtn);
         this.Controls.Add(this.grid_student);
         this.Controls.Add(this.input_programs);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.input_faculty);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.input_fullname);
         this.Controls.Add(this.input_number);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.grid_student)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox input_faculty;
        private System.Windows.Forms.TextBox input_fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox input_programs;
        private System.Windows.Forms.DataGridView grid_student;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updbtn;
    }
}

