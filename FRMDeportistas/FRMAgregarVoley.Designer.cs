namespace FRMDeportistas
{
    partial class FRMAgregarVoley
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
            panel2 = new Panel();
            lblCategoria = new Label();
            sectionCategoria = new ComboBox();
            txtBoxPosicion = new TextBox();
            txtBoxPartidosJugados = new TextBox();
            lblPartidosJugados = new Label();
            lblAltura = new Label();
            txtBoxAltura = new TextBox();
            lblPosicion = new Label();
            panel4.SuspendLayout();
            panelPadre2.SuspendLayout();
            panelPadre1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Controls.SetChildIndex(btnSiguiente, 0);
            panel4.Controls.SetChildIndex(lblError, 0);
            panel4.Controls.SetChildIndex(panel1, 0);
            panel4.Controls.SetChildIndex(panelPadre1, 0);
            panel4.Controls.SetChildIndex(panelPadre2, 0);
            panel4.Controls.SetChildIndex(panel2, 0);
            // 
            // btnSiguiente
            // 
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 129, 112);
            panel2.Controls.Add(lblCategoria);
            panel2.Controls.Add(sectionCategoria);
            panel2.Controls.Add(txtBoxPosicion);
            panel2.Controls.Add(txtBoxPartidosJugados);
            panel2.Controls.Add(lblPartidosJugados);
            panel2.Controls.Add(lblAltura);
            panel2.Controls.Add(txtBoxAltura);
            panel2.Controls.Add(lblPosicion);
            panel2.Location = new Point(472, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 201);
            panel2.TabIndex = 14;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(64, 155);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(85, 21);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria:";
            // 
            // sectionCategoria
            // 
            sectionCategoria.FormattingEnabled = true;
            sectionCategoria.Items.AddRange(new object[] { "Cadete", "Juvenil", "Senior" });
            sectionCategoria.Location = new Point(194, 153);
            sectionCategoria.Name = "sectionCategoria";
            sectionCategoria.Size = new Size(223, 23);
            sectionCategoria.TabIndex = 7;
            // 
            // txtBoxPosicion
            // 
            txtBoxPosicion.Location = new Point(194, 28);
            txtBoxPosicion.Name = "txtBoxPosicion";
            txtBoxPosicion.Size = new Size(223, 23);
            txtBoxPosicion.TabIndex = 6;
            // 
            // txtBoxPartidosJugados
            // 
            txtBoxPartidosJugados.Location = new Point(194, 112);
            txtBoxPartidosJugados.Name = "txtBoxPartidosJugados";
            txtBoxPartidosJugados.Size = new Size(223, 23);
            txtBoxPartidosJugados.TabIndex = 5;
            // 
            // lblPartidosJugados
            // 
            lblPartidosJugados.AutoSize = true;
            lblPartidosJugados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartidosJugados.Location = new Point(19, 114);
            lblPartidosJugados.Name = "lblPartidosJugados";
            lblPartidosJugados.Size = new Size(136, 21);
            lblPartidosJugados.TabIndex = 4;
            lblPartidosJugados.Text = "Partidos jugados:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAltura.Location = new Point(91, 73);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(58, 21);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura:";
            // 
            // txtBoxAltura
            // 
            txtBoxAltura.Location = new Point(194, 71);
            txtBoxAltura.Name = "txtBoxAltura";
            txtBoxAltura.Size = new Size(223, 23);
            txtBoxAltura.TabIndex = 2;
            // 
            // lblPosicion
            // 
            lblPosicion.AutoSize = true;
            lblPosicion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPosicion.Location = new Point(75, 30);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(74, 21);
            lblPosicion.TabIndex = 1;
            lblPosicion.Text = "Posicion:";
            // 
            // FRMAgregarVoley
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 453);
            Name = "FRMAgregarVoley";
            Text = "FRMAgregarVoley";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelPadre2.ResumeLayout(false);
            panelPadre2.PerformLayout();
            panelPadre1.ResumeLayout(false);
            panelPadre1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox txtBoxPosicion;
        private TextBox txtBoxPartidosJugados;
        private Label lblPartidosJugados;
        private Label lblAltura;
        private TextBox txtBoxAltura;
        private Label lblPosicion;
        private Label lblCategoria;
        private ComboBox sectionCategoria;
    }
}