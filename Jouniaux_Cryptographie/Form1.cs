using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jouniaux_Cryptographie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CryptageDotNet rs = new CryptageDotNet();
        

        private void btn_CrypDot_Click(object sender, EventArgs e)
        {
          
            string cypher = string.Empty;
            var text = textBox1.Text;
            if(text != string.Empty)
            {
                cypher = rs.Encrypt(text);
                textBox2.Text = cypher;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string cypher = string.Empty;
            var text = textBox2.Text;
            if (text != string.Empty)
            {
                cypher = rs.Decrypt(text);
                textBox3.Text = cypher;
            }
        }

        private void btn_cryptPerso_Click(object sender, EventArgs e)
        {
            string Crypt = string.Empty;
            string sKey = textBox5.Text;
            string Message = textBox4.Text;
            CryptagePerso vig = new CryptagePerso(sKey);
            if (sKey != string.Empty && Message != string.Empty)
            {
                Crypt = vig.Encrypt(Message);
                textBox6.Text = Crypt;
            }
            
        }

        private void btn_DecryptPerso_Click(object sender, EventArgs e)
        {
            string DeCrypt = string.Empty;
            string sKey = textBox5.Text;
            string Message = textBox6.Text;
            CryptagePerso vig = new CryptagePerso(sKey);
            if (sKey != string.Empty && Message != string.Empty)
            {
                DeCrypt = vig.Decrypt(Message);
                textBox7.Text = DeCrypt;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
