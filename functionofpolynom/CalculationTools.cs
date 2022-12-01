using System;
using System.Collections.Generic;
using System.Text;

namespace functionofpolynom
{
    public class rechnungvonzahler
    {
        


        double[] shouldbelastissue;
        public void addthelengthforlastarray (int num)
        {
            shouldbelastissue = new double[num];
        }


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
            double XiminusandereX;
            double YdurchdenNenner=0;
           
            
            // allgemeines For 
            for (int i = 0; i < xWerten.Length; i++)
            {
                XiminusandereX = 1;
                // dieses For ist für subrahieren Xi minus andere X (also hier sind alles nummer weerden berechenet
                for (int t = 0; t < xWerten.Length; t++)
                {
                    
                    if (t != i)
                    {
                        if (xWerten[t] != xWerten[i] && xWerten[t]!=0 && xWerten[i]!=0)
                        { XiminusandereX *= xWerten[i] - xWerten[t]; }
                        else
                        {
                            // muss hier eine Nachricht vorkommen, um zu erklären, dass ist nicht mögelich wiederholte Nummer, 
                            throw new Exception("XWerten darf nicht wiederholt werden");
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
                                PolynomMultiplicator(polynomialProduct, aktuellxWert);         // hier wird funktion der Multiplikation
                               
                            }
                        }

                        //diese Array, damit die ergebnis von [Yi durch die (xi- alle andere x)] und polymial multiplikation 
                        double []temp= new double[polynomialProduct.Length];
                        for (int k = 0;k < polynomialProduct.Length ; k++) temp[k] = polynomialProduct[k]*YdurchdenNenner;
                        SpeicherAllePolynomials(temp);
                        j =xWerten.Length-1;
                    }
                }       
            }
            
        }


       

        // ab hier versuche die Datein zu zeigen aber alles, was lagrange angeht ist oben-------------------------------------------

        string result = string.Empty;
       
        
        //diese Funktion ist für sammlungen alles Polynomen bzw. L0 +L1 .....+Ln
        public  void SpeicherAllePolynomials (double []PlynomialProd)
        {
           
           
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
                if (v==0)
                {
                    result += $"{shouldbelastissue[i]} . ";
                }
                else
                {
                    result += $"  {shouldbelastissue[i]} x^{v} + ";

                }
                v--;

            }
            string res ="P(X) = " + result;

            return res;
        }
            
    }


  
}
