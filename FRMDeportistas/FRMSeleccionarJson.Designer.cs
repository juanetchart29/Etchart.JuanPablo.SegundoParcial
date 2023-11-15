namespace FRMDeportistas
{
    partial class FRMSeleccionarJson
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
            panel1 = new Panel();
            textBoxArchivo = new TextBox();
            lblSeleccionar = new Label();
            btnAbrir = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnUtilizar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 51, 71);
            panel1.Controls.Add(btnUtilizar);
            panel1.Controls.Add(textBoxArchivo);
            panel1.Controls.Add(lblSeleccionar);
            panel1.Controls.Add(btnAbrir);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 455);
            panel1.TabIndex = 0;
            // 
            // textBoxArchivo
            // 
            textBoxArchivo.Location = new Point(85, 190);
            textBoxArchivo.Name = "textBoxArchivo";
            textBoxArchivo.Size = new Size(460, 23);
            textBoxArchivo.TabIndex = 2;
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.AutoSize = true;
            lblSeleccionar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccionar.Location = new Point(388, 89);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(238, 32);
            lblSeleccionar.TabIndex = 1;
            lblSeleccionar.Text = "Seleccione el archivo";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(632, 190);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(243, 23);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUtilizar
            // 
            btnUtilizar.Location = new Point(632, 347);
            btnUtilizar.Name = "btnUtilizar";
            btnUtilizar.Size = new Size(243, 59);
            btnUtilizar.TabIndex = 3;
            btnUtilizar.Text = "Utilizar";
            btnUtilizar.UseVisualStyleBackColor = true;
            btnUtilizar.Click += btnUtilizar_Click;
            // 
            // FRMSeleccionarJson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 458);
            Controls.Add(panel1);
            Name = "FRMSeleccionarJson";
            Text = "FRMSeleccionarJson";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxArchivo;
        private Label lblSeleccionar;
        private Button btnAbrir;
        private Button btnUtilizar;
    }
}