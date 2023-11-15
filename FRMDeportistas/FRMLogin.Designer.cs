namespace FRMDeportistas
{
    partial class FRMLogin
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
            BtnIngresar = new Button();
            txtboxEmail = new TextBox();
            txtBoxContraseña = new TextBox();
            lblEmail = new Label();
            label2 = new Label();
            checkContraseña = new CheckBox();
            SuspendLayout();
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(222, 238);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(167, 34);
            BtnIngresar.TabIndex = 0;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += button1_Click;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(185, 71);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(240, 23);
            txtboxEmail.TabIndex = 1;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.Location = new Point(185, 140);
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.Size = new Size(240, 23);
            txtBoxContraseña.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(78, 74);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 140);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // checkContraseña
            // 
            checkContraseña.AutoSize = true;
            checkContraseña.Location = new Point(442, 142);
            checkContraseña.Name = "checkContraseña";
            checkContraseña.Size = new Size(103, 19);
            checkContraseña.TabIndex = 8;
            checkContraseña.Text = "Ver contraseña";
            checkContraseña.UseVisualStyleBackColor = true;
            checkContraseña.CheckedChanged += checkContraseña_CheckedChanged;
            // 
            // FRMLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 51, 71);
            ClientSize = new Size(580, 418);
            Controls.Add(checkContraseña);
            Controls.Add(label2);
            Controls.Add(lblEmail);
            Controls.Add(txtBoxContraseña);
            Controls.Add(txtboxEmail);
            Controls.Add(BtnIngresar);
            Name = "FRMLogin";
            Text = "Form1";
            Load += FRMLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnIngresar;
        private TextBox txtboxEmail;
        private TextBox txtBoxContraseña;
        private Label lblEmail;
        private Label label2;
        private CheckBox checkContraseña;
    }
}