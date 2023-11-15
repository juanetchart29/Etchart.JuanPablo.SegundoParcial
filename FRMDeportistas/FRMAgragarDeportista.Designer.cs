namespace FRMDeportistas
{
    partial class FRMAgragarDeportista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            panel4 = new Panel();
            panelPadre2 = new Panel();
            label5 = new Label();
            rbNoFederado = new RadioButton();
            rbFederado = new RadioButton();
            panelPadre1 = new Panel();
            label6 = new Label();
            rbNoEntregado = new RadioButton();
            rbEntregado = new RadioButton();
            panel1 = new Panel();
            lblEdad = new Label();
            txtBoxEdad = new TextBox();
            sectionCompetencia = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            txbDni = new TextBox();
            txbApellido = new TextBox();
            label2 = new Label();
            txbNombre = new TextBox();
            lblError = new Label();
            btnSiguiente = new Button();
            label1 = new Label();
            panel4.SuspendLayout();
            panelPadre2.SuspendLayout();
            panelPadre1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(panelPadre2);
            panel4.Controls.Add(panelPadre1);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(lblError);
            panel4.Controls.Add(btnSiguiente);
            panel4.Location = new Point(3, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(942, 402);
            panel4.TabIndex = 25;
            // 
            // panelPadre2
            // 
            panelPadre2.BackColor = Color.FromArgb(0, 129, 112);
            panelPadre2.Controls.Add(label5);
            panelPadre2.Controls.Add(rbNoFederado);
            panelPadre2.Controls.Add(rbFederado);
            panelPadre2.Location = new Point(472, 3);
            panelPadre2.Name = "panelPadre2";
            panelPadre2.Size = new Size(429, 62);
            panelPadre2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(82, 21);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 10;
            label5.Text = "Estado: ";
            // 
            // rbNoFederado
            // 
            rbNoFederado.AutoSize = true;
            rbNoFederado.Location = new Point(304, 23);
            rbNoFederado.Name = "rbNoFederado";
            rbNoFederado.Size = new Size(91, 19);
            rbNoFederado.TabIndex = 9;
            rbNoFederado.TabStop = true;
            rbNoFederado.Text = "No federado";
            rbNoFederado.UseVisualStyleBackColor = true;
            // 
            // rbFederado
            // 
            rbFederado.Location = new Point(194, 20);
            rbFederado.Name = "rbFederado";
            rbFederado.Size = new Size(104, 24);
            rbFederado.TabIndex = 11;
            rbFederado.Text = "Federado";
            // 
            // panelPadre1
            // 
            panelPadre1.BackColor = Color.FromArgb(0, 129, 112);
            panelPadre1.Controls.Add(label6);
            panelPadre1.Controls.Add(rbNoEntregado);
            panelPadre1.Controls.Add(rbEntregado);
            panelPadre1.Location = new Point(26, 245);
            panelPadre1.Name = "panelPadre1";
            panelPadre1.Size = new Size(429, 61);
            panelPadre1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(9, 14);
            label6.Name = "label6";
            label6.Size = new Size(154, 21);
            label6.TabIndex = 10;
            label6.Text = "Certificado medico:";
            // 
            // rbNoEntregado
            // 
            rbNoEntregado.AutoSize = true;
            rbNoEntregado.Location = new Point(304, 17);
            rbNoEntregado.Name = "rbNoEntregado";
            rbNoEntregado.Size = new Size(98, 19);
            rbNoEntregado.TabIndex = 9;
            rbNoEntregado.TabStop = true;
            rbNoEntregado.Text = "No entregado";
            rbNoEntregado.UseVisualStyleBackColor = true;
            // 
            // rbEntregado
            // 
            rbEntregado.Location = new Point(194, 14);
            rbEntregado.Name = "rbEntregado";
            rbEntregado.Size = new Size(104, 24);
            rbEntregado.TabIndex = 11;
            rbEntregado.Text = "Entregado";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 129, 112);
            panel1.Controls.Add(lblEdad);
            panel1.Controls.Add(txtBoxEdad);
            panel1.Controls.Add(sectionCompetencia);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbDni);
            panel1.Controls.Add(txbApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbNombre);
            panel1.Location = new Point(26, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 236);
            panel1.TabIndex = 0;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.Location = new Point(112, 17);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(50, 21);
            lblEdad.TabIndex = 14;
            lblEdad.Text = "Edad:";
            // 
            // txtBoxEdad
            // 
            txtBoxEdad.BackColor = Color.FromArgb(255, 245, 224);
            txtBoxEdad.Location = new Point(194, 19);
            txtBoxEdad.Name = "txtBoxEdad";
            txtBoxEdad.Size = new Size(223, 23);
            txtBoxEdad.TabIndex = 13;
            // 
            // sectionCompetencia
            // 
            sectionCompetencia.FormattingEnabled = true;
            sectionCompetencia.Items.AddRange(new object[] { "Masculino", "Femenino" });
            sectionCompetencia.Location = new Point(194, 196);
            sectionCompetencia.Name = "sectionCompetencia";
            sectionCompetencia.Size = new Size(223, 23);
            sectionCompetencia.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(52, 198);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 12;
            label7.Text = "Competencia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(121, 157);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 6;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(87, 112);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Apellido:";
            // 
            // txbDni
            // 
            txbDni.BackColor = Color.FromArgb(255, 245, 224);
            txbDni.Location = new Point(194, 155);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(223, 23);
            txbDni.TabIndex = 4;
            // 
            // txbApellido
            // 
            txbApellido.BackColor = Color.FromArgb(255, 245, 224);
            txbApellido.Location = new Point(194, 110);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(223, 23);
            txbApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(87, 65);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txbNombre
            // 
            txbNombre.BackColor = Color.FromArgb(255, 245, 224);
            txbNombre.Location = new Point(194, 63);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(223, 23);
            txbNombre.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(435, 309);
            lblError.Name = "lblError";
            lblError.Size = new Size(64, 21);
            lblError.TabIndex = 7;
            lblError.Text = "lblError";
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(318, 333);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(303, 38);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(296, 21);
            label1.Name = "label1";
            label1.Size = new Size(328, 30);
            label1.TabIndex = 24;
            label1.Text = "Ingrese los datos del deportista.";
            // 
            // FRMAgragarDeportista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 107, 135);
            ClientSize = new Size(949, 457);
            Controls.Add(panel4);
            Controls.Add(label1);
            Name = "FRMAgragarDeportista";
            Text = "FRMAgragarDeportista";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelPadre2.ResumeLayout(false);
            panelPadre2.PerformLayout();
            panelPadre1.ResumeLayout(false);
            panelPadre1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel4;
        public Panel panelPadre2;
        public Label label5;
        public RadioButton rbNoFederado;
        public RadioButton rbFederado;
        public Panel panelPadre1;
        public Label label6;
        public RadioButton rbNoEntregado;
        public RadioButton rbEntregado;
        public Panel panel1;
        public ComboBox sectionCompetencia;
        public Label label7;
        public Label label4;
        public Label label3;
        public TextBox txbDni;
        public TextBox txbApellido;
        public Label label2;
        public TextBox txbNombre;
        public Label lblError;
        public Button btnSiguiente;
        public Label label1;
        public Label lblEdad;
        public TextBox txtBoxEdad;
    }
}