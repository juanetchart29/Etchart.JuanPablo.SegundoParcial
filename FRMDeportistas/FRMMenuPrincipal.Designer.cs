namespace FRMDeportistas
{
    partial class FRMMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelWinHijo = new Panel();
            panel4 = new Panel();
            lblPanelWinHijo = new Label();
            panelSideBar = new Panel();
            lblHoraIngreso = new Label();
            lblNombreUsuario = new Label();
            btnVerIngresos = new Button();
            btnSeleccionarJson = new Button();
            btnVerClasificacion = new Button();
            btnAgregar = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panelSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(panelWinHijo);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panelSideBar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 554);
            panel1.TabIndex = 0;
            // 
            // panelWinHijo
            // 
            panelWinHijo.Location = new Point(200, 99);
            panelWinHijo.Name = "panelWinHijo";
            panelWinHijo.Size = new Size(960, 455);
            panelWinHijo.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 51, 71);
            panel4.Controls.Add(lblPanelWinHijo);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(200, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(952, 100);
            panel4.TabIndex = 0;
            // 
            // lblPanelWinHijo
            // 
            lblPanelWinHijo.AutoSize = true;
            lblPanelWinHijo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelWinHijo.ForeColor = Color.White;
            lblPanelWinHijo.Location = new Point(410, 39);
            lblPanelWinHijo.Name = "lblPanelWinHijo";
            lblPanelWinHijo.Size = new Size(0, 25);
            lblPanelWinHijo.TabIndex = 0;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(51, 51, 71);
            panelSideBar.Controls.Add(lblHoraIngreso);
            panelSideBar.Controls.Add(lblNombreUsuario);
            panelSideBar.Controls.Add(btnVerIngresos);
            panelSideBar.Controls.Add(btnSeleccionarJson);
            panelSideBar.Controls.Add(btnVerClasificacion);
            panelSideBar.Controls.Add(btnAgregar);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(200, 554);
            panelSideBar.TabIndex = 0;
            panelSideBar.Paint += panelSideBar_Paint;
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Location = new Point(12, 73);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(38, 15);
            lblHoraIngreso.TabIndex = 5;
            lblHoraIngreso.Text = "label1";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(3, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(83, 32);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "label1";
            // 
            // btnVerIngresos
            // 
            btnVerIngresos.FlatAppearance.BorderSize = 0;
            btnVerIngresos.FlatStyle = FlatStyle.Flat;
            btnVerIngresos.ForeColor = Color.White;
            btnVerIngresos.Location = new Point(0, 352);
            btnVerIngresos.Margin = new Padding(7, 3, 3, 3);
            btnVerIngresos.Name = "btnVerIngresos";
            btnVerIngresos.Size = new Size(197, 42);
            btnVerIngresos.TabIndex = 3;
            btnVerIngresos.Text = "VerIngresos";
            btnVerIngresos.UseVisualStyleBackColor = true;
            btnVerIngresos.Click += btnVerIngresos_Click;
            // 
            // btnSeleccionarJson
            // 
            btnSeleccionarJson.FlatAppearance.BorderSize = 0;
            btnSeleccionarJson.FlatStyle = FlatStyle.Flat;
            btnSeleccionarJson.ForeColor = Color.White;
            btnSeleccionarJson.Location = new Point(3, 435);
            btnSeleccionarJson.Margin = new Padding(7, 3, 3, 3);
            btnSeleccionarJson.Name = "btnSeleccionarJson";
            btnSeleccionarJson.Size = new Size(197, 42);
            btnSeleccionarJson.TabIndex = 2;
            btnSeleccionarJson.Text = "SeleccionarJson";
            btnSeleccionarJson.UseVisualStyleBackColor = true;
            btnSeleccionarJson.Click += btnSeleccionarJson_Click;
            // 
            // btnVerClasificacion
            // 
            btnVerClasificacion.FlatAppearance.BorderSize = 0;
            btnVerClasificacion.FlatStyle = FlatStyle.Flat;
            btnVerClasificacion.ForeColor = Color.White;
            btnVerClasificacion.Location = new Point(0, 262);
            btnVerClasificacion.Margin = new Padding(7, 3, 3, 3);
            btnVerClasificacion.Name = "btnVerClasificacion";
            btnVerClasificacion.Size = new Size(197, 42);
            btnVerClasificacion.TabIndex = 1;
            btnVerClasificacion.Text = "Ver Clasificacion";
            btnVerClasificacion.UseVisualStyleBackColor = true;
            btnVerClasificacion.Click += btnVerClasificacion_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(3, 154);
            btnAgregar.Margin = new Padding(7, 3, 3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(194, 45);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FRMMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 554);
            Controls.Add(panel1);
            Name = "FRMMenuPrincipal";
            Text = "Form1";
            FormClosing += FRMMenuPrincipal_FormClosing;
            Load += FRMMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelSideBar.ResumeLayout(false);
            panelSideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSideBar;
        private Panel panelWinHijo;
        private Panel panel4;
        private Button btnVerClasificacion;
        private Button btnAgregar;
        private Label lblPanelWinHijo;
        private Button btnSeleccionarJson;
        private Button btnVerIngresos;
        private Label lblHoraIngreso;
        private Label lblNombreUsuario;
    }
}