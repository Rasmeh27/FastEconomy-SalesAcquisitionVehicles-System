namespace FastAndEconomy
{
    partial class AcquisitionForm
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
            dataGridViewAcquisition = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nombreDeClienteText = new TextBox();
            label4 = new Label();
            vehiculosAdquiridosTextBox = new TextBox();
            dateTimeAdquisicion = new DateTimePicker();
            buttonRegisterAcquisition = new Button();
            precioDeAdquisicionText = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAcquisition).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAcquisition
            // 
            dataGridViewAcquisition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAcquisition.Location = new Point(305, 92);
            dataGridViewAcquisition.Name = "dataGridViewAcquisition";
            dataGridViewAcquisition.Size = new Size(483, 304);
            dataGridViewAcquisition.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 32);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE ADQUISICION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(305, 59);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 2;
            label2.Text = "MOVIMIENTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 3;
            label3.Text = "Vehiculos adquiridos";
            // 
            // nombreDeClienteText
            // 
            nombreDeClienteText.Location = new Point(12, 167);
            nombreDeClienteText.Name = "nombreDeClienteText";
            nombreDeClienteText.Size = new Size(173, 23);
            nombreDeClienteText.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Clientes";
            // 
            // vehiculosAdquiridosTextBox
            // 
            vehiculosAdquiridosTextBox.Location = new Point(12, 83);
            vehiculosAdquiridosTextBox.Name = "vehiculosAdquiridosTextBox";
            vehiculosAdquiridosTextBox.Size = new Size(173, 23);
            vehiculosAdquiridosTextBox.TabIndex = 4;
            // 
            // dateTimeAdquisicion
            // 
            dateTimeAdquisicion.Location = new Point(12, 112);
            dateTimeAdquisicion.Name = "dateTimeAdquisicion";
            dateTimeAdquisicion.Size = new Size(173, 23);
            dateTimeAdquisicion.TabIndex = 7;
            // 
            // buttonRegisterAcquisition
            // 
            buttonRegisterAcquisition.Location = new Point(12, 252);
            buttonRegisterAcquisition.Name = "buttonRegisterAcquisition";
            buttonRegisterAcquisition.Size = new Size(100, 34);
            buttonRegisterAcquisition.TabIndex = 8;
            buttonRegisterAcquisition.Text = "Registrar";
            buttonRegisterAcquisition.UseVisualStyleBackColor = true;
            buttonRegisterAcquisition.Click += buttonRegisterAcquisition_Click;
            // 
            // precioDeAdquisicionText
            // 
            precioDeAdquisicionText.Location = new Point(12, 214);
            precioDeAdquisicionText.Name = "precioDeAdquisicionText";
            precioDeAdquisicionText.Size = new Size(173, 23);
            precioDeAdquisicionText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 196);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 9;
            label5.Text = "Precio de adquisicion";
            // 
            // AcquisitionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(800, 450);
            Controls.Add(precioDeAdquisicionText);
            Controls.Add(label5);
            Controls.Add(buttonRegisterAcquisition);
            Controls.Add(dateTimeAdquisicion);
            Controls.Add(nombreDeClienteText);
            Controls.Add(label4);
            Controls.Add(vehiculosAdquiridosTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAcquisition);
            Name = "AcquisitionForm";
            Text = "AcquisitionForm";
            Load += AcquisitionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAcquisition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAcquisition;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nombreDeClienteText;
        private Label label4;
        private TextBox vehiculosAdquiridosTextBox;
        private DateTimePicker dateTimeAdquisicion;
        private Button buttonRegisterAcquisition;
        private TextBox precioDeAdquisicionText;
        private Label label5;
    }
}