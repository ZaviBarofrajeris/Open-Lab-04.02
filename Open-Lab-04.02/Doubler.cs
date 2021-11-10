using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string s = "";
            foreach (char word in original)
            {
                s += word + word.ToString();

            }
            return s;
        }
    }
}
