namespace FRMDeportistas
{
    partial class FRMAgregarEscalada
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            lblCategoria = new Label();
            sectionCategoria = new ComboBox();
            sectionModalidad = new ComboBox();
            lblModalidad = new Label();
            lblGrado = new Label();
            textBoxGrado = new TextBox();
            clasificacionBindingSource = new BindingSource(components);
            panel4.SuspendLayout();
            panelPadre2.SuspendLayout();
            panelPadre1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clasificacionBindingSource).BeginInit();
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
            // sectionCompetencia
            // 
            sectionCompetencia.Items.AddRange(new object[] { "Masculino", "Femenino" });
            sectionCompetencia.Location = new Point(194, 186);
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
            panel2.Controls.Add(sectionModalidad);
            panel2.Controls.Add(lblModalidad);
            panel2.Controls.Add(lblGrado);
            panel2.Controls.Add(textBoxGrado);
            panel2.Location = new Point(476, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 137);
            panel2.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(74, 97);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(85, 21);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // sectionCategoria
            // 
            sectionCategoria.FormattingEnabled = true;
            sectionCategoria.Items.AddRange(new object[] { "Promo B", "Promo A", "Mayores" });
            sectionCategoria.Location = new Point(188, 99);
            sectionCategoria.Name = "sectionCategoria";
            sectionCategoria.Size = new Size(223, 23);
            sectionCategoria.TabIndex = 4;
            // 
            // sectionModalidad
            // 
            sectionModalidad.FormattingEnabled = true;
            sectionModalidad.Items.AddRange(new object[] { "Boulder", "Velocidad", "Dificultad", "Psicoblock" });
            sectionModalidad.Location = new Point(188, 57);
            sectionModalidad.Name = "sectionModalidad";
            sectionModalidad.Size = new Size(223, 23);
            sectionModalidad.TabIndex = 3;
            // 
            // lblModalidad
            // 
            lblModalidad.AutoSize = true;
            lblModalidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblModalidad.Location = new Point(74, 59);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(93, 21);
            lblModalidad.TabIndex = 2;
            lblModalidad.Text = "Modalidad:";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrado.Location = new Point(46, 19);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(121, 21);
            lblGrado.TabIndex = 1;
            lblGrado.Text = "Grado maximo:";
            // 
            // textBoxGrado
            // 
            textBoxGrado.Location = new Point(188, 19);
            textBoxGrado.Name = "textBoxGrado";
            textBoxGrado.Size = new Size(223, 23);
            textBoxGrado.TabIndex = 0;
            // 
            // clasificacionBindingSource
            // 
            clasificacionBindingSource.DataSource = typeof(Entidades.Clasificacion);
            // 
            // FRMAgregarEscalada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 455);
            Name = "FRMAgregarEscalada";
            Text = "FRMAgregarEscalada";
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
            ((System.ComponentModel.ISupportInitialize)clasificacionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblGrado;
        private TextBox textBoxGrado;
        private Label lblModalidad;
        private ComboBox sectionModalidad;
        private Label label10;
        private ComboBox sectionCategoria;
        private Label lblCategoria;
        private BindingSource clasificacionBindingSource;
    }
}