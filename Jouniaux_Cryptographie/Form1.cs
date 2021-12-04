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
    }
}
