namespace FastAndEconomy
{
    partial class homeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            groupBox1 = new GroupBox();
            mercedesPictureBox4 = new PictureBox();
            lexusPictureBox3 = new PictureBox();
            astonMartinPictureBox2 = new PictureBox();
            bmwPictureBox1 = new PictureBox();
            carSectionLabel = new Label();
            salesbutton = new Button();
            adquisicionButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mercedesPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lexusPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)astonMartinPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bmwPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(mercedesPictureBox4);
            groupBox1.Controls.Add(lexusPictureBox3);
            groupBox1.Controls.Add(astonMartinPictureBox2);
            groupBox1.Controls.Add(bmwPictureBox1);
            groupBox1.Controls.Add(carSectionLabel);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(85, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1187, 499);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fast&Economy";
            // 
            // mercedesPictureBox4
            // 
            mercedesPictureBox4.Cursor = Cursors.Hand;
            mercedesPictureBox4.Image = (Image)resources.GetObject("mercedesPictureBox4.Image");
            mercedesPictureBox4.Location = new Point(593, 318);
            mercedesPictureBox4.Name = "mercedesPictureBox4";
            mercedesPictureBox4.Size = new Size(581, 145);
            mercedesPictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            mercedesPictureBox4.TabIndex = 4;
            mercedesPictureBox4.TabStop = false;
            mercedesPictureBox4.Click += mercedesPictureBox4_Click;
            // 
            // lexusPictureBox3
            // 
            lexusPictureBox3.Cursor = Cursors.Hand;
            lexusPictureBox3.Image = (Image)resources.GetObject("lexusPictureBox3.Image");
            lexusPictureBox3.Location = new Point(6, 318);
            lexusPictureBox3.Name = "lexusPictureBox3";
            lexusPictureBox3.Size = new Size(581, 145);
            lexusPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            lexusPictureBox3.TabIndex = 3;
            lexusPictureBox3.TabStop = false;
            lexusPictureBox3.Click += lexusPictureBox3_Click;
            // 
            // astonMartinPictureBox2
            // 
            astonMartinPictureBox2.Cursor = Cursors.Hand;
            astonMartinPictureBox2.Image = (Image)resources.GetObject("astonMartinPictureBox2.Image");
            astonMartinPictureBox2.Location = new Point(593, 117);
            astonMartinPictureBox2.Name = "astonMartinPictureBox2";
            astonMartinPictureBox2.Size = new Size(581, 145);
            astonMartinPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            astonMartinPictureBox2.TabIndex = 2;
            astonMartinPictureBox2.TabStop = false;
            astonMartinPictureBox2.Click += astonMartinPictureBox2_Click;
            // 
            // bmwPictureBox1
            // 
            bmwPictureBox1.Cursor = Cursors.Hand;
            bmwPictureBox1.Image = (Image)resources.GetObject("bmwPictureBox1.Image");
            bmwPictureBox1.Location = new Point(6, 117);
            bmwPictureBox1.Name = "bmwPictureBox1";
            bmwPictureBox1.Size = new Size(581, 145);
            bmwPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            bmwPictureBox1.TabIndex = 1;
            bmwPictureBox1.TabStop = false;
            bmwPictureBox1.Click += bmwPictureBox1_Click;
            // 
            // carSectionLabel
            // 
            carSectionLabel.AutoSize = true;
            carSectionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carSectionLabel.Location = new Point(6, 80);
            carSectionLabel.Name = "carSectionLabel";
            carSectionLabel.Size = new Size(187, 21);
            carSectionLabel.TabIndex = 0;
            carSectionLabel.Text = "Seccion de vehiculos →";
            // 
            // salesbutton
            // 
            salesbutton.Cursor = Cursors.Hand;
            salesbutton.Location = new Point(2, 88);
            salesbutton.Name = "salesbutton";
            salesbutton.Size = new Size(83, 22);
            salesbutton.TabIndex = 5;
            salesbutton.Text = "Ventas";
            salesbutton.UseVisualStyleBackColor = true;
            salesbutton.Click += salesbutton_Click;
            // 
            // adquisicionButton
            // 
            adquisicionButton.Location = new Point(2, 126);
            adquisicionButton.Name = "adquisicionButton";
            adquisicionButton.Size = new Size(83, 22);
            adquisicionButton.TabIndex = 6;
            adquisicionButton.Text = "Adquisicion";
            adquisicionButton.UseVisualStyleBackColor = true;
            adquisicionButton.Click += adquisicionButton_Click;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1284, 515);
            Controls.Add(adquisicionButton);
            Controls.Add(salesbutton);
            Controls.Add(groupBox1);
            Name = "homeForm";
            Text = "Home";
            Load += homeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mercedesPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)lexusPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)astonMartinPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bmwPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox bmwPictureBox1;
        private Label carSectionLabel;
        private PictureBox mercedesPictureBox4;
        private PictureBox lexusPictureBox3;
        private PictureBox astonMartinPictureBox2;
        private Button salesbutton;
        private Button adquisicionButton;
    }
}
