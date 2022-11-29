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


        public List<double> listvonXwerten (double[] xWerten)
        {
            for (int i = 0; i < xWerten.Length; i++)
            {
                polynomialProduct= new double[] { 1, (xWerten[i]* -1) };

                for (int k  = 0; k < xWerten.Length; k++)
                {
                    if (k!=i)
                    {
                        aktuellxWert=new double[] {1, (xWerten[k] * -1) };
                        PolynomMultiplicator(polynomialProduct, aktuellxWert);
                    }
                }
                foreach (var item in polynomialProduct)
                {
                    xlistwerten.Add(item);
                }
            }
            return xlistwerten;
        }
    }


  
}
