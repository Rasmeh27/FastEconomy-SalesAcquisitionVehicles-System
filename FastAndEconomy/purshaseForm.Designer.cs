namespace FastAndEconomy
{
    partial class purshaseForm
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
            marcaVehiculoLb = new Label();
            precioVehiculoLb = new Label();
            pagarBtn = new Button();
            vehiculoPictureBox1 = new PictureBox();
            whiteButton = new Button();
            redButton = new Button();
            grayButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)vehiculoPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(295, 45);
            label1.TabIndex = 0;
            label1.Text = "Confirmar compra";
            // 
            // marcaVehiculoLb
            // 
            marcaVehiculoLb.AutoSize = true;
            marcaVehiculoLb.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            marcaVehiculoLb.ForeColor = SystemColors.ButtonFace;
            marcaVehiculoLb.Location = new Point(15, 107);
            marcaVehiculoLb.Name = "marcaVehiculoLb";
            marcaVehiculoLb.Size = new Size(237, 32);
            marcaVehiculoLb.TabIndex = 1;
            marcaVehiculoLb.Text = "Marca del vehiculo ";
            // 
            // precioVehiculoLb
            // 
            precioVehiculoLb.AutoSize = true;
            precioVehiculoLb.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            precioVehiculoLb.ForeColor = SystemColors.ButtonFace;
            precioVehiculoLb.Location = new Point(15, 160);
            precioVehiculoLb.Name = "precioVehiculoLb";
            precioVehiculoLb.Size = new Size(238, 32);
            precioVehiculoLb.TabIndex = 2;
            precioVehiculoLb.Text = "Precio del vehiculo ";
            // 
            // pagarBtn
            // 
            pagarBtn.BackColor = Color.LightSkyBlue;
            pagarBtn.ForeColor = SystemColors.ActiveCaptionText;
            pagarBtn.Location = new Point(28, 229);
            pagarBtn.Name = "pagarBtn";
            pagarBtn.Size = new Size(224, 49);
            pagarBtn.TabIndex = 3;
            pagarBtn.Text = "Pagar";
            pagarBtn.UseVisualStyleBackColor = false;
            pagarBtn.Click += pagarBtn_Click;
            // 
            // vehiculoPictureBox1
            // 
            vehiculoPictureBox1.Location = new Point(314, 12);
            vehiculoPictureBox1.Name = "vehiculoPictureBox1";
            vehiculoPictureBox1.Size = new Size(565, 266);
            vehiculoPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            vehiculoPictureBox1.TabIndex = 4;
            vehiculoPictureBox1.TabStop = false;
            // 
            // whiteButton
            // 
            whiteButton.BackColor = Color.Gainsboro;
            whiteButton.ForeColor = SystemColors.ActiveCaptionText;
            whiteButton.Location = new Point(314, 315);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(112, 49);
            whiteButton.TabIndex = 5;
            whiteButton.UseVisualStyleBackColor = false;
            whiteButton.Click += whiteButton_Click;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Crimson;
            redButton.ForeColor = SystemColors.ActiveCaptionText;
            redButton.Location = new Point(432, 315);
            redButton.Name = "redButton";
            redButton.Size = new Size(112, 49);
            redButton.TabIndex = 6;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += redButton_Click;
            // 
            // grayButton
            // 
            grayButton.BackColor = Color.FromArgb(64, 64, 64);
            grayButton.ForeColor = SystemColors.ActiveCaptionText;
            grayButton.Location = new Point(550, 315);
            grayButton.Name = "grayButton";
            grayButton.Size = new Size(112, 49);
            grayButton.TabIndex = 7;
            grayButton.UseVisualStyleBackColor = false;
            grayButton.Click += grayButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(314, 297);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = "Seleccionar color";
            // 
            // purshaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(891, 424);
            Controls.Add(label2);
            Controls.Add(grayButton);
            Controls.Add(redButton);
            Controls.Add(whiteButton);
            Controls.Add(vehiculoPictureBox1);
            Controls.Add(pagarBtn);
            Controls.Add(precioVehiculoLb);
            Controls.Add(marcaVehiculoLb);
            Controls.Add(label1);
            Name = "purshaseForm";
            Text = "purshaseForm";
            ((System.ComponentModel.ISupportInitialize)vehiculoPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label marcaVehiculoLb;
        private Label precioVehiculoLb;
        private Button pagarBtn;
        private PictureBox vehiculoPictureBox1;
        private Button whiteButton;
        private Button redButton;
        private Button grayButton;
        private Label label2;
    }
}