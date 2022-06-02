using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class ListSlapt
    {
        public List<Slapt> listSlapt { get; set; }

        public List<Slapt> getList()
        {
            return listSlapt;
        }

        public String toString()
        {
            string listS = "";

            listSlapt.ForEach(delegate (Slapt slapt) {
                listS += slapt.toString();
            });
            return listS;
        }

        public void textDec()
        {
            List<Slapt> temp = new List<Slapt>();
            listSlapt.ForEach(delegate (Slapt slapt) {
                temp.Add(new Slapt() { pavadinimas = AES.decrypt(slapt.pavadinimas),
                                       slaptazodis = AES.decrypt(slapt.slaptazodis),
                                       url = AES.decrypt(slapt.url),
                                       komentaras = AES.decrypt(slapt.komentaras)
                                       });
            });

            listSlapt = temp;
        }

        public bool findSlaptPav(string pav)
        {
            bool find = false;
            listSlapt.ForEach(delegate (Slapt slapt) {
                if( slapt.pavadinimas == pav)
                {
                    find = true;
                }
            });
            return find;
        }

        public void deleteItem(string pav)
        {
            List<Slapt> temp = new List<Slapt>();
            listSlapt.ForEach(delegate (Slapt slapt) {
                if (slapt.pavadinimas != pav)
                {
                    temp.Add(slapt);
                }
            });

            listSlapt = temp;
        }

        public void update(string pav, string sla)
        {
            List<Slapt> temp = new List<Slapt>();
            listSlapt.ForEach(delegate (Slapt slapt) {
                if (slapt.pavadinimas != pav)
                {
                    temp.Add(slapt);
                }
                else
                {
                    slapt.slaptazodis = sla;
                    temp.Add(slapt);
                }
            });

            listSlapt = temp;
        }

        public void encryptList()
        {
            List<Slapt> temp = new List<Slapt>();
            listSlapt.ForEach(delegate (Slapt slapt) {
                slapt.pavadinimas = AES.encrypt(slapt.pavadinimas);
                slapt.slaptazodis = AES.encrypt(slapt.slaptazodis);
                slapt.url = AES.encrypt(slapt.url);
                slapt.komentaras = AES.encrypt(slapt.komentaras);
                temp.Add(slapt);
            });

            listSlapt = temp;
        }
    }
}
