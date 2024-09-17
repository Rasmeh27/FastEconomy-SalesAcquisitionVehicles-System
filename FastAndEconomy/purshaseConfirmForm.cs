using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FastAndEconomy
{
    public partial class purshaseConfirmForm : Form
    {
        public purshaseConfirmForm()
        {
            InitializeComponent();
            this.vehicleName = vehicleName;
            this.vehiclePrice = vehiclePrice;
            vehicleDetails();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-CEL6MBF; database=Concesionario;integrated security=true");
        private string vehicleName;
        private string vehiclePrice;

        private void vehicleDetails()
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = nombreClienteBox.Text;
            string customerLastName = apellidoBox.Text; 
            string customerEmail = emailBox.Text;
            string customerPhone = phoneBox.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerLastName) || string.IsNullOrEmpty(customerEmail) || string.IsNullOrEmpty(customerEmail) || string.IsNullOrEmpty(customerPhone)) 
            {
                MessageBox.Show("Por favor completar los campos.");
                return;
            }

            Congrats congrats = new Congrats();
            congrats.Show();

        }
    }
}
