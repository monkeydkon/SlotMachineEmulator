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

namespace TelikhTrithAskhsh
{
    public partial class Form1 : Form
    {

        bool diff = false;
        int first;
        int second;
        int third;
        int fourth;
        int fifth;
        int win;
        public Form1()
        {
            InitializeComponent();
            String score;
            StreamReader sr = new StreamReader("../bets.txt");
            score = sr.ReadLine();
            sr.Close();

            label3.Text = score;



            StreamReader sr2 = new StreamReader("../wins.txt");
            Int32 wins = Int32.Parse(sr2.ReadLine()) + win;
            sr2.Close();

            label6.Text = wins.ToString();




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            win = 0;
            timer1.Start();


           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (numericUpDown1.Value > 0)
            {

                StreamReader sr = new StreamReader("../bets.txt");
                Int32 score = Int32.Parse(sr.ReadLine()) + Convert.ToInt32(numericUpDown1.Value);
                sr.Close();
                StreamWriter sw = new StreamWriter("../bets.txt");
                sw.WriteLine(score);
                sw.Close();
                label3.Text = score.ToString();








                Random rnd = new Random();
                if (diff == false)
                {

                    second = rnd.Next(1, 5);
                    third = rnd.Next(1, 5);
                    fourth = rnd.Next(1, 5);
                }
                else
                {
                    first = rnd.Next(1, 6);
                    second = rnd.Next(1, 6);
                    third = rnd.Next(1, 6);
                    fourth = rnd.Next(1, 6);
                    fifth = rnd.Next(1, 6);

                }
                int cherry = 0;
                int straw = 0;
                int lemon = 0;
                int corona = 0;
                int grape = 0;


                if (diff == true)
                {
                    switch (first)
                    {
                        case 1:
                            pictureBox1.Image = Properties.Resources.cherry;
                            cherry += 1;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources.straw;
                            straw += 1;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.lemon;
                            lemon += 1;
                            break;
                        case 4:
                            pictureBox1.Image = Properties.Resources.corona;
                            corona += 1;
                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.grape;
                            grape += 1;
                            break;
                    }
                }

                switch (second)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.cherry;
                        cherry += 1;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.straw;
                        straw += 1;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.lemon;
                        lemon += 1;
                        break;
                    case 4:
                        pictureBox2.Image = Properties.Resources.corona;
                        corona += 1;
                        break;
                    case 5:
                        pictureBox2.Image = Properties.Resources.grape;
                        grape += 1;
                        break;
                }

                switch (third)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.cherry;
                        cherry += 1;

                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.straw;
                        straw += 1;

                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.lemon;
                        lemon += 1;

                        break;
                    case 4:
                        pictureBox3.Image = Properties.Resources.corona;
                        corona += 1;

                        break;

                    case 5:
                        pictureBox2.Image = Properties.Resources.grape;
                        grape += 1;
                        break;
                }

                switch (fourth)
                {
                    case 1:
                        pictureBox4.Image = Properties.Resources.cherry;
                        cherry += 1;

                        break;
                    case 2:
                        pictureBox4.Image = Properties.Resources.straw;
                        straw += 1;

                        break;
                    case 3:
                        pictureBox4.Image = Properties.Resources.lemon;
                        lemon += 1;

                        break;
                    case 4:
                        pictureBox4.Image = Properties.Resources.corona;
                        corona += 1;

                        break;
                    case 5:
                        pictureBox2.Image = Properties.Resources.grape;
                        grape += 1;
                        break;
                }


                if (diff == true)
                {
                    switch (fifth)
                    {
                        case 1:
                            pictureBox5.Image = Properties.Resources.cherry;
                            cherry += 1;
                            break;
                        case 2:
                            pictureBox5.Image = Properties.Resources.straw;
                            straw += 1;
                            break;
                        case 3:
                            pictureBox5.Image = Properties.Resources.lemon;
                            lemon += 1;
                            break;
                        case 4:
                            pictureBox5.Image = Properties.Resources.corona;
                            corona += 1;
                            break;
                        case 5:
                            pictureBox5.Image = Properties.Resources.grape;
                            grape += 1;
                            break;
                    }
                }

                Class2 class2 = new Class2();
            
