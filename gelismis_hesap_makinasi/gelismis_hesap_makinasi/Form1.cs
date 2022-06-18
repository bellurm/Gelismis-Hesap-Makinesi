using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gelismis_hesap_makinasi
{
    //label için çerçeve ve boyut: textalign, borderstyle, autosize
    //forma müdahale engellemesi için: formborderstyle
    //formun ortada çıkmasını istersek: startposition
    public partial class Form1 : Form
    {
        double sayi1, sayi2, sonuc;
        double sayi, faktoriyel = 1;
        double yuzde_sayi;
        int secim = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Rakamlar(object sender, EventArgs e)
        {
            //tüm butonların ortak işlevi
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }
        private void btn_nokta_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") < 1) //en az 1 basamak olma şartıyla
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
        private void btn_arti_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 1;
        }
        private void btn_eksi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 2;
        }
        private void btn_carpi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 3;
        }

        private void btn_bolu_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 4;
        }

        private void btn_x_kare_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 5;
            if (secim == 5)
            {
                sonuc = sayi1 * sayi1;
                textBox1.Text = sonuc.ToString();
                ListBox1.Items.Add(sayi1 + "^2" + " = " + sonuc);
            }
        }
        private void btn_kok_x_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 6;
            textBox1.Text = "√";
            if (secim == 6)
            {
                sonuc = Math.Sqrt(sayi1);
                textBox1.Text = sonuc.ToString();
                ListBox1.Items.Add("√" + sayi1 + " = " + sonuc);
            }
        }
        private void btn_faktoriyel_Click(object sender, EventArgs e)
        {
            
            sayi = double.Parse(textBox1.Text);
            secim = 7;
            textBox1.Text = sayi1 + "!";
            if (secim == 7)
            {
                for (double i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                }
                textBox1.Text = faktoriyel.ToString();
                ListBox1.Items.Add(sayi + "!" + " = " + faktoriyel);
            }
        }
        private void btn_yuzde_Click(object sender, EventArgs e)
        {
            yuzde_sayi = double.Parse(textBox1.Text);
            sayi1 = double.Parse(textBox1.Text);
            secim = 8;
            textBox1.Text = "%";
            if (secim == 8)
            {
                //yuzde_sayi = double.Parse(textBox1.Text);
                sonuc = (sayi1 / 100);
                yuzde_sayi = sonuc * sayi;
                textBox1.Text = yuzde_sayi.ToString();
            }
        }
        private void btn_esittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(textBox1.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
                ListBox1.Items.Add(sayi1 + " + " + sayi2 + " = " + sonuc);
            }
            else if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();
                ListBox1.Items.Add(sayi1 + " - " + sayi2 + " = " + sonuc);
            }
            else if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();
                ListBox1.Items.Add(sayi1 + " x " + sayi2 + " = " + sonuc);
            }
            else if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString("0.00");
                ListBox1.Items.Add(sayi1 + " / " + sayi2 + " = " + sonuc);
            }
            else if (secim == 8)
            {
                sonuc = (sayi1 / 100);
                yuzde_sayi = sonuc * sayi2;
                textBox1.Text = yuzde_sayi.ToString();
                ListBox1.Items.Add(sayi1 + " % " + sayi2 + " = " + yuzde_sayi);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //keypreview true yap > klavyeyi okur > yılıdırm > keydown > çift tıkla
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btn_0.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btn_1.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btn_2.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btn_3.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btn_4.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btn_5.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btn_6.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btn_7.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btn_8.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btn_9.PerformClick();
            }
        }
      
        private void btn_panel_gecisi_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void pnl_kapat_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void gecmis_btn_Click(object sender, EventArgs e)
        {
            btn_list_temizle.Visible = true;
            btn_list_kapat.Visible = true;
            ListBox1.Visible = true;
            label1.Visible = true;
        }
        private void btn_list_temizle_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }
        private void btn_list_kapat_Click(object sender, EventArgs e)
        {
            btn_list_temizle.Visible = false;
            btn_list_kapat.Visible = false;
            ListBox1.Visible = false;
            label1.Visible = false;
        }
    }
}
