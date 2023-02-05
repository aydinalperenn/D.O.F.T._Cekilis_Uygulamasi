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

namespace D.O.F.T.Çekiliş_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Random rnd = new Random();
        //int sayi = new Random(0, adet);
        //listBox1.SelectedIndex = 1;
        // label1.Text = listBox1.SelectedItem.ToString();
        // katilimciAdet = lbKatilimcilar.Items.Count;

        int katilimciAdet;
        int odulAdet;
        bool x1 = false, x2 = false;

        private void veriCek(ListBox lb)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamreader = new StreamReader(openFileDialog1.FileName);
                string veri = streamreader.ReadLine();
                while (veri != null)
                {
                    lb.Items.Add(veri);
                    veri = streamreader.ReadLine();
                }
            }
        }
        private void cekilisYap()
        {
            if ((x1 == true) && (x2 == true))
            {
                groupBox3.Visible = true;
                btnCekilisYap.Visible = true;
            }
        }
        



        private void button1_Click(object sender, EventArgs e)
        {
            veriCek(lbKatilimcilar);
            katilimciAdet = lbKatilimcilar.Items.Count;
            x1 = true;
            cekilisYap();

        }

        private void btnOdulSec_Click(object sender, EventArgs e)
        {
            veriCek(lbOduller);
            odulAdet = lbOduller.Items.Count;
            x2 = true;
            cekilisYap();
        }

        

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int[] indeksler = new int[odulAdet];
            for (int a = 0; a < indeksler.Length; a++)
            {
                indeksler[a] = -1;
            }

            for (int i = 0; i < odulAdet; i++)
            {
                if (i == katilimciAdet)
                {
                    break;
                }
                
                a1:
                    int sayi = rnd.Next(0, katilimciAdet);
                    bool y = false;


                    for (int x = 0; x < indeksler.Length; x++)
                    {
                        if (indeksler[x] == sayi)
                        {
                            y = true;
                        }
                    }


                    if (y == false)
                    {
                        
                        indeksler[i] = sayi;
                        lbKatilimcilar.SelectedIndex = sayi;
                        lbOduller.SelectedIndex = i;
                        lbCekilis.Items.Add(lbOduller.SelectedItem.ToString() + "  ⟹  " + lbKatilimcilar.SelectedItem.ToString());

                        
                        
                        
                    }
                    else
                    {
                        goto a1;
                    }

            }

            lbCekilis.Items.Add("");
        }
    }
}
