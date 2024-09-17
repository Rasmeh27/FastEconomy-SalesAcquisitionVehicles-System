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
    public partial class lexusForm : Form
    {
        public lexusForm()
        {
            InitializeComponent();
        }

        private void purchaseLexusIsButton_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(isLexuslabel.Text);
            purshaseForm.setVehiclePrice(lexusIsPriceLabel.Text);
            purshaseForm.setVehicleImage(IspictureBox.Image);

            purshaseForm.ShowDialog();
            this.Hide();
        }

        private void purchaseLexusLxButton_Click(object sender, EventArgs e)
        {
            purshaseForm purshaseForm = new purshaseForm();

            purshaseForm.setVehicleName(lxLexusLabel.Text);
            purshaseForm.setVehiclePrice(lexusLxPriceLabel.Text);
            purshaseForm.setVehicleImage(LxpictureBox.Image);

            purshaseForm.ShowDialog();
            this.Hide();
        }

        private void lexusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
