namespace FRMDeportistas
{
    partial class FRMVerClasificacion
    {

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
            components = new System.ComponentModel.Container();
            clasificacionBindingSource = new BindingSource(components);
            dataGrid = new DataGridView();
            btnVoley = new Button();
            btnAtletismo = new Button();
            btnEscalada = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            panelEditar = new Panel();
            btnOrdenar = new Button();
            lblOrden = new Label();
            lblOrdenar = new Label();
            btnSubirCategoria = new Button();
            btnBajarCategoria = new Button();
            comboBoxOrdenar = new ComboBox();
            comboBoxOrden = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)clasificacionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panelEditar.SuspendLayout();
            SuspendLayout();
            // 
            // clasificacionBindingSource
            // 
            clasificacionBindingSource.DataSource = typeof(Entidades.Clasificacion);
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(154, 36);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(778, 367);
            dataGrid.TabIndex = 0;
            // 
            // btnVoley
            // 
            btnVoley.Location = new Point(352, 8);
            btnVoley.Name = "btnVoley";
            btnVoley.Size = new Size(75, 23);
            btnVoley.TabIndex = 1;
            btnVoley.Text = "Voleibolista";
            btnVoley.UseVisualStyleBackColor = true;
            btnVoley.Click += btnVoley_Click;
            // 
            // btnAtletismo
            // 
            btnAtletismo.Location = new Point(255, 8);
            btnAtletismo.Name = "btnAtletismo";
            btnAtletismo.Size = new Size(91, 23);
            btnAtletismo.TabIndex = 2;
            btnAtletismo.Text = "Atletas";
            btnAtletismo.UseVisualStyleBackColor = true;
            btnAtletismo.Click += btnAtletismo_Click;
            // 
            // btnEscalada
            // 
            btnEscalada.Location = new Point(154, 8);
            btnEscalada.Name = "btnEscalada";
            btnEscalada.Size = new Size(95, 23);
            btnEscalada.TabIndex = 3;
            btnEscalada.Text = "Escaladores";
            btnEscalada.UseVisualStyleBackColor = true;
            btnEscalada.Click += btnEscalada_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(27, 331);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 33);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(27, 370);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 33);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // panelEditar
            // 
            panelEditar.Controls.Add(comboBoxOrden);
            panelEditar.Controls.Add(comboBoxOrdenar);
            panelEditar.Controls.Add(btnOrdenar);
            panelEditar.Controls.Add(lblOrden);
            panelEditar.Controls.Add(lblOrdenar);
            panelEditar.Controls.Add(btnEliminar);
            panelEditar.Controls.Add(btnModificar);
            panelEditar.Controls.Add(btnSubirCategoria);
            panelEditar.Controls.Add(btnBajarCategoria);
            panelEditar.Controls.Add(dataGrid);
            panelEditar.Location = new Point(0, 1);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(944, 417);
            panelEditar.TabIndex = 7;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(27, 106);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(97, 32);
            btnOrdenar.TabIndex = 15;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Location = new Point(3, 48);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(43, 15);
            lblOrden.TabIndex = 13;
            lblOrden.Text = "Orden:";
            // 
            // lblOrdenar
            // 
            lblOrdenar.AutoSize = true;
            lblOrdenar.Location = new Point(3, 8);
            lblOrdenar.Name = "lblOrdenar";
            lblOrdenar.Size = new Size(74, 15);
            lblOrdenar.TabIndex = 11;
            lblOrdenar.Text = "Ordenar por:";
            // 
            // btnSubirCategoria
            // 
            btnSubirCategoria.Location = new Point(3, 284);
            btnSubirCategoria.Name = "btnSubirCategoria";
            btnSubirCategoria.Size = new Size(151, 23);
            btnSubirCategoria.TabIndex = 9;
            btnSubirCategoria.Text = "Acender categoria";
            btnSubirCategoria.UseVisualStyleBackColor = true;
            btnSubirCategoria.Click += btnSubirCategoria_Click;
            // 
            // btnBajarCategoria
            // 
            btnBajarCategoria.Location = new Point(3, 255);
            btnBajarCategoria.Name = "btnBajarCategoria";
            btnBajarCategoria.Size = new Size(151, 23);
            btnBajarCategoria.TabIndex = 8;
            btnBajarCategoria.Text = "Decender Categoria";
            btnBajarCategoria.UseVisualStyleBackColor = true;
            btnBajarCategoria.Click += btnBajarCategoria_Click;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "Nombre", "Apellido", "Edad" });
            comboBoxOrdenar.Location = new Point(3, 22);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(121, 23);
            comboBoxOrdenar.TabIndex = 20;
            // 
            // comboBoxOrden
            // 
            comboBoxOrden.FormattingEnabled = true;
            comboBoxOrden.Items.AddRange(new object[] { "Ascendente", "Descendente" });
            comboBoxOrden.Location = new Point(3, 66);
            comboBoxOrden.Name = "comboBoxOrden";
            comboBoxOrden.Size = new Size(121, 23);
            comboBoxOrden.TabIndex = 21;
            // 
            // FRMVerClasificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 107, 135);
            ClientSize = new Size(944, 416);
            Controls.Add(btnEscalada);
            Controls.Add(btnAtletismo);
            Controls.Add(btnVoley);
            Controls.Add(panelEditar);
            Name = "FRMVerClasificacion";
            Text = "FRMVerClasificacion";
            ((System.ComponentModel.ISupportInitialize)clasificacionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public BindingSource clasificacionBindingSource;
        private System.ComponentModel.IContainer components;
        private DataGridView dataGrid;
        private Button btnVoley;
        private Button btnAtletismo;
        private Button btnEscalada;
        private Button btnEliminar;
        private Button btnModificar;
        private Panel panelEditar;
        private Button btnSubirCategoria;
        private Button btnBajarCategoria;
        private Label lblOrdenar;
        private Label lblOrden;
        private Button btnOrdenar;
        private ComboBox comboBoxOrden;
        private ComboBox comboBoxOrdenar;
    }
}