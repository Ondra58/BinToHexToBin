using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string BinToHex(string vstup)
        {
            string hex = "";
            int delka = vstup.Length % 4;
            switch(delka)
            {
                case 1: vstup = "000" + vstup; break;
                case 2: vstup = "00" + vstup; break;
                case 3: vstup = "0" + vstup; break;
            }
            for(int i = vstup.Length - 1; i >= 0; i-=4)
            {
                string ctverice = vstup.Substring(vstup.Length - i - 1, 4); 
                switch(ctverice)
                {
                    case "0000": hex = hex + "0"; break;
                    case "0001": hex = hex + "1"; break;
                    case "0010": hex = hex + "2"; break;
                    case "0011": hex = hex + "3"; break;
                    case "0100": hex = hex + "4"; break;
                    case "0101": hex = hex + "5"; break;
                    case "0110": hex = hex + "6"; break;
                    case "0111": hex = hex + "7"; break;
                    case "1000": hex = hex + "8"; break;
                    case "1001": hex = hex + "9"; break;
                    case "1010": hex = hex + "A"; break;
                    case "1011": hex = hex + "B"; break;
                    case "1100": hex = hex + "C"; break;
                    case "1101": hex = hex + "D"; break;
                    case "1110": hex = hex + "E"; break;
                    case "1111": hex = hex + "F"; break;
                }
            }
            return hex;
        }
        public string HexToBin(string vstup)
        {
            string bin = "";
            for (int i = vstup.Length - 1; i >= 0; i--)
            {
                switch(vstup[i])
                {
                    case '0': bin = "0000" + bin; break;
                    case '1': bin = "0001" + bin; break;
                    case '2': bin = "0010" + bin; break;
                    case '3': bin = "0011" + bin; break;
                    case '4': bin = "0100" + bin; break;
                    case '5': bin = "0101" + bin; break;
                    case '6': bin = "0110" + bin; break;
                    case '7': bin = "0111" + bin; break;
                    case '8': bin = "1000" + bin; break;
                    case '9': bin = "1001" + bin; break;
                    case 'A': bin = "1010" + bin; break;
                    case 'B': bin = "1011" + bin; break;
                    case 'C': bin = "1100" + bin; break;
                    case 'D': bin = "1101" + bin; break;
                    case 'E': bin = "1110" + bin; break;
                    case 'F': bin = "1111" + bin; break;
                }
            }
            return bin;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HexToBin(textBox1.Text));
        }
    }
}
