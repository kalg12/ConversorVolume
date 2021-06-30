using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorVolume
{
    public partial class volumeConverter : Form
    {
        public volumeConverter()
        {
            InitializeComponent();
            litreTextBox.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            float cl;
            float litre;

            if (string.IsNullOrEmpty(ClTextBox.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            cl = Convert.ToInt32(ClTextBox.Text);
            litre = cl / 100;
            litreTextBox.Text = (litre.ToString());

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClTextBox.Text = "";
            litreTextBox.Text = "";
        }

        private void volumeConverter_Load(object sender, EventArgs e)
        {

        }

        private void litreTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
