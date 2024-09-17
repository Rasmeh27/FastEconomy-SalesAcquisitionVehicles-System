
namespace FastAndEconomy
{
    partial class salesRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxVehicleSold = new ComboBox();
            label4 = new Label();
            dateTimePickerVentas = new DateTimePicker();
            label5 = new Label();
            registerSaleButton = new Button();
            dataGridVentas = new DataGridView();
            textBoxCustomerName = new TextBox();
            textBoxPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(244, 68);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "MOVIMIENTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MistyRose;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(295, 37);
            label3.TabIndex = 2;
            label3.Text = "REGISTRO DE VENTAS";
            // 
            // comboBoxVehicleSold
            // 
            comboBoxVehicleSold.FormattingEnabled = true;
            comboBoxVehicleSold.Location = new Point(12, 187);
            comboBoxVehicleSold.Name = "comboBoxVehicleSold";
            comboBoxVehicleSold.Size = new Size(180, 23);
            comboBoxVehicleSold.TabIndex = 3;
            comboBoxVehicleSold.SelectedIndexChanged += this.comboBoxVehicleSold_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(161, 15);
            label4.TabIndex = 4;
            label4.Text = "Seleccionar vehiculo vendido";
            label4.Click += label4_Click;
            // 
            // dateTimePickerVentas
            // 
            dateTimePickerVentas.Location = new Point(12, 216);
            dateTimePickerVentas.Name = "dateTimePickerVentas";
            dateTimePickerVentas.Size = new Size(218, 23);
            dateTimePickerVentas.TabIndex = 5;
            dateTimePickerVentas.ValueChanged += this.dateTimePickerVentas_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 260);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 6;
            label5.Text = "Precio de la venta";
            label5.Click += this.label5_Click;
            // 
            // registerSaleButton
            // 
            registerSaleButton.BackColor = Color.CadetBlue;
            registerSaleButton.Cursor = Cursors.Hand;
            registerSaleButton.Location = new Point(12, 317);
            registerSaleButton.Name = "registerSaleButton";
            registerSaleButton.Size = new Size(144, 23);
            registerSaleButton.TabIndex = 7;
            registerSaleButton.Text = "Registrar venta";
            registerSaleButton.UseVisualStyleBackColor = false;
            registerSaleButton.Click += registerSaleButton_Click;
            // 
            // dataGridVentas
            // 
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVentas.Location = new Point(244, 108);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.Size = new Size(553, 324);
            dataGridVentas.TabIndex = 8;
            dataGridVentas.CellContentClick += dataGridVentas_CellContentClick;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(12, 143);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(180, 23);
            textBoxCustomerName.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(12, 278);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(218, 23);
            textBoxPrice.TabIndex = 10;
            textBoxPrice.TextChanged += this.textBoxPrice_TextChanged;
            // 
            // salesRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(809, 548);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCustomerName);
            Controls.Add(dataGridVentas);
            Controls.Add(registerSaleButton);
            Controls.Add(label5);
            Controls.Add(dateTimePickerVentas);
            Controls.Add(label4);
            Controls.Add(comboBoxVehicleSold);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "salesRecordForm";
            Text = "salesRecordForm";
            Load += salesRecordForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxVehicleSold;
        private Label label4;
        private DateTimePicker dateTimePickerVentas;
        private Label label5;
        private Button registerSaleButton;
        private DataGridView dataGridVentas;
        private TextBox textBoxCustomerName;
        private TextBox textBoxPrice;
        private EventHandler dateTimePickerVentas_ValueChanged;
    }
}