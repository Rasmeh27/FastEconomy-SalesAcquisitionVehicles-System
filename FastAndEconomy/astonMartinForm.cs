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
    public partial class astonMartinForm : Form
    {
        public astonMartinForm()
        {
            InitializeComponent();
        }

        private void purchaseAstonDbButton_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(db11AstonLabel.Text);
            purshaseForm.setVehiclePrice(astonDb11PriceLabel.Text);
            purshaseForm.setVehicleImage(Db11pictureBox.Image);

            purshaseForm.ShowDialog();
            this.Hide();
        }

        private void purchaseAstonDbxButton_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(dbxAstonLabel.Text);
            purshaseForm.setVehiclePrice(astonDbxPriceLabel.Text);
            purshaseForm.setVehicleImage(DbxpictureBox.Image);

            purshaseForm.ShowDialog();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}