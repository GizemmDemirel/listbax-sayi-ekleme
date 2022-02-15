using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
          int sayaç,sayi=0;
            sayaç=Convert.ToInt32(textBox1.Text);
            while (sayi<=sayaç)
            {
                listBox1.Items.Add(""+textBox2.Text);
                  sayi++;
             }

        }

        }
    }

