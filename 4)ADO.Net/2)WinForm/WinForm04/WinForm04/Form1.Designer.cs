namespace WinForm04 {
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.namebox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btn_Add = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.surnamebox = new System.Windows.Forms.TextBox();
         this.citybox = new System.Windows.Forms.ComboBox();
         this.btn_Update = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.dataGridView1.Location = new System.Drawing.Point(12, 93);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(437, 135);
         this.dataGridView1.TabIndex = 0;
         this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
         // 
         // namebox
         // 
         this.namebox.Location = new System.Drawing.Point(20, 48);
         this.namebox.Name = "namebox";
         this.namebox.Size = new System.Drawing.Size(100, 20);
         this.namebox.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(17, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Name";
         // 
         // btn_Add
         // 
         this.btn_Add.Location = new System.Drawing.Point(338, 32);
         this.btn_Add.Name = "btn_Add";
         this.btn_Add.Size = new System.Drawing.Size(75, 23);
         this.btn_Add.TabIndex = 4;
         this.btn_Add.Text = "Add";
         this.btn_Add.UseVisualStyleBackColor = true;
         this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(123, 32);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(49, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Surname";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(232, 32);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(24, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "City";
         // 
         // surnamebox
         // 
         this.surnamebox.Location = new System.Drawing.Point(126, 48);
         this.surnamebox.Name = "surnamebox";
         this.surnamebox.Size = new System.Drawing.Size(100, 20);
         this.surnamebox.TabIndex = 2;
         // 
         // citybox
         // 
         this.citybox.FormattingEnabled = true;
         this.citybox.Items.AddRange(new object[] {
            "Ankara",
            "Bingöl",
            "Erzurum",
            "Giresun",
            "İstanbul",
            "Kayseri",
            "Sivas"});
         this.citybox.Location = new System.Drawing.Point(232, 48);
         this.citybox.Name = "citybox";
         this.citybox.Size = new System.Drawing.Size(100, 21);
         this.citybox.Sorted = true;
         this.citybox.TabIndex = 3;
         // 
         // btn_Update
         // 
         this.btn_Update.Location = new System.Drawing.Point(338, 61);
         this.btn_Update.Name = "btn_Update";
         this.btn_Update.Size = new System.Drawing.Size(75, 23);
         this.btn_Update.TabIndex = 4;
         this.btn_Update.Text = "Update";
         this.btn_Update.UseVisualStyleBackColor = true;
         this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(461, 240);
         this.Controls.Add(this.citybox);
         this.Controls.Add(this.btn_Update);
         this.Controls.Add(this.btn_Add);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.surnamebox);
         this.Controls.Add(this.namebox);
         this.Controls.Add(this.dataGridView1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.TextBox namebox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btn_Add;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox surnamebox;
      private System.Windows.Forms.ComboBox citybox;
      private System.Windows.Forms.Button btn_Update;
   }
}

