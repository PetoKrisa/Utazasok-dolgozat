using System;
using System.Windows.Forms;

namespace UtazasokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pető Kristóf dolgozat 2024.04.25");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UtazasRepository.Path = openFileDialog1.FileName;
                UtazasRepository.SkipHeader = true;
                dataGridView1.DataSource = UtazasRepository.FindAll();
            }
        }

        private void utazásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.Cancel)
            {
                try
                {
                    dataGridView1.DataSource = UtazasRepository.FindAll();
                } catch
                {

                }
            }
        }
    }
}
