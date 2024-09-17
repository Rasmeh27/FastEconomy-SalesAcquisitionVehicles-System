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
    public partial class bmwForm : Form
    {
        public bmwForm()
        {
            InitializeComponent();
        }

        private void purchaseX6mButton_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(x6mBmwlabel.Text);
            purshaseForm.setVehiclePrice(bmwXmPriceLabel.Text);
            purshaseForm.setVehicleImage(bmwPictureBox.Image);

            purshaseForm.Show();
            this.Hide();
        }

        private void purchaseM4Button_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(bmwM4Label.Text);
            purshaseForm.setVehiclePrice(bmwCompetitionPriceLabel.Text);
            purshaseForm.setVehicleImage(M4pictureBox2.Image);

            purshaseForm.ShowDialog();
            this.Hide();
        }
    }
}
