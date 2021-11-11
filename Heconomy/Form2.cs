using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace Heconomy
{
    public partial class Form2 : Form
    {

        public String Cname;
        public String mcid;
        public int money;
        public String BigC;
        public String MidC;

        public Form2()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            switch (i)
            {
                case 0:
                    break;
                case 1:
                    comboBox2.Items.Clear();
                    StreamReader sa = new StreamReader(@"..\..\Resorce\1.csv");
                    while (!sa.EndOfStream)
                    {
                        String line = sa.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 2:
                    comboBox2.Items.Clear();
                    StreamReader sb = new StreamReader(@"..\..\Resorce\2.csv");
                    while (!sb.EndOfStream)
                    {
                        String line = sb.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 3:
                    comboBox2.Items.Clear();
                    StreamReader sc = new StreamReader(@"..\..\Resorce\3.csv");
                    while (!sc.EndOfStream)
                    {
                        String line = sc.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 4:
                    comboBox2.Items.Clear();
                    StreamReader sd = new StreamReader(@"..\..\Resorce\4.csv");
                    while (!sd.EndOfStream)
                    {
                        String line = sd.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 5:
                    comboBox2.Items.Clear();
                    StreamReader se = new StreamReader(@"..\..\Resorce\5.csv");
                    while (!se.EndOfStream)
                    {
                        String line = se.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 6:
                    comboBox2.Items.Clear();
                    StreamReader sf = new StreamReader(@"..\..\Resorce\6.csv");
                    while (!sf.EndOfStream)
                    {
                        String line = sf.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 7:
                    comboBox2.Items.Clear();
                    StreamReader sg = new StreamReader(@"..\..\Resorce\7.csv");
                    while (!sg.EndOfStream)
                    {
                        String line = sg.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 8:
                    comboBox2.Items.Clear();
                    StreamReader sh = new StreamReader(@"..\..\Resorce\8.csv");
                    while (!sh.EndOfStream)
                    {
                        String line = sh.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 9:
                    comboBox2.Items.Clear();
                    StreamReader si = new StreamReader(@"..\..\Resorce\9.csv");
                    while (!si.EndOfStream)
                    {
                        String line = si.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 10:
                    comboBox2.Items.Clear();
                    StreamReader sj = new StreamReader(@"..\..\Resorce\10.csv");
                    while (!sj.EndOfStream)
                    {
                        String line = sj.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 11:
                    comboBox2.Items.Clear();
                    StreamReader sk = new StreamReader(@"..\..\Resorce\11.csv");
                    while (!sk.EndOfStream)
                    {
                        String line = sk.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;
                case 12:
                    comboBox2.Items.Clear();
                    StreamReader sl = new StreamReader(@"..\..\Resorce\12.csv");
                    while (!sl.EndOfStream)
                    {
                        String line = sl.ReadLine();
                        comboBox2.Items.Add(line);
                    }
                    break;


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cname = textBox1.Text;
            mcid = textBox2.Text;
            money = int.Parse(textBox3.Text);
            BigC = comboBox1.Text;
            MidC = comboBox2.Text;
            Program.FirstEasySql();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
