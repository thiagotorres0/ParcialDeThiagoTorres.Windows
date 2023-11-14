namespace SegundoParcialTema2.Windows
{
    partial class FrmPrincipal
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
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            ordenAscendenteToolStripMenuItem = new ToolStripMenuItem();
            ordenDescendenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel1 = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvDatos = new DataGridView();
            colRadio = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colRelleno = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbOrdenar, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 59);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.New;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(56, 56);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.Trash_Can;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(54, 56);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.Edit;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 56);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.Conversion;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(51, 56);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.Synchronize;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 56);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 59);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { ordenAscendenteToolStripMenuItem, ordenDescendenteToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.Sorting_Arrows;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(77, 56);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ordenAscendenteToolStripMenuItem
            // 
            ordenAscendenteToolStripMenuItem.Name = "ordenAscendenteToolStripMenuItem";
            ordenAscendenteToolStripMenuItem.Size = new Size(223, 26);
            ordenAscendenteToolStripMenuItem.Text = "Orden Ascendente";
            ordenAscendenteToolStripMenuItem.Click += ordenAscendenteToolStripMenuItem_Click;
            // 
            // ordenDescendenteToolStripMenuItem
            // 
            ordenDescendenteToolStripMenuItem.Name = "ordenDescendenteToolStripMenuItem";
            ordenDescendenteToolStripMenuItem.Size = new Size(223, 26);
            ordenDescendenteToolStripMenuItem.Text = "Orden Descendente";
            ordenDescendenteToolStripMenuItem.Click += ordenDescendenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 59);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.Exit_Sign;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(42, 56);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 467);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 133);
            panel1.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.Location = new Point(231, 60);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 64);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de registros:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 59);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 408);
            panel2.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colRadio, colBorde, colRelleno, colVolumen, colArea });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(914, 408);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // colRadio
            // 
            colRadio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRadio.HeaderText = "Radio";
            colRadio.MinimumWidth = 6;
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            colRadio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBorde
            // 
            colBorde.HeaderText = "Borde";
            colBorde.MinimumWidth = 6;
            colBorde.Name = "colBorde";
            colBorde.ReadOnly = true;
            colBorde.SortMode = DataGridViewColumnSortMode.NotSortable;
            colBorde.Width = 125;
            // 
            // colRelleno
            // 
            colRelleno.HeaderText = "Relleno";
            colRelleno.MinimumWidth = 6;
            colRelleno.Name = "colRelleno";
            colRelleno.ReadOnly = true;
            colRelleno.SortMode = DataGridViewColumnSortMode.NotSortable;
            colRelleno.Width = 125;
            // 
            // colVolumen
            // 
            colVolumen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVolumen.HeaderText = "Volumen";
            colVolumen.MinimumWidth = 6;
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            colVolumen.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colArea
            // 
            colArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colArea.HeaderText = "Area";
            colArea.MinimumWidth = 6;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDatos;
        private TextBox txtCantidad;
        private Label label1;
        private ToolStripMenuItem ordenAscendenteToolStripMenuItem;
        private ToolStripMenuItem ordenDescendenteToolStripMenuItem;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colRelleno;
        private DataGridViewTextBoxColumn colVolumen;
        private DataGridViewTextBoxColumn colArea;
    }
}