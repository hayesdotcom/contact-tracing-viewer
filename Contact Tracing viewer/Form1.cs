using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static string setvaluetext13;

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
    }
}
