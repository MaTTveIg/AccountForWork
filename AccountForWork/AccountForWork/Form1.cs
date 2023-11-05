using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountForWork
{
    public partial class Form1 : Form
    {
        string worker = string.Empty;
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker = textBox1.Text + '/' + comboBox1.Text + "/" + comboBox2.Text + '/' + 
                textBox3.Text + '/' + textBox2.Text;
            listBox1.Items.Add(worker);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            StreamWriter sw = new StreamWriter(path + "\\Test.txt");
            for (int i = 0; i < listBox1.Items.Count; i++)
                sw.WriteLine(listBox1.Items[i]);
            sw.Close();
        }
    }
}
