using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        string[] cities = new string[] { "Istanbul", "Ankara", "London", "Baku", "Washington", "Warsaw" };
        private void Form10_Load(object sender, EventArgs e)
        {
            cmbFrom.Items.Add(cities[0]);
            cmbFrom.Items.Add(cities[1]);
           

            MessageBox.Show("There are " + cities.Length + " different citites.");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTo.Items.Clear();
            cmbTo.Text = "";

            if (cmbFrom.SelectedItem.ToString() == cities[0])
            {
                cmbTo.Items.Add(cities[2]);
                cmbTo.Items.Add(cities[3]);
            }
            else
            {
                cmbTo.Items.Add(cities[4]);
                cmbTo.Items.Add(cities[5]);
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.SelectedItem.ToString();
            string to = cmbTo.SelectedItem.ToString();
            MessageBox.Show("Departure point => " + from + " Landing Point => " + to + "  - Have a nice flight.");
        }
    }
}
