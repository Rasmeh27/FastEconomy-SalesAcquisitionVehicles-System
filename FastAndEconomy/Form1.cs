namespace FastAndEconomy
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void bmwPictureBox1_Click(object sender, EventArgs e)
        {
            bmwForm bmwForm = new bmwForm();
            bmwForm.ShowDialog();

        }

        private void astonMartinPictureBox2_Click(object sender, EventArgs e)
        {
            astonMartinForm astonMartinForm = new astonMartinForm();
            astonMartinForm.ShowDialog();

        }

        private void lexusPictureBox3_Click(object sender, EventArgs e)
        {
            lexusForm lexusForm = new lexusForm();
            lexusForm.ShowDialog();

        }

        private void mercedesPictureBox4_Click(object sender, EventArgs e)
        {
            mercedesForm mercedesForm = new mercedesForm();
            mercedesForm.ShowDialog();

        }

        private void homeForm_Load(object sender, EventArgs e)
        {

        }

        private void salesbutton_Click(object sender, EventArgs e)
        {
            salesRecordForm salesRecordForm = new salesRecordForm();
            salesRecordForm.ShowDialog();
        }

        private void adquisicionButton_Click(object sender, EventArgs e)
        {
            AcquisitionForm acquisitionForm = new AcquisitionForm();   
            acquisitionForm.ShowDialog();
        }
    }
}
