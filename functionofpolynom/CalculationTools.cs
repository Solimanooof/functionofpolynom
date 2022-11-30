using System;
using System.Collections.Generic;
using System.Text;

namespace functionofpolynom
{
    public class rechnungvonzahler
    {

        public List<double> xlistwerten= new List<double>();
        public double[] aktuellxWert;
    

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

       
        public void LagrangeMethode (double[] xWerten, double [] yWerten)               //versuche das für lagrange anzupassen
        {
            double XiminusandereX=1;
            double YdurchdenNenner=1;
           
            
            // allgemeines For 
            for (int i = 0; i < xWerten.Length; i++)
            {
                // dieses For ist für subrahieren Xi minus andere X (also hier sind alles nummer weerden berechenet
                for (int t = 0; t < xWerten.Length; t++)
                {
                    
                    if (t != i)
                    {
                        if (xWerten[t] != xWerten[i])
                        { XiminusandereX *= xWerten[i] - xWerten[t]; }
                        else
                        {
                           // muss hier eine Nachricht vorkommen, um zu erklären, dass ist nicht mögelich wiederholte Nummer, weiß nicht, warum messagebox nicht vorhanden
                        }

                    }

                }
                // hier wird y durch Multiplikation von Xi minus alles andere X
                YdurchdenNenner = yWerten[i] / XiminusandereX;

                // das Ziel dieses For ist nur die Werte rausschmeißen, damit das Varibale X minus andere Werten von X zu berechnen deshabl wird nur einmal benutzt und J wird erhöht, damit rausgehen 
                for (int j = 0; j < xWerten.Length ; j++)
                {
                    if (j != i)
                    {
                        polynomialProduct = new double[] { 1, (xWerten[j] * -1) };                // nhemen hier die erste Werte und 

                        // hier wird X (das Varible) minus alle X außer Xi
                        for (int k = 0; k < xWerten.Length ; k++)
                        {
                            if (k != j && k!=i)
                            {
                                aktuellxWert = new double[] { 1, (xWerten[k] * -1) };
                                PolynomMultiplicator(polynomialProduct, aktuellxWert);          // hier wird funktion der Multiplikation
                            }
                        }

                        //diese Array, damit die ergebnis von [Yi durch die (xi- alle andere x)] und polymial multiplikation 
                     double [] temp= new double[polynomialProduct.Length];
                        for (int s = 0; s < polynomialProduct.Length; s++)
                        {
                            temp[s] =YdurchdenNenner * polynomialProduct[s];
                        }
                        SpeicherAllePolynomials(temp);
                         j =xWerten.Length-1;
                    }
                }       
            }
            
        }


        // ab hier versuche die Datein zu zeigen aber alles, was lagrange angeht ist oben-------------------------------------------

        string result = string.Empty;
        double[] shouldbelastissue;
        
        //diese Funktion ist für sammlungen alles Polynomen bzw. L0 +L1 .....+Ln
        public  void SpeicherAllePolynomials (double []PlynomialProd)
        {
           
           shouldbelastissue=new double [PlynomialProd.Length];
            for (int i = 0; i < PlynomialProd.Length; i++)
            {
                shouldbelastissue [i] += PlynomialProd[i];                
            }
        }
        
        public string erg()
        {
            int v = shouldbelastissue.Length - 1;
            for (int i = 0; i < shouldbelastissue.Length; i++)
            {
                result += $"Basis ist = {shouldbelastissue[i]} + X^ {v} + ";
                v--;

            }

            return result;
        }
            
    }


  
}
