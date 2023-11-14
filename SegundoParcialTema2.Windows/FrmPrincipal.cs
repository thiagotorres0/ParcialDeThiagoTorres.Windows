using ArraySegundoParcial.Entidades;
using ArraySegundoParcial.Datos;
namespace SegundoParcialTema2.Windows
{
    public partial class FrmPrincipal : Form
    {
        private RepositorioDeEsferas repo;
        private List<Esfera> lista;
        int intValor;
        bool filterOn = false;

        public FrmPrincipal()
        {
            InitializeComponent();
            repo = new RepositorioDeEsferas();
            ActualizarCantidadRegistros();

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmPrincipalAE frm = new FrmPrincipalAE() { Text = "Agregar esfera" };
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Esfera esfera = frm.GetEsfera();
            if (!repo.Existe(esfera))
            {
                repo.Agregar(esfera);
                txtCantidad.Text = repo.GetCantidad().ToString();
                DataGridViewRow r = ConstruirFila();
                Setearfila(r, esfera);
                AgregarFila(r);
                MessageBox.Show("Esfera agregada", "Mensaje", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esfera existente", "Mensaje", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void Setearfila(DataGridViewRow r, Esfera esfera)
        {
            r.Cells[colRadio.Index].Value = esfera.medidaRadio;
            r.Cells[colRelleno.Index].Value = esfera.TipoDeRelleno;
            r.Cells[colBorde.Index].Value = esfera.TipoDeBorde;
            r.Cells[colVolumen.Index].Value = esfera.Volumen();
            r.Cells[colArea.Index].Value = esfera.Area();

            r.Tag = esfera;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea borrar la esfera?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Esfera esfera = filaSeleccionada.Tag as Esfera;
            repo.Borrar(esfera);
            txtCantidad.Text = repo.GetCantidad().ToString();
            QuitarFila(filaSeleccionada);
            MessageBox.Show("Esfera borrada", "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void QuitarFila(DataGridViewRow filaSeleccionada)
        {
            dgvDatos.Rows.Remove(filaSeleccionada);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Esfera esfera = (Esfera)filaSeleccionada.Tag;
            Esfera esferaCopia = (Esfera)esfera.Clone();
            int ladoAnterior = esfera.medidaRadio;
            FrmPrincipalAE frm = new FrmPrincipalAE() { Text = "Editar esfera" };
            frm.SetEsfera(esfera);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            esfera = frm.GetEsfera();
            if (!repo.Existe(esfera))
            {
                repo.Editar(esferaCopia, esfera);
                Setearfila(filaSeleccionada, esfera);
                MessageBox.Show("Esfera editada", "Mensaje", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                Setearfila(filaSeleccionada, esfera);
                MessageBox.Show("Esfera Existente", "Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }

        }
        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            if (!filterOn)
            {
                var stringValor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del radio a filtrar",
                    "Filtrar por mayor o igual",
                    "0", 400, 400);
                if (!int.TryParse(stringValor, out intValor))
                {
                    return;
                }
                if (intValor <= 0)
                {
                    return;
                }
                lista = repo.Filtrar(intValor);
                tsbFiltrar.BackColor = Color.DarkRed;
                filterOn = true;
                MostrarDatosEnGrilla();
                ActualizarCantidadRegistros();
            }
            else
            {
                MessageBox.Show("Filtro aplicado! \nDebe actualizar la grilla",
                   "Advertencia",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void ActualizarCantidadRegistros()
        {
            if (intValor > 0)
            {
                txtCantidad.Text = repo.GetCantidad(intValor).ToString();
            }
            else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var esfera in lista)
            {
                DataGridViewRow r = ConstruirFila();
                Setearfila(r, esfera);
                AgregarFila(r);
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filterOn = false;
            intValor = 0;
            tsbFiltrar.BackColor = SystemColors.Control;
            lista = repo.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void ordenAscendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAsc();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void ordenDescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDesc();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
