using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastAndEconomy
{
    public partial class AcquisitionForm : Form
    {
        public AcquisitionForm()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-CEL6MBF; database=Adquisicion;integrated security=true");

        private void AcquisitionForm_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Se ha conectado correctamente a la base de datos");
                conexion.Close();
                LoadAcquisitionData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se ha conectado a la base de datos: " + ex.Message);
            }
        }

        private void buttonRegisterAcquisition_Click(object sender, EventArgs e)
        {
            string vehiculosAdquiridos = vehiculosAdquiridosTextBox.Text;
            DateTime fechaDeAdquisicion = dateTimeAdquisicion.Value;
            string nombreCliente = nombreDeClienteText.Text;
            decimal precioDeAdquisicion;

            if (!decimal.TryParse(precioDeAdquisicionText.Text, out precioDeAdquisicion))
            {
                MessageBox.Show("Por favor ingrese un valor válido");
                return;
            }

            try
            {
                string query = "INSERT INTO Vehiculos (NombreCliente, VehiculoAdquirido, FechaDeAdquisicion, PrecioDeAdquisicion) VALUES (@NombreCliente, @VehiculoAdquirido, @FechaDeAdquisicion, @PrecioDeAdquisicion)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                    cmd.Parameters.AddWithValue("@VehiculoAdquirido", vehiculosAdquiridos); // corregido aquí
                    cmd.Parameters.AddWithValue("@FechaDeAdquisicion", fechaDeAdquisicion);
                    cmd.Parameters.AddWithValue("@PrecioDeAdquisicion", precioDeAdquisicion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Adquisición registrada exitosamente");
                    LoadAcquisitionData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, la adquisición no se ha registrado correctamente: " + ex.ToString());
            }
        }

        private void LoadAcquisitionData()
        {
            try
            {
                string query = "SELECT * FROM Vehiculos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewAcquisition.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de adquisición: " + ex.ToString());
            }
        }
    }
}

