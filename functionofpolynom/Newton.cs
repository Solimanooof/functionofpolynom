using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Microsoft.VisualBasic;



namespace functionofpolynom
{
    internal class Newton 
    {
        // das ist genau wie beim Lagrange sollte eine allgemeinge Klassee, aber leider wir haben getrennt gearbeitet
        double[] shouldbelastissue;
        public void addthelengthforlastarray(int num)
        {
            shouldbelastissue = new double[num];
        }


        // diese FUntkion wird auch bei Lagrange benutzt und wird hier kopiert, damit das Lesen des Kodes leicht sein wird
        private double[] polynomialProduct; //zum speichern des temporären Ergebnisses
        // dieses Funktion ist für die Multiplitzieren (X-xi).....(X-xn)
        private void PolynomMultiplicator(double[] multiplicand, double[] multiplier)
        {
            int lenghtProd = polynomialProduct.Length;
            int lengthMultiplier1 = 2;
            double[] prod = new double[lenghtProd + lengthMultiplier1 - 1];
            for (int i = 0; i < lenghtProd; i++)
            {
                for (int j = 0; j < lengthMultiplier1; j++)
                {

                    prod[i + j] += multiplicand[i] * multiplier[j];

                }
            }
            polynomialProduct = prod;
        }



        double[] ydasch;
        double[] collectYdasch;
       
        public void Newtonintepolation(double [] xWerten, double []yWerten)
        {
            
            // im nächsten  Teil wirde y dasch in einem Array gesammelt. 
           collectYdasch= new double[xWerten.Length-1];
            int t = 0;
            for (int i = 0; i < xWerten.Length; i++)
            { int j = 0;

                ydasch = new double[xWerten.Length - (1+i)];

                for (int k = i+1; k < xWerten.Length; k++)
                {
                    if (yWerten[j + 1]!= yWerten[j] && xWerten[k]!= xWerten[j])
                    {
                        ydasch[j] = ((yWerten[j + 1] - yWerten[j]) / (xWerten[k] - xWerten[j]));
                       
                    }
                    else
                    {
                        // hier soll hermit kommen 
                       // ydasch[j] = ableitugn / Fakultät(Ableitungsordnung)
                    }
                    j++;
                }
                if (t < xWerten.Length-1)
                {
                    collectYdasch[t] = ydasch[0];
                }
                
                yWerten = new double[xWerten.Length - i];
                yWerten = ydasch;
                t++;
            }

            
            // hier versuche ich jetzt xwerten
            int g = 1; // wenn fertig versuch zu klären
            for (int s = 0; s < xWerten.Length-1; s++)
            {
                polynomialProduct = new double[] { 1, (xWerten[0] * -1) };
                for (int i = 1; i < g; i++)
                {
                    double [] aktuellxWert = new double[] { 1, (xWerten[i] * -1) };
                    PolynomMultiplicator(polynomialProduct, aktuellxWert);         // hier wird funktion der Multiplikation
                }
                double[] temp = new double[polynomialProduct.Length];
                for (int k = 0; k < polynomialProduct.Length; k++) temp[k] = polynomialProduct[k] * collectYdasch[g-1];
                SpeicherAllePolynomials(temp);
                g++;
            }

        }

        //hier kann man auch eine Funktion aufbauen
        public void SpeicherAllePolynomials(double[] PlynomialProd)
        {

            int l = shouldbelastissue.Length - 1;
            int o = polynomialProduct.Length - 1;
            for (int i = 0; i < PlynomialProd.Length; i++)
            {
                shouldbelastissue[l] += PlynomialProd[o];
                l--;
                o--;
            }
            
        }

        string result = null;
        public string erg(double[]ywerten)
        {
            int v = shouldbelastissue.Length - 1;
            shouldbelastissue[v] += ywerten[0];
            for (int i = 0; i < shouldbelastissue.Length; i++)
            {
                if (v == 0)
                {
                    result += $"{shouldbelastissue[i]} . ";
                }
                else if (v == 1)
                {
                    result += $"  {shouldbelastissue[i]} x + ";

                }
                else
                {
                    result += $"  {shouldbelastissue[i]} x^{v} + ";

                }
                v--;

            }
            string res = "P(X) = " + result;

            return res;
        }



        //hermit 
        public int  bringABleitungvomBenutzer()
        {
            string text = Interaction.InputBox("","");
            return 0;
        }

        // fukulität
        public int Fakultät(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
