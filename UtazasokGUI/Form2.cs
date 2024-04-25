using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtazasokGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void valideNumberField(TextBox txt)
        {
            try
            {
                Convert.ToInt32(txt.Text);
            }
            catch
            {
                txt.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valideNumberField(textBox1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            valideNumberField(textBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            valideNumberField(textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            valideNumberField(textBox5);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            valideNumberField(textBox6);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utazas utazas = new Utazas(
                Convert.ToInt32(textBox1.Text),
                textBox2.Text,
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text),
                Convert.ToInt32(textBox5.Text),
                Convert.ToInt32(textBox6.Text),
                textBox7.Text);
            try
            {
                UtazasRepository.Save(utazas);
                MessageBox.Show("Mentve");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Nincs megnyitva file!");
            }
           
        }
    }
}
