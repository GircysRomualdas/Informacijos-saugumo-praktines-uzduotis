using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Slapt slapt = new Slapt();
            slapt.komentaras = AES.encrypt(textBoxKomentaras.Text);
            slapt.pavadinimas = AES.encrypt(textBoxPavadinimas.Text);
            slapt.slaptazodis = AES.encrypt(textBoxSlaptazodis.Text);
            slapt.url = AES.encrypt(textBoxURL.Text);

            List<Slapt> listSlapt = new List<Slapt>();

            listSlapt = ConvertJason.Json_to_cs();

            listSlapt.Add(slapt);

            ConvertJason.Cs_to_json(listSlapt);

            List<Slapt> listSlapt1 = new List<Slapt>();
            listSlapt1 = ConvertJason.Json_to_cs();
            ListSlapt listS = new ListSlapt();
            listS.listSlapt = listSlapt1;
            listS.textDec();

            MessageBox.Show(listS.toString());
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            List<Slapt> listSlapt1 = new List<Slapt>();
            listSlapt1 = ConvertJason.Json_to_cs();
            ListSlapt listS = new ListSlapt();
            listS.listSlapt = listSlapt1;
            listS.textDec();

            if (listS.findSlaptPav(textBoxPavadinimas.Text))
            {
                MessageBox.Show("Rastas" + textBoxPavadinimas.Text);
            }
            else
            {
                MessageBox.Show("Nerastas" + textBoxPavadinimas.Text);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<Slapt> listSlapt1 = new List<Slapt>();
            listSlapt1 = ConvertJason.Json_to_cs();
            ListSlapt listS = new ListSlapt();
            listS.listSlapt = listSlapt1;
            listS.textDec();

            try
            {
                listS.deleteItem(textBoxPavadinimas.Text);
                MessageBox.Show("successful");
            }
            catch
            {
                MessageBox.Show("Error");
            }

            listS.encryptList();

            ConvertJason.Cs_to_json(listS.getList());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            List<Slapt> listSlapt1 = new List<Slapt>();
            listSlapt1 = ConvertJason.Json_to_cs();
            ListSlapt listS = new ListSlapt();
            listS.listSlapt = listSlapt1;
            listS.textDec();

            MessageBox.Show(listS.toString());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            List<Slapt> listSlapt1 = new List<Slapt>();
            listSlapt1 = ConvertJason.Json_to_cs();
            ListSlapt listS = new ListSlapt();
            listS.listSlapt = listSlapt1;
            listS.textDec();

            try
            {
                listS.update(textBoxPavadinimas.Text, textBoxSlaptazodis.Text);
                MessageBox.Show("successful");
            }
            catch
            {
                MessageBox.Show("Error");
            }

            listS.encryptList();

            ConvertJason.Cs_to_json(listS.getList());
        }
    }
}
