namespace FastAndEconomy
{
    partial class purshaseConfirmForm
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
            nombreClienteBox = new TextBox();
            label2 = new Label();
            apellidoBox = new TextBox();
            label3 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            phoneBox = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 0;
            label1.Text = "Registra tus datos";
            // 
            // nombreClienteBox
            // 
            nombreClienteBox.Location = new Point(12, 93);
            nombreClienteBox.Name = "nombreClienteBox";
            nombreClienteBox.Size = new Size(188, 23);
            nombreClienteBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // apellidoBox
            // 
            apellidoBox.Location = new Point(12, 142);
            apellidoBox.Name = "apellidoBox";
            apellidoBox.Size = new Size(188, 23);
            apellidoBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(12, 186);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(188, 23);
            emailBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo electronico";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(12, 228);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(188, 23);
            phoneBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 212);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 8;
            label5.Text = "Numero telefonico";
            // 
            // button1
            // 
            button1.Location = new Point(12, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // purshaseConfirmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(phoneBox);
            Controls.Add(label4);
            Controls.Add(emailBox);
            Controls.Add(label3);
            Controls.Add(apellidoBox);
            Controls.Add(label2);
            Controls.Add(nombreClienteBox);
            Controls.Add(label1);
            Name = "purshaseConfirmForm";
            Text = "purshaseConfirmForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nombreClienteBox;
        private Label label2;
        private TextBox apellidoBox;
        private Label label3;
        private TextBox emailBox;
        private Label label4;
        private TextBox phoneBox;
        private Label label5;
        private Button button1;
    }
}