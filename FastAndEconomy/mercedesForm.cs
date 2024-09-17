using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastAndEconomy
{
    public partial class mercedesForm : Form
    {
        public mercedesForm()
        {
            InitializeComponent();
        }

        private void purchaseLexusIsButton_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(glsMercedesLabel.Text);
            purshaseForm.setVehiclePrice(mercdesGlsPriceLabel.Text);
            purshaseForm.setVehicleImage(GlspictureBox.Image);

            purshaseForm.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(gtMercedesLabel.Text);
            purshaseForm.setVehiclePrice(mercdesGtPriceLabel.Text);
            purshaseForm.setVehicleImage(GtpictureBox.Image);

            purshaseForm.ShowDialog();
            this.Hide();
        }
    }
}

