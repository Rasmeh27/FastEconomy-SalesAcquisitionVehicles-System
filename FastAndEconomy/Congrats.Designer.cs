﻿namespace FastAndEconomy
{
    partial class Congrats
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
            homeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(71, 74);
            label1.Name = "label1";
            label1.Size = new Size(615, 65);
            label1.TabIndex = 1;
            label1.Text = "Felicidades por su compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(71, 158);
            label2.Name = "label2";
            label2.Size = new Size(648, 65);
            label2.TabIndex = 2;
            label2.Text = "Agradecemos por elegirnos";
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(0, 192, 192);
            homeButton.Location = new Point(290, 266);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(155, 64);
            homeButton.TabIndex = 3;
            homeButton.Text = "HOME";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // Congrats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(800, 450);
            Controls.Add(homeButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Congrats";
            Text = "Congrats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button homeButton;
    }
}