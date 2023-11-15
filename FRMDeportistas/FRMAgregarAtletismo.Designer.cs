namespace FRMDeportistas
{
    partial class FRMAgregarAtletismo
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
            txtBoxDisciplina = new TextBox();
            lblDisciplina = new Label();
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
            panel4.ImeMode = ImeMode.Alpha;
            panel4.Controls.SetChildIndex(btnSiguiente, 0);
            panel4.Controls.SetChildIndex(lblError, 0);
            panel4.Controls.SetChildIndex(panel1, 0);
            panel4.Controls.SetChildIndex(panelPadre1, 0);
            panel4.Controls.SetChildIndex(panelPadre2, 0);
            panel4.Controls.SetChildIndex(panel2, 0);
            // 
            // lblError
            // 
            lblError.Location = new Point(472, 245);
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
            panel2.Controls.Add(txtBoxDisciplina);
            panel2.Controls.Add(lblDisciplina);
            panel2.Location = new Point(472, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 106);
            panel2.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(86, 68);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(85, 21);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria:";
            // 
            // sectionCategoria
            // 
            sectionCategoria.FormattingEnabled = true;
            sectionCategoria.Items.AddRange(new object[] { "Cadete", "Juvenil", "Senior" });
            sectionCategoria.Location = new Point(194, 65);
            sectionCategoria.Name = "sectionCategoria";
            sectionCategoria.Size = new Size(223, 23);
            sectionCategoria.TabIndex = 9;
            // 
            // txtBoxDisciplina
            // 
            txtBoxDisciplina.Location = new Point(194, 17);
            txtBoxDisciplina.Name = "txtBoxDisciplina";
            txtBoxDisciplina.Size = new Size(223, 23);
            txtBoxDisciplina.TabIndex = 1;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisciplina.Location = new Point(88, 19);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(83, 21);
            lblDisciplina.TabIndex = 0;
            lblDisciplina.Text = "Disciplina:";
            // 
            // FRMAgregarAtletismo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 454);
            Name = "FRMAgregarAtletismo";
            Text = "FRMAgregarAtletismo";
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
        private TextBox txtBoxDisciplina;
        private Label lblDisciplina;
        private Label lblCategoria;
        private ComboBox sectionCategoria;
    }
}