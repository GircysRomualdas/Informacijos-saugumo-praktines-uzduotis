using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class Slapt
    {
        public string pavadinimas { get; set; }
        public string slaptazodis { get; set; }
        public string url { get; set; }
        public string komentaras { get; set; }


        public String toString()
        {
            return pavadinimas + " " +
                   slaptazodis + " " +
                   url + " " +
                   komentaras + "\n";
        }

    }
}