                if (diff == false)
                {
                    if (cherry == 3 || lemon == 3)
                    {
                        // win = (int)numericUpDown1.Value * 2;
                        win = class2.generateRandom((int)numericUpDown1.Value, 2);
                        MessageBox.Show(win.ToString());
                    }

                    if (straw == 2)
                    {
                       // win = (int)numericUpDown1.Value;
                        win = class2.generateRandom((int)numericUpDown1.Value, 1);
                        MessageBox.Show(win.ToString());

                    }

                    if (straw == 3)
                    {
                       // win = (int)numericUpDown1.Value * 3;
                        win = class2.generateRandom((int)numericUpDown1.Value, 3);
                        MessageBox.Show(win.ToString());

                    }

                    if (corona == 2)
                    {
                        //win = (int)numericUpDown1.Value * 4;
                        win = class2.generateRandom((int)numericUpDown1.Value, 4);
                        MessageBox.Show(win.ToString());
                    }

                    if (corona == 3)
                    {
                        //win = (int)numericUpDown1.Value * 10;
                        win = class2.generateRandom((int)numericUpDown1.Value, 10);
                        MessageBox.Show(win.ToString());

                    }
                }
                else
                {
                    if (corona == 5)
                    {
                       // win = (int)numericUpDown1.Value * 30;
                        win = class2.generateRandom((int)numericUpDown1.Value, 30);
                        MessageBox.Show(win.ToString());

                    }

                    if (corona == 4)
                    {
                        //win = (int)numericUpDown1.Value * 12;
                        win = class2.generateRandom((int)numericUpDown1.Value, 12);
                        MessageBox.Show(win.ToString());
                    }

                    if (straw == 5)
                    {
                       // win = (int)numericUpDown1.Value * 15;
                        win = class2.generateRandom((int)numericUpDown1.Value, 15);
                        MessageBox.Show(win.ToString());

                    }

                    if (straw == 4)
                    {
                        //win = (int)numericUpDown1.Value * 8;
                        win = class2.generateRandom((int)numericUpDown1.Value, 8);
                        MessageBox.Show(win.ToString());
                    }

                    if (grape == 5)
                    {
                      //  win = (int)numericUpDown1.Value * 10;
                        win = class2.generateRandom((int)numericUpDown1.Value, 10);
                        MessageBox.Show(win.ToString());


                    }

                    if (grape == 4)
                    {
                       // win = (int)numericUpDown1.Value * 7;
                        win = class2.generateRandom((int)numericUpDown1.Value, 7);
                        MessageBox.Show(win.ToString());
                    }

                    if (cherry == 3 || lemon == 3)
                    {
                       // win = (int)numericUpDown1.Value * 2;
                        win = class2.generateRandom((int)numericUpDown1.Value, 2);
                        MessageBox.Show(win.ToString());
                    }

                    if (cherry == 4 || lemon == 4)
                    {
                      //  win = (int)numericUpDown1.Value * 5;
                        win = class2.generateRandom((int)numericUpDown1.Value, 5);
                        MessageBox.Show(win.ToString());
                    }


                    if (straw == 3)
                    {
                      //  win = (int)numericUpDown1.Value * 3;
                        win = class2.generateRandom((int)numericUpDown1.Value, 3);
                        MessageBox.Show(win.ToString());

                    }

                    if (grape == 3)
                    {
                       // win = (int)numericUpDown1.Value * 5;
                        win = class2.generateRandom((int)numericUpDown1.Value, 5);
                        MessageBox.Show(win.ToString());
                    }

                    if (corona == 3)
                    {
                     //   win = (int)numericUpDown1.Value * 8;
                        win = class2.generateRandom((int)numericUpDown1.Value, 8);
                        MessageBox.Show(win.ToString());

                    }
                }
               
               

                StreamReader sr2 = new StreamReader("../wins.txt");
                Int32 wins = Int32.Parse(sr2.ReadLine()) + win;
                sr2.Close();
                StreamWriter sw2 = new StreamWriter("../wins.txt");
                sw2.WriteLine(wins);
                sw2.Close();
                label6.Text = wins.ToString(); 



            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diff = true;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diff = false;
            pictureBox1.Image = null;
            pictureBox5.Image = null;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           
                Application.Exit();
            
        
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
