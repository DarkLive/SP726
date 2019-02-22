namespace LINQ01 {
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
         this.output = new System.Windows.Forms.DataGridView();
         this.input_no = new System.Windows.Forms.TextBox();
         this.input_name = new System.Windows.Forms.TextBox();
         this.input_program = new System.Windows.Forms.TextBox();
         this.input_faculty = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.btn_add = new System.Windows.Forms.Button();
         this.btn_upd = new System.Windows.Forms.Button();
         this.btn_remove = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
         this.SuspendLayout();
         // 
         // output
         // 
         this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.output.Location = new System.Drawing.Point(13, 13);
         this.output.Name = "output";
         this.output.Size = new System.Drawing.Size(385, 211);
         this.output.TabIndex = 0;
         this.output.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.output_CellClick);
         // 
         // input_no
         // 
         this.input_no.Location = new System.Drawing.Point(75, 258);
         this.input_no.Name = "input_no";
         this.input_no.Size = new System.Drawing.Size(136, 20);
         this.input_no.TabIndex = 1;
         // 
         // input_name
         // 
         this.input_name.Location = new System.Drawing.Point(74, 284);
         this.input_name.Name = "input_name";
         this.input_name.Size = new System.Drawing.Size(136, 20);
         this.input_name.TabIndex = 2;
         // 
         // input_program
         // 
         this.input_program.Location = new System.Drawing.Point(74, 310);
         this.input_program.Name = "input_program";
         this.input_program.Size = new System.Drawing.Size(136, 20);
         this.input_program.TabIndex = 3;
         // 
         // input_faculty
         // 
         this.input_faculty.Location = new System.Drawing.Point(74, 336);
         this.input_faculty.Name = "input_faculty";
         this.input_faculty.Size = new System.Drawing.Size(136, 20);
         this.input_faculty.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(20, 314);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(49, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Program:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(31, 287);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(38, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Name:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(25, 339);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(44, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Faculty:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(45, 261);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(24, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "No:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(101, 238);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(44, 13);
         this.label5.TabIndex = 2;
         this.label5.Text = "Student";
         // 
         // btn_add
         // 
         this.btn_add.Location = new System.Drawing.Point(265, 261);
         this.btn_add.Name = "btn_add";
         this.btn_add.Size = new System.Drawing.Size(75, 23);
         this.btn_add.TabIndex = 5;
         this.btn_add.Text = "Add";
         this.btn_add.UseVisualStyleBackColor = true;
         this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
         // 
         // btn_upd
         // 
         this.btn_upd.Location = new System.Drawing.Point(265, 290);
         this.btn_upd.Name = "btn_upd";
         this.btn_upd.Size = new System.Drawing.Size(75, 23);
         this.btn_upd.TabIndex = 6;
         this.btn_upd.Text = "Update";
         this.btn_upd.UseVisualStyleBackColor = true;
         this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
         // 
         // btn_remove
         // 
         this.btn_remove.Location = new System.Drawing.Point(265, 319);
         this.btn_remove.Name = "btn_remove";
         this.btn_remove.Size = new System.Drawing.Size(75, 23);
         this.btn_remove.TabIndex = 7;
         this.btn_remove.Text = "Delete";
         this.btn_remove.UseVisualStyleBackColor = true;
         this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(410, 374);
         this.Controls.Add(this.btn_remove);
         this.Controls.Add(this.btn_upd);
         this.Controls.Add(this.btn_add);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.input_faculty);
         this.Controls.Add(this.input_program);
         this.Controls.Add(this.input_name);
         this.Controls.Add(this.input_no);
         this.Controls.Add(this.output);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView output;
      private System.Windows.Forms.TextBox input_no;
      private System.Windows.Forms.TextBox input_name;
      private System.Windows.Forms.TextBox input_program;
      private System.Windows.Forms.TextBox input_faculty;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btn_add;
      private System.Windows.Forms.Button btn_upd;
      private System.Windows.Forms.Button btn_remove;
   }
}

