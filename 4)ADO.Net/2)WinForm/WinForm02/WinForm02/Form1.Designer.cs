namespace WinForm02 {
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
         this.stuNo = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.stuCourse = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.stuMid = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.stuEnd = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.calcButton = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // stuNo
         // 
         this.stuNo.Location = new System.Drawing.Point(155, 34);
         this.stuNo.Name = "stuNo";
         this.stuNo.Size = new System.Drawing.Size(100, 20);
         this.stuNo.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(85, 37);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(64, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Student No:";
         // 
         // stuCourse
         // 
         this.stuCourse.Location = new System.Drawing.Point(155, 60);
         this.stuCourse.Name = "stuCourse";
         this.stuCourse.Size = new System.Drawing.Size(100, 20);
         this.stuCourse.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(66, 63);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(83, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Student Course:";
         // 
         // stuMid
         // 
         this.stuMid.Location = new System.Drawing.Point(155, 86);
         this.stuMid.Name = "stuMid";
         this.stuMid.Size = new System.Drawing.Size(100, 20);
         this.stuMid.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(26, 89);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(123, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Student Mid Term Exam:";
         // 
         // stuEnd
         // 
         this.stuEnd.Location = new System.Drawing.Point(155, 112);
         this.stuEnd.Name = "stuEnd";
         this.stuEnd.Size = new System.Drawing.Size(100, 20);
         this.stuEnd.TabIndex = 4;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(24, 115);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(125, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "Student End Term Exam:";
         // 
         // calcButton
         // 
         this.calcButton.Location = new System.Drawing.Point(105, 142);
         this.calcButton.Name = "calcButton";
         this.calcButton.Size = new System.Drawing.Size(75, 23);
         this.calcButton.TabIndex = 5;
         this.calcButton.Text = "Calculate";
         this.calcButton.UseVisualStyleBackColor = true;
         this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(102, 9);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(85, 13);
         this.label5.TabIndex = 1;
         this.label5.Text = "SCHOOL NAME";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 177);
         this.Controls.Add(this.calcButton);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.stuEnd);
         this.Controls.Add(this.stuMid);
         this.Controls.Add(this.stuCourse);
         this.Controls.Add(this.stuNo);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox stuNo;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox stuCourse;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox stuMid;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox stuEnd;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button calcButton;
      private System.Windows.Forms.Label label5;
   }
}

