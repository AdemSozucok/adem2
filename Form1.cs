using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirler.Text);

            listele();
        }

        private void listele()
            {
                lbListe.Items.Clear();
                foreach (string sehir in sehirler)
                {
                    lbListe.Items.Add(sehir);
                }
            }

        private void button2_Click(object sender, EventArgs e)
            {
                int indexNo = lbListe.SelectedIndex;
                   
                sehirler.Insert(indexNo,txtSehirler.Text);

                listele();

            }

        private void btnGüncelle_Click(object sender, EventArgs e)
            {
                int indexNo = lbListe.SelectedIndex;

                sehirler[indexNo] = txtSehirler.Text;

                listele();

            }

        private void btnSil_Click(object sender, EventArgs e)
            {
                int indexNo = lbListe.SelectedIndex;
             
                sehirler.RemoveAt(indexNo);
                listele();
            }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(txtSehirler.Text))
            {
                lblDurum.Text = "Aranan Değer Bulundu";
                lbListe.SelectedIndex = sehirler.IndexOf(txtSehirler.Text);

            }
            else
            {
                lblDurum.Text = "Aranan Değer Bulunamadı";
            }
        }
        }
    }

