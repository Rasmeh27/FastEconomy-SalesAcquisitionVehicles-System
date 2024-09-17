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
    public partial class Congrats : Form
    {
        public Congrats()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm();
            homeForm.Show();
            this.Close();
        }
    }
}
