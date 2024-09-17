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
    public partial class salesRecordForm : Form
    {
        public salesRecordForm()
        {
            InitializeComponent();

        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-CEL6MBF; database=Concesionario;integrated security=true");
        private void salesRecordForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenar el ComboBox con la lista de vehículos
                comboBoxVehicleSold.DataSource = new BindingSource(VehiculosDisponibles.Vehiculos, null);
                comboBoxVehicleSold.DisplayMember = "Key";
                comboBoxVehicleSold.ValueMember = "Value";

                // Probar la conexión a la base de datos
                conexion.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.");
                conexion.Close();

                LoadSalesData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: " + ex.Message);
            }
        }

        private void registerSaleButton_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBoxCustomerName.Text;
            string vehiculoVendido = ((KeyValuePair<string, string>)comboBoxVehicleSold.SelectedItem).Key;
            DateTime fechaDeVenta = dateTimePickerVentas.Value;
            decimal precioVenta;

            if (!decimal.TryParse(textBoxPrice.Text, out precioVenta))
            {
                MessageBox.Show("Por favor, ingresa un precio de venta válido.");
                return;
            }

            //Insertar datos en la base Datos
            try
            {
                string query = "INSERT INTO Ventas (NombreCliente, VehiculoVendido, FechaVenta, PrecioDeVenta) VALUES (@NombreCliente, @VehiculoVendido, @FechaVenta, @PrecioDeVenta)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                    cmd.Parameters.AddWithValue("@VehiculoVendido", vehiculoVendido);
                    cmd.Parameters.AddWithValue("@FechaVenta", fechaDeVenta);
                    cmd.Parameters.AddWithValue("@PrecioDeVenta", precioVenta);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Venta registrada exitosamente.");

                    LoadSalesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.ToString());
            }

        }

        private void LoadSalesData()
        {
            try
            {
                string query = "SELECT * FROM Ventas";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridVentas.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de ventas: " + ex.Message);
            }
        }

        private void comboBoxVehicleSold_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí obtienes el vehículo seleccionado
            string vehiculoSeleccionado = ((KeyValuePair<string, string>)comboBoxVehicleSold.SelectedItem).Key;

            // Puedes realizar cualquier acción necesaria cuando cambie la selección, por ejemplo, mostrar detalles del vehículo
            MessageBox.Show("Has seleccionado el vehículo: " + vehiculoSeleccionado);
        }

        private void UpdateVehiculosDisponibles()
        {
            VehiculosDisponibles.Vehiculos.Clear();
            VehiculosDisponibles.Vehiculos.Add("BMW X6M", "171.475 USD");
            VehiculosDisponibles.Vehiculos.Add("BMW M4 Competition", "154.295 USD");
            VehiculosDisponibles.Vehiculos.Add("Mercedes AMG GLS 63", "160.500 USD");
            VehiculosDisponibles.Vehiculos.Add("Mercedes AMG GT 63 S", "189.750 USD");
            VehiculosDisponibles.Vehiculos.Add("Lexus IS 350 SPORT", "43.050 USD");
            VehiculosDisponibles.Vehiculos.Add("Lexus LX 600", "92.975 USD");
            VehiculosDisponibles.Vehiculos.Add("Aston Martin DB11", "205.600 USD");
            VehiculosDisponibles.Vehiculos.Add("Aston Martin DBX 707", "232.000 USD");
        }

        private void dataGridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Aquí puedes colocar el código que deseas ejecutar cuando se haga clic en label5
            MessageBox.Show("¡Has hecho clic en el Label 5!");
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes colocar el código que deseas ejecutar cuando cambie el texto en textBoxPrice
            // Por ejemplo, validar el formato del precio o realizar alguna acción en respuesta al cambio de texto
        }
    }

}



