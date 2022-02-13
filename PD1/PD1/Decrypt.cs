using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PD1
{
    class Decrypt
    {
        public string Convert(string text, int key)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(text);

            byte[] newASC = new byte[ASCIIValues.Length];

            for (int i = 0; i < ASCIIValues.Length; i++)
            {
                byte lat = ASCIIValues[i];

                int tempkey = key;

                while (tempkey > 0)
                {
                    lat = (byte)(lat - 1);

                    if (lat < 32 || lat >= 127)
                    {
                        lat = 126;
                    }

                    tempkey--;
                }

                newASC[i] = lat;
            }

            string AscStr = Encoding.ASCII.GetString(newASC);

            return AscStr;
        }
    }
}
