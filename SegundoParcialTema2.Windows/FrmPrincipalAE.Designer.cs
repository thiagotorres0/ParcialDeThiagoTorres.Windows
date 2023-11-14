namespace SegundoParcialTema2.Windows
{
    partial class FrmPrincipalAE
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
            errorProvider1 = new ErrorProvider(components);
            btnOk = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtLado = new TextBox();
            gbxBordes = new GroupBox();
            cboColores = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.Done;
            btnOk.Location = new Point(186, 485);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(130, 81);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Close;
            btnCancelar.Location = new Point(528, 485);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 81);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 77);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Medida del radio:";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(490, 73);
            txtLado.Margin = new Padding(3, 4, 3, 4);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(114, 27);
            txtLado.TabIndex = 3;
            // 
            // gbxBordes
            // 
            gbxBordes.Location = new Point(214, 293);
            gbxBordes.Margin = new Padding(3, 4, 3, 4);
            gbxBordes.Name = "gbxBordes";
            gbxBordes.Padding = new Padding(3, 4, 3, 4);
            gbxBordes.Size = new Size(415, 133);
            gbxBordes.TabIndex = 5;
            gbxBordes.TabStop = false;
            gbxBordes.Text = "Tipo de bordes";
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(490, 181);
            cboColores.Margin = new Padding(3, 4, 3, 4);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(138, 28);
            cboColores.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 185);
            label3.Name = "label3";
            label3.Size = new Size(212, 20);
            label3.TabIndex = 7;
            label3.Text = "Seleccione el color del relleno:";
            // 
            // FrmPrincipalAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(cboColores);
            Controls.Add(gbxBordes);
            Controls.Add(txtLado);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipalAE";
            Text = "FrmPrincipalAE";
            Load += FrmPrincipalAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOk;
        private Label label3;
        private ComboBox cboColores;
        private GroupBox gbxBordes;
        private TextBox txtLado;
        private Label label1;
    }
}