using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelikhTrithAskhsh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            label2.Text = class1.generate("Γιωργος Κονσουλακης");
            label4.Text = class1.generate("Γιωργος Μακαρογλου");
            label3.Text = class1.generate("Π14078");
            label5.Text = class1.generate("Π14098");
            label6.Text = class1.generate("kon_fu2@hotmail.com");
            label7.Text = class1.generate("geomak13@yahoo.gr");
            
        }
    }
}
