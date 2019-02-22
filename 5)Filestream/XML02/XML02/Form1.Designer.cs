namespace XML02 {
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
         this.label1 = new System.Windows.Forms.Label();
         this.input_BrandName = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.input_Model = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.input_EngCap = new System.Windows.Forms.TextBox();
         this.btn_add = new System.Windows.Forms.Button();
         this.output = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(32, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Brand:";
         // 
         // input_BrandName
         // 
         this.input_BrandName.Location = new System.Drawing.Point(76, 12);
         this.input_BrandName.Name = "input_BrandName";
         this.input_BrandName.Size = new System.Drawing.Size(100, 20);
         this.input_BrandName.TabIndex = 1;
         this.input_BrandName.Text = "Audi";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(31, 41);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Model:";
         // 
         // input_Model
         // 
         this.input_Model.Location = new System.Drawing.Point(76, 38);
         this.input_Model.Name = "input_Model";
         this.input_Model.Size = new System.Drawing.Size(100, 20);
         this.input_Model.TabIndex = 2;
         this.input_Model.Text = "S4";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(5, 67);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(65, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Engine Cap:";
         // 
         // input_EngCap
         // 
         this.input_EngCap.Location = new System.Drawing.Point(76, 64);
         this.input_EngCap.Name = "input_EngCap";
         this.input_EngCap.Size = new System.Drawing.Size(100, 20);
         this.input_EngCap.TabIndex = 3;
         this.input_EngCap.Text = "2000";
         // 
         // btn_add
         // 
         this.btn_add.Location = new System.Drawing.Point(59, 105);
         this.btn_add.Name = "btn_add";
         this.btn_add.Size = new System.Drawing.Size(75, 23);
         this.btn_add.TabIndex = 4;
         this.btn_add.Text = "Add";
         this.btn_add.UseVisualStyleBackColor = true;
         this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
         // 
         // output
         // 
         this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.output.Location = new System.Drawing.Point(208, 9);
         this.output.Name = "output";
         this.output.Size = new System.Drawing.Size(231, 220);
         this.output.TabIndex = 3;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(451, 238);
         this.Controls.Add(this.output);
         this.Controls.Add(this.btn_add);
         this.Controls.Add(this.input_EngCap);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.input_Model);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.input_BrandName);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox input_BrandName;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox input_Model;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox input_EngCap;
      private System.Windows.Forms.Button btn_add;
      private System.Windows.Forms.Label output;
   }
}

