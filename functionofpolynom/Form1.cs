using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace functionofpolynom
{
    public partial class Form1 : Form
    {
        public int AnzalderWerten;

        public Form1()
        {
            InitializeComponent();
        }



        private void btn_Anzahleingeben_Click(object sender, EventArgs e)
        {
            GridView1.Rows.Clear();
            if (textBox_Anzahl.Text != null)
            {
                AnzalderWerten = int.Parse(textBox_Anzahl.Text);
                for (int i = 0; i < AnzalderWerten; i++)
                {
                    this.GridView1.Rows.Add();
                }

            }
        }

        private void btn_getPolynom_Click(object sender, EventArgs e)
        {
            
            double[] XWerten = new double[AnzalderWerten];
            double[] YWerten = new double[AnzalderWerten];
            int i = 0;
            foreach (DataGridViewRow row in GridView1.Rows)
            {
                XWerten[i] = double.Parse(row.Cells[0].Value.ToString());
                YWerten[i] = double.Parse(row.Cells[1].Value.ToString());
                i++;
            }


            rechnungvonzahler rechnen= new rechnungvonzahler();
            rechnen.LagrangeMethode(XWerten, YWerten);
            richTextBoxPolynoem.Text = rechnen.erg();
            
          
        }




    }
}
