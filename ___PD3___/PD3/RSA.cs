using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD3
{
    class RSA
    {
        private int n;
        private int e;
        private int fn;
        private int d;

        public RSA(int p, int q)
        {
            this.n = p * q;
            this.fn = (p - 1) * (q - 1);

            //this.e = findGCD(n, fn, 2);
            this.e = findGCD(n, fn);

            //int d = findEEA(this.fn, this.e);
            //int d = findEEA(this.fn, this.e, ref x, ref y);
            //int d = gcdExtended(fn, e);
            triplet temp = extendedEuclid(fn, e);
            //MessageBox.Show(temp.gcd.ToString() + " " + temp.x.ToString() + " " + temp.y.ToString());
            this.d = temp.y;
            //int d = findEEA(35, 15, ref x, ref y);


            if (d < 0)
            {
                this.d = d + fn;
            }
            else
            {
                this.d = d;
            }
            //MessageBox.Show(this.d.ToString());
        }

        public RSA(int n, int e, int d)
        {
            this.n = n;
            this.e = e;
            this.d = d;
        }

        public string encryptR(string text)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(text);

            byte[] newASC = new byte[ASCIIValues.Length];

            for (int i = 0; i < ASCIIValues.Length; i++)
            {
                byte lat = ASCIIValues[i];

                newASC[i] = (byte)((Math.Pow(lat, this.e) % this.n));
                MessageBox.Show(lat.ToString() + " ^ " + this.e + "  % " + this.n + " = " + newASC[i].ToString());
            }
            string AscStr = Encoding.ASCII.GetString(newASC);

            return AscStr;
        }

        public string decryptR(string text)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(text);

            byte[] newASC = new byte[ASCIIValues.Length];

            for (int i = 0; i < ASCIIValues.Length; i++)
            {
                byte lat = ASCIIValues[i];
                newASC[i] = (byte)((Math.Pow(lat, this.d) % this.n));
                MessageBox.Show(lat.ToString() + " ^ " + this.d + "  % " + this.n + " = " + newASC[i].ToString());
            }
            string AscStr = Encoding.ASCII.GetString(newASC);

            return AscStr;
        }

        public void setN(int n)
        {
            this.n = n;
        }

        public int getN()
        {
            return this.n;
        }

        public void setE(int e)
        {
            this.e = e;
        }

        public int getE()
        {
            return this.e;
        }

        public void setD(int d)
        {
            this.d = d;
        }

        public int getD()
        {
            return this.d;
        }

        private int findGCD(int a, int b)
        {
            for (int i = 2; i <= a; i++)
            {
                if (a % i !=0 && b % i != 0)
                {
                    return i;
                }
            }
            return 0;
        }



        public struct triplet
        {
            public int x;
            public int y;
            public int gcd;

        };

        triplet extendedEuclid(int a, int b)
        {
            if (b == 0)
            {
                triplet ans1;
                ans1.x = 1;
                ans1.gcd = a;
                ans1.y = 0;
                return ans1;
            }

            triplet smallAns = extendedEuclid(b, a % b);
            triplet ans;
            ans.gcd = smallAns.gcd;
            ans.x = smallAns.y;
            ans.y = smallAns.x - (a / b) * smallAns.y;
            return ans;
        }
    }
}
