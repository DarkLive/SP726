namespace XML01 {
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
         this.xmlInfoListBox = new System.Windows.Forms.ListBox();
         this.input_stuno = new System.Windows.Forms.TextBox();
         this.btn_add = new System.Windows.Forms.Button();
         this.newpage = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // xmlInfoListBox
         // 
         this.xmlInfoListBox.FormattingEnabled = true;
         this.xmlInfoListBox.Location = new System.Drawing.Point(152, 12);
         this.xmlInfoListBox.Name = "xmlInfoListBox";
         this.xmlInfoListBox.Size = new System.Drawing.Size(293, 238);
         this.xmlInfoListBox.TabIndex = 1;
         // 
         // input_stuno
         // 
         this.input_stuno.Location = new System.Drawing.Point(12, 12);
         this.input_stuno.Name = "input_stuno";
         this.input_stuno.Size = new System.Drawing.Size(122, 20);
         this.input_stuno.TabIndex = 2;
         // 
         // btn_add
         // 
         this.btn_add.Location = new System.Drawing.Point(37, 38);
         this.btn_add.Name = "btn_add";
         this.btn_add.Size = new System.Drawing.Size(75, 23);
         this.btn_add.TabIndex = 3;
         this.btn_add.Text = "Add";
         this.btn_add.UseVisualStyleBackColor = true;
         this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
         // 
         // newpage
         // 
         this.newpage.Location = new System.Drawing.Point(12, 213);
         this.newpage.Name = "newpage";
         this.newpage.Size = new System.Drawing.Size(122, 36);
         this.newpage.TabIndex = 3;
         this.newpage.Text = "Open Register";
         this.newpage.UseVisualStyleBackColor = true;
         this.newpage.Click += new System.EventHandler(this.newpage_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(457, 261);
         this.Controls.Add(this.newpage);
         this.Controls.Add(this.btn_add);
         this.Controls.Add(this.input_stuno);
         this.Controls.Add(this.xmlInfoListBox);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ListBox xmlInfoListBox;
      private System.Windows.Forms.TextBox input_stuno;
      private System.Windows.Forms.Button btn_add;
      private System.Windows.Forms.Button newpage;
   }
}

