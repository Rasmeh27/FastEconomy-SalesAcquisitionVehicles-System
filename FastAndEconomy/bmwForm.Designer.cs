namespace FastAndEconomy
{
    partial class bmwForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmwForm));
            groupBox1 = new GroupBox();
            bmwXmPriceLabel = new Label();
            purchaseX6mButton = new Button();
            richTextBox1 = new RichTextBox();
            x6mBmwlabel = new Label();
            bmwPictureBox = new PictureBox();
            groupBox2 = new GroupBox();
            bmwCompetitionPriceLabel = new Label();
            purchaseM4Button = new Button();
            richTextBox2 = new RichTextBox();
            bmwM4Label = new Label();
            M4pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bmwPictureBox).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)M4pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(bmwXmPriceLabel);
            groupBox1.Controls.Add(purchaseX6mButton);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(x6mBmwlabel);
            groupBox1.Controls.Add(bmwPictureBox);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(949, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BMW";
            // 
            // bmwXmPriceLabel
            // 
            bmwXmPriceLabel.AutoSize = true;
            bmwXmPriceLabel.Location = new Point(483, 279);
            bmwXmPriceLabel.Name = "bmwXmPriceLabel";
            bmwXmPriceLabel.Size = new Size(101, 20);
            bmwXmPriceLabel.TabIndex = 4;
            bmwXmPriceLabel.Text = "171.475 USD";
            // 
            // purchaseX6mButton
            // 
            purchaseX6mButton.BackColor = Color.MediumSlateBlue;
            purchaseX6mButton.Cursor = Cursors.Hand;
            purchaseX6mButton.ForeColor = SystemColors.ActiveCaptionText;
            purchaseX6mButton.Location = new Point(483, 340);
            purchaseX6mButton.Name = "purchaseX6mButton";
            purchaseX6mButton.Size = new Size(100, 34);
            purchaseX6mButton.TabIndex = 3;
            purchaseX6mButton.Text = "Comprar";
            purchaseX6mButton.UseVisualStyleBackColor = false;
            purchaseX6mButton.Click += purchaseX6mButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaptionText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Cornsilk;
            richTextBox1.Location = new Point(483, 113);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(435, 163);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // x6mBmwlabel
            // 
            x6mBmwlabel.AutoSize = true;
            x6mBmwlabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x6mBmwlabel.Location = new Point(483, 60);
            x6mBmwlabel.Name = "x6mBmwlabel";
            x6mBmwlabel.Size = new Size(208, 50);
            x6mBmwlabel.TabIndex = 1;
            x6mBmwlabel.Text = "BMW X6M";
            // 
            // bmwPictureBox
            // 
            bmwPictureBox.Image = (Image)resources.GetObject("bmwPictureBox.Image");
            bmwPictureBox.Location = new Point(18, 60);
            bmwPictureBox.Name = "bmwPictureBox";
            bmwPictureBox.Size = new Size(459, 314);
            bmwPictureBox.TabIndex = 0;
            bmwPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(bmwCompetitionPriceLabel);
            groupBox2.Controls.Add(purchaseM4Button);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(bmwM4Label);
            groupBox2.Controls.Add(M4pictureBox2);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(12, 455);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(949, 437);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "BMW";
            // 
            // bmwCompetitionPriceLabel
            // 
            bmwCompetitionPriceLabel.AutoSize = true;
            bmwCompetitionPriceLabel.Location = new Point(496, 302);
            bmwCompetitionPriceLabel.Name = "bmwCompetitionPriceLabel";
            bmwCompetitionPriceLabel.Size = new Size(96, 20);
            bmwCompetitionPriceLabel.TabIndex = 4;
            bmwCompetitionPriceLabel.Text = "82.975  USD";
            // 
            // purchaseM4Button
            // 
            purchaseM4Button.BackColor = Color.MediumSlateBlue;
            purchaseM4Button.Cursor = Cursors.Hand;
            purchaseM4Button.ForeColor = SystemColors.ActiveCaptionText;
            purchaseM4Button.Location = new Point(496, 340);
            purchaseM4Button.Name = "purchaseM4Button";
            purchaseM4Button.Size = new Size(100, 34);
            purchaseM4Button.TabIndex = 3;
            purchaseM4Button.Text = "Comprar";
            purchaseM4Button.UseVisualStyleBackColor = false;
            purchaseM4Button.Click += purchaseM4Button_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.InactiveCaptionText;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.ForeColor = Color.Cornsilk;
            richTextBox2.Location = new Point(496, 113);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(435, 186);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // bmwM4Label
            // 
            bmwM4Label.AutoSize = true;
            bmwM4Label.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bmwM4Label.Location = new Point(483, 60);
            bmwM4Label.Name = "bmwM4Label";
            bmwM4Label.Size = new Size(448, 50);
            bmwM4Label.TabIndex = 1;
            bmwM4Label.Text = "BMW M4 COMPETITION";
            // 
            // M4pictureBox2
            // 
            M4pictureBox2.Image = (Image)resources.GetObject("M4pictureBox2.Image");
            M4pictureBox2.Location = new Point(18, 60);
            M4pictureBox2.Name = "M4pictureBox2";
            M4pictureBox2.Size = new Size(459, 314);
            M4pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            M4pictureBox2.TabIndex = 0;
            M4pictureBox2.TabStop = false;
            // 
            // bmwForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(973, 944);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "bmwForm";
            Text = "BMW ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bmwPictureBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)M4pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label x6mBmwlabel;
        private PictureBox bmwPictureBox;
        private Label bmwXmPriceLabel;
        private Button purchaseX6mButton;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private Label bmwCompetitionPriceLabel;
        private Button purchaseM4Button;
        private RichTextBox richTextBox2;
        private Label bmwM4Label;
        private PictureBox M4pictureBox2;
    }
}