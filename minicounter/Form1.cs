using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minicounter
{
    public partial class Form1 : Form
    {
        //sätter en value på det 3 olika variablerna valuen på mode är lika med det inom "" används för att använda funktioner förvaras i string
        string mode = "";
        // Sätter en value 0 på variabeln number kommer användas för beräkningar förvaras i double 
        double number = 0;
        //sätter en value 0 på variabeln memory kommer användas för sparningar förvaras i double
        double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //detta gäller enbart för knapparna med text 0-9 det skickar nummeret till knappen till texten på toppen så man kan bilda nummer, else grejen gör bara så att man kan lägga till nummer bakom redan existerande nummer
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = btn.Text;
            }

            else
            {
                label1.Text = label1.Text + btn.Text;
            }
          
        }
        //har ingeting med något att göra
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        // detta är koden till + - * / och andra funktioner knapparna fast det gör egenkligen inte så mycket det sparar det gamla valuen på label texten och sedan sätter den texten till 0. mode = btn sätter valuen på mode till knapparna du tryckte på mellan + - * / o.s.v och sedan används denna value på mode i button16
        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }
        //Detta inför funktionerna du bestämde i tidigare knappen genom att först göra en ny variabel tmp som är = det nya talet som blir insatt i labeln. Den använder sedan det ny variablen genom att ta number(talet innan tmp) mode(funktion) tmp(nya talet i labeln) och sedan sätter det talet som bildas som det nya label texten.
        private void button16_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            if (mode == "+") 
            {
                label1.Text = (number + tmp).ToString();
                 
                
            }
            else if (mode == "-")
            {
                label1.Text = (number - tmp).ToString();
            }
            else if (mode == "*")
            {
                label1.Text = (number * tmp).ToString();
            }
            else if (mode == "/")
            {
                label1.Text = (number / tmp).ToString();
            }
            
            else if (mode == "x^y")
            {
                label1.Text = Math.Pow(number, tmp).ToString();
            }
            else if (mode == "%")
            {
                label1.Text = (number * tmp / 100).ToString();
            }
                
            
        }
        //sätter ett , efter talet i labeln
        private void button15_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                label1.Text = label1.Text + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }
            
        }
        //ska konverta decimal till binär fast verkar vara ur funktion
        private void button19_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = Convert.ToInt64(label1.Text, 2).ToString();
        }
        //sätter label texten till string 0 
        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
        //gör om talet till positivt till negativt och negativt till positivt
        private void button20_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text=(tmp * -1).ToString(); 
        }
        //gör rotten ur på label texten
        private void button22_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = Math.Sqrt(tmp).ToString();
            
        }
       //tar bort sist nummeret i label. i fall det bara finns en karatär gör den om det till noll
        private void button27_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
        }
        // sätter label text till = memory
        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = memory.ToString();
        }
        //sparar label texten som memory
        private void button24_Click_1(object sender, EventArgs e)
        {
            memory = double.Parse(label1.Text);
        }
        //resetar värdet på memory
        private void button25_Click(object sender, EventArgs e)
        {
            memory = 0;
        }
        //ska göra binär till decimal fast värkar vara ur funktion
        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToInt64(label1.Text, 2).ToString();
        }
    }
}
