namespace WinForm03 {
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
         this.tb_uName = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btn_login = new System.Windows.Forms.Button();
         this.tb_uPass = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // tb_uName
         // 
         this.tb_uName.Location = new System.Drawing.Point(120, 34);
         this.tb_uName.Name = "tb_uName";
         this.tb_uName.Size = new System.Drawing.Size(100, 20);
         this.tb_uName.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(54, 37);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(63, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "User Name:";
         // 
         // btn_login
         // 
         this.btn_login.Location = new System.Drawing.Point(109, 115);
         this.btn_login.Name = "btn_login";
         this.btn_login.Size = new System.Drawing.Size(75, 23);
         this.btn_login.TabIndex = 3;
         this.btn_login.Text = "Login";
         this.btn_login.UseVisualStyleBackColor = true;
         this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
         // 
         // tb_uPass
         // 
         this.tb_uPass.Location = new System.Drawing.Point(120, 63);
         this.tb_uPass.Name = "tb_uPass";
         this.tb_uPass.PasswordChar = '*';
         this.tb_uPass.Size = new System.Drawing.Size(100, 20);
         this.tb_uPass.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(58, 66);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Password:";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 160);
         this.Controls.Add(this.btn_login);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.tb_uPass);
         this.Controls.Add(this.tb_uName);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tb_uName;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btn_login;
      private System.Windows.Forms.TextBox tb_uPass;
      private System.Windows.Forms.Label label2;
   }
}

