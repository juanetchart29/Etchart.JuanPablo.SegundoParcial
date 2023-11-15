namespace FRMDeportistas
{
    partial class FRMIngresos
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
            lblIngreso = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 51, 71);
            panel1.Controls.Add(lblIngreso);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 455);
            panel1.TabIndex = 0;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreso.Location = new Point(350, 5);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(229, 32);
            lblIngreso.TabIndex = 1;
            lblIngreso.Text = "Usuarios Logeados";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(66, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(809, 379);
            listBox1.TabIndex = 0;
            // 
            // FRMIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 458);
            Controls.Add(panel1);
            Name = "FRMIngresos";
            Text = "FRMIngresos";
            Load += FRMIngresos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblIngreso;
        private ListBox listBox1;
    }
}