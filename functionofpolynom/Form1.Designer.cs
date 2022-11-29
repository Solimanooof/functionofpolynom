namespace functionofpolynom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_getPolynom = new System.Windows.Forms.Button();
            this.richTextBoxPolynoem = new System.Windows.Forms.RichTextBox();
            this.textBox_Anzahl = new System.Windows.Forms.TextBox();
            this.btn_Anzahleingeben = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToAddRows = false;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.GridView1.Location = new System.Drawing.Point(206, 49);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowHeadersWidth = 51;
            this.GridView1.RowTemplate.Height = 29;
            this.GridView1.Size = new System.Drawing.Size(432, 303);
            this.GridView1.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 125;
            // 
            // btn_getPolynom
            // 
            this.btn_getPolynom.Location = new System.Drawing.Point(274, 406);
            this.btn_getPolynom.Name = "btn_getPolynom";
            this.btn_getPolynom.Size = new System.Drawing.Size(261, 29);
            this.btn_getPolynom.TabIndex = 1;
            this.btn_getPolynom.Text = "Berechnen";
            this.btn_getPolynom.UseVisualStyleBackColor = true;
            this.btn_getPolynom.Click += new System.EventHandler(this.btn_getPolynom_Click);
            // 
            // richTextBoxPolynoem
            // 
            this.richTextBoxPolynoem.Location = new System.Drawing.Point(206, 468);
            this.richTextBoxPolynoem.Name = "richTextBoxPolynoem";
            this.richTextBoxPolynoem.Size = new System.Drawing.Size(432, 183);
            this.richTextBoxPolynoem.TabIndex = 2;
            this.richTextBoxPolynoem.Text = "";
            // 
            // textBox_Anzahl
            // 
            this.textBox_Anzahl.Location = new System.Drawing.Point(681, 92);
            this.textBox_Anzahl.Name = "textBox_Anzahl";
            this.textBox_Anzahl.Size = new System.Drawing.Size(145, 27);
            this.textBox_Anzahl.TabIndex = 3;
            // 
            // btn_Anzahleingeben
            // 
            this.btn_Anzahleingeben.Location = new System.Drawing.Point(682, 150);
            this.btn_Anzahleingeben.Name = "btn_Anzahleingeben";
            this.btn_Anzahleingeben.Size = new System.Drawing.Size(144, 29);
            this.btn_Anzahleingeben.TabIndex = 4;
            this.btn_Anzahleingeben.Text = "Anzahl eingeben";
            this.btn_Anzahleingeben.UseVisualStyleBackColor = true;
            this.btn_Anzahleingeben.Click += new System.EventHandler(this.btn_Anzahleingeben_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 761);
            this.Controls.Add(this.btn_Anzahleingeben);
            this.Controls.Add(this.textBox_Anzahl);
            this.Controls.Add(this.richTextBoxPolynoem);
            this.Controls.Add(this.btn_getPolynom);
            this.Controls.Add(this.GridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button btn_getPolynom;
        private System.Windows.Forms.RichTextBox richTextBoxPolynoem;
        private System.Windows.Forms.TextBox textBox_Anzahl;
        private System.Windows.Forms.Button btn_Anzahleingeben;
    }
}
