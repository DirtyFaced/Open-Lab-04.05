using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string vysledok = "";
            string emptystring = "";
            for (int i = 0; i < orig.Length; i++)
            {
                char[] arraynow = new char[n];
                string stringnow = "";
                char charnow = orig[i];
                for (int ii = 0; ii < n; ii++)
                {
                    arraynow[ii] = charnow;
                    stringnow = new string(arraynow);
                }
                vysledok = emptystring + stringnow;
                emptystring = vysledok;
            }
            return vysledok;
        }
    }
}
