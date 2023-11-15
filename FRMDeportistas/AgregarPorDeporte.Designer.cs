namespace FRMDeportistas
{
    partial class AgregarPorDeporte
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
            panelCentral = new Panel();
            lblSeleccioneDeporte = new Label();
            btnAgregarVoley = new Button();
            btnAgregarAtletismo = new Button();
            btnAgregarEscalada = new Button();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.FromArgb(23, 107, 135);
            panelCentral.Controls.Add(lblSeleccioneDeporte);
            panelCentral.Controls.Add(btnAgregarVoley);
            panelCentral.Controls.Add(btnAgregarAtletismo);
            panelCentral.Controls.Add(btnAgregarEscalada);
            panelCentral.Location = new Point(-1, 0);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(952, 455);
            panelCentral.TabIndex = 0;
            // 
            // lblSeleccioneDeporte
            // 
            lblSeleccioneDeporte.AutoSize = true;
            lblSeleccioneDeporte.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccioneDeporte.Location = new Point(365, 94);
            lblSeleccioneDeporte.Name = "lblSeleccioneDeporte";
            lblSeleccioneDeporte.Size = new Size(223, 30);
            lblSeleccioneDeporte.TabIndex = 3;
            lblSeleccioneDeporte.Text = "Seleccione el deporte";
            // 
            // btnAgregarVoley
            // 
            btnAgregarVoley.FlatStyle = FlatStyle.Flat;
            btnAgregarVoley.ForeColor = Color.White;
            btnAgregarVoley.Location = new Point(327, 320);
            btnAgregarVoley.Name = "btnAgregarVoley";
            btnAgregarVoley.Size = new Size(299, 41);
            btnAgregarVoley.TabIndex = 2;
            btnAgregarVoley.Text = "AgregarVoley";
            btnAgregarVoley.UseVisualStyleBackColor = true;
            btnAgregarVoley.Click += btnAgregarVoley_Click;
            // 
            // btnAgregarAtletismo
            // 
            btnAgregarAtletismo.FlatStyle = FlatStyle.Flat;
            btnAgregarAtletismo.ForeColor = Color.White;
            btnAgregarAtletismo.Location = new Point(327, 243);
            btnAgregarAtletismo.Name = "btnAgregarAtletismo";
            btnAgregarAtletismo.Size = new Size(299, 47);
            btnAgregarAtletismo.TabIndex = 1;
            btnAgregarAtletismo.Text = "Agregar Atletismo";
            btnAgregarAtletismo.UseVisualStyleBackColor = true;
            btnAgregarAtletismo.Click += btnAgregarAtletismo_Click;
            // 
            // btnAgregarEscalada
            // 
            btnAgregarEscalada.FlatStyle = FlatStyle.Flat;
            btnAgregarEscalada.ForeColor = Color.White;
            btnAgregarEscalada.Location = new Point(327, 168);
            btnAgregarEscalada.Name = "btnAgregarEscalada";
            btnAgregarEscalada.Size = new Size(299, 45);
            btnAgregarEscalada.TabIndex = 0;
            btnAgregarEscalada.Text = " Agregar Escalada";
            btnAgregarEscalada.UseVisualStyleBackColor = true;
            btnAgregarEscalada.Click += btnAgregarEscalada_Click;
            // 
            // AgregarPorDeporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 457);
            Controls.Add(panelCentral);
            Name = "AgregarPorDeporte";
            Text = "AgregarPorDeporte";
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCentral;
        private Label lblSeleccioneDeporte;
        private Button btnAgregarVoley;
        private Button btnAgregarAtletismo;
        private Button btnAgregarEscalada;
    }
}