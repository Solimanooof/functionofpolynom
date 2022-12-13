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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxNewton = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Newton_berechnen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.GridView1.Location = new System.Drawing.Point(362, 47);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowHeadersWidth = 51;
            this.GridView1.RowTemplate.Height = 29;
            this.GridView1.Size = new System.Drawing.Size(550, 303);
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
            this.btn_getPolynom.Location = new System.Drawing.Point(457, 397);
            this.btn_getPolynom.Name = "btn_getPolynom";
            this.btn_getPolynom.Size = new System.Drawing.Size(261, 29);
            this.btn_getPolynom.TabIndex = 1;
            this.btn_getPolynom.Text = "Langrange Berechnen";
            this.btn_getPolynom.UseVisualStyleBackColor = true;
            this.btn_getPolynom.Click += new System.EventHandler(this.btn_getPolynom_Click);
            // 
            // richTextBoxPolynoem
            // 
            this.richTextBoxPolynoem.Location = new System.Drawing.Point(389, 460);
            this.richTextBoxPolynoem.Name = "richTextBoxPolynoem";
            this.richTextBoxPolynoem.Size = new System.Drawing.Size(431, 183);
            this.richTextBoxPolynoem.TabIndex = 2;
            this.richTextBoxPolynoem.Text = "";
            // 
            // textBox_Anzahl
            // 
            this.textBox_Anzahl.Location = new System.Drawing.Point(996, 118);
            this.textBox_Anzahl.Name = "textBox_Anzahl";
            this.textBox_Anzahl.Size = new System.Drawing.Size(214, 27);
            this.textBox_Anzahl.TabIndex = 3;
            // 
            // btn_Anzahleingeben
            // 
            this.btn_Anzahleingeben.Location = new System.Drawing.Point(996, 181);
            this.btn_Anzahleingeben.Name = "btn_Anzahleingeben";
            this.btn_Anzahleingeben.Size = new System.Drawing.Size(192, 29);
            this.btn_Anzahleingeben.TabIndex = 4;
            this.btn_Anzahleingeben.Text = "Anzahl eingeben";
            this.btn_Anzahleingeben.UseVisualStyleBackColor = true;
            this.btn_Anzahleingeben.Click += new System.EventHandler(this.btn_Anzahleingeben_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basis von Lagrange";
            // 
            // richTextBoxNewton
            // 
            this.richTextBoxNewton.Location = new System.Drawing.Point(389, 733);
            this.richTextBoxNewton.Name = "richTextBoxNewton";
            this.richTextBoxNewton.Size = new System.Drawing.Size(431, 171);
            this.richTextBoxNewton.TabIndex = 6;
            this.richTextBoxNewton.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 811);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Basis von Newton";
            // 
            // btn_Newton_berechnen
            // 
            this.btn_Newton_berechnen.Location = new System.Drawing.Point(457, 671);
            this.btn_Newton_berechnen.Name = "btn_Newton_berechnen";
            this.btn_Newton_berechnen.Size = new System.Drawing.Size(261, 29);
            this.btn_Newton_berechnen.TabIndex = 8;
            this.btn_Newton_berechnen.Text = "Newton berechnen";
            this.btn_Newton_berechnen.UseVisualStyleBackColor = true;
            this.btn_Newton_berechnen.Click += new System.EventHandler(this.btn_Newton_berechnen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(996, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "in diesem Textbox nur Int eingeben";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "wenn keine Werte geben Sie bitte 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 980);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Newton_berechnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxNewton);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btn_getPolynom;
        private System.Windows.Forms.RichTextBox richTextBoxPolynoem;
        private System.Windows.Forms.TextBox textBox_Anzahl;
        private System.Windows.Forms.Button btn_Anzahleingeben;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxNewton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Newton_berechnen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}
