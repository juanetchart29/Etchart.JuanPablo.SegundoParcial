namespace FRMDeportistas
{
    partial class FRMAgregar
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
            panel4 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel3 = new Panel();
            label6 = new Label();
            rbNoEntregado = new RadioButton();
            rbEntregado = new RadioButton();
            panel1 = new Panel();
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
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(lblError);
            panel4.Controls.Add(btnSiguiente);
            panel4.Location = new Point(1, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(959, 414);
            panel4.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 129, 112);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(radioButton1);
            panel5.Controls.Add(radioButton2);
            panel5.Location = new Point(472, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(429, 62);
            panel5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 21);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 10;
            label5.Text = "Certificado medico:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(304, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "No federado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(194, 20);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Federado";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 129, 112);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(rbNoEntregado);
            panel3.Controls.Add(rbEntregado);
            panel3.Location = new Point(26, 263);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 61);
            panel3.TabIndex = 2;
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
            panel1.Controls.Add(sectionCompetencia);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbDni);
            panel1.Controls.Add(txbApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbNombre);
            panel1.Location = new Point(26, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 236);
            panel1.TabIndex = 0;
            // 
            // sectionCompetencia
            // 
            sectionCompetencia.FormattingEnabled = true;
            sectionCompetencia.Items.AddRange(new object[] { "Masculino", "Femenino" });
            sectionCompetencia.Location = new Point(194, 184);
            sectionCompetencia.Name = "sectionCompetencia";
            sectionCompetencia.Size = new Size(223, 23);
            sectionCompetencia.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(53, 186);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 12;
            label7.Text = "Competencia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(111, 137);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 6;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(88, 72);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Apellido:";
            // 
            // txbDni
            // 
            txbDni.BackColor = Color.FromArgb(255, 245, 224);
            txbDni.Location = new Point(194, 135);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(223, 23);
            txbDni.TabIndex = 4;
            // 
            // txbApellido
            // 
            txbApellido.BackColor = Color.FromArgb(255, 245, 224);
            txbApellido.Location = new Point(194, 70);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(223, 23);
            txbApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 25);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txbNombre
            // 
            txbNombre.BackColor = Color.FromArgb(255, 245, 224);
            txbNombre.Location = new Point(194, 23);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(223, 23);
            txbNombre.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(446, 327);
            lblError.Name = "lblError";
            lblError.Size = new Size(64, 21);
            lblError.TabIndex = 7;
            lblError.Text = "lblError";
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(328, 351);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(303, 60);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 30);
            label1.Name = "label1";
            label1.Size = new Size(328, 30);
            label1.TabIndex = 20;
            label1.Text = "Ingrese los datos del deportista.";
            // 
            // FRMAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 107, 135);
            ClientSize = new Size(960, 519);
            Controls.Add(panel4);
            Controls.Add(label1);
            Name = "FRMAgregar";
            Text = "FRMAgregar";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel3;
        private Label label6;
        private RadioButton rbNoEntregado;
        private RadioButton rbEntregado;
        private Panel panel1;
        private ComboBox sectionCompetencia;
        private Label label7;
        private Label label4;
        private Label label3;
        private TextBox txbDni;
        private TextBox txbApellido;
        private Label label2;
        private TextBox txbNombre;
        private Label lblError;
        private Button btnSiguiente;
        private Label label1;
    }

    public class Class2
    {
    }
}