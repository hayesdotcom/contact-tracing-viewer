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

namespace Contact_Tracing_viewer
{
    public partial class Form1 : Form
    {
        public static string setvaluetext1;
        public static string setvaluetext2;
        public static string setvaluetext3;
        public static string setvaluetext4;
        public static string setvaluetext5;
        public static string setvaluetext6;
        public static string setvaluetext7;
        public static string setvaluetext8;
        public static string setvaluetext9;
        public static string setvaluetext10;
        public static string setvaluetext11;
        public static string setvaluetext12;
        public static string setvaluetext14;
        public static string setvaluetext15;
        public static string setvaluetext16;
        public static string setvaluetext17;
        public static string setvaluetext18;

        
        

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            setvaluetext1 = textBox1.Text;
            setvaluetext2 = textBox2.Text;
            setvaluetext3 = comboBox1.Text;
            setvaluetext4 = textBox3.Text;
            setvaluetext5 = textBox4.Text;
            setvaluetext6 = comboBox2.Text;
            setvaluetext7 = comboBox3.Text;
            setvaluetext8 = comboBox4.Text;
            setvaluetext9 = textBox5.Text;

            StreamWriter A = new StreamWriter(Application.StartupPath + "\\form\\" + "Contact Tracing Records.txt");

            A.WriteLine("DETAILS");

            A.WriteLine(label2.Text + " " + textBox1.Text);
            A.WriteLine(label3.Text + " " + textBox2.Text);
            A.WriteLine(label4.Text + " " + comboBox1.Text);
            A.WriteLine(label5.Text + " " + textBox3.Text);
            A.WriteLine(label6.Text + " " + textBox4.Text);
            A.WriteLine(label7.Text + " " + comboBox2.Text + " " + comboBox3.Text + ", " + comboBox4.Text);
            A.WriteLine(label8.Text + " " + textBox5.Text);

            A.WriteLine("HEALTH CONDITIONS");

            if (checkBox1.CheckState == CheckState.Checked)
            {
                A.WriteLine(label12.Text + "- YES.");
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                A.WriteLine(label12.Text + "- NO.");
            }
            if (checkBox3.CheckState == CheckState.Checked)
            {
                A.WriteLine(label13.Text + "- YES.");
            }
            if (checkBox4.CheckState == CheckState.Checked)
            {
                A.WriteLine(label13.Text + "- NO.");
            }
            if (checkBox6.CheckState == CheckState.Checked)
            {
                A.WriteLine(label14.Text + "- YES.");
            }
            if (checkBox5.CheckState == CheckState.Checked)
            {
                A.WriteLine(label14.Text + "- NO.");
            }
            if (checkBox8.CheckState == CheckState.Checked)
            {
                A.WriteLine(label15.Text + "- YES.");
            }
            if (checkBox7.CheckState == CheckState.Checked)
            {
                A.WriteLine(label15.Text + "- NO.");
            }
            A.Close();
            

            
            
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2 = null;
            this.Show();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox4.Text = String.Empty;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        

    }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox4.Text = String.Empty;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }
    }
    }

