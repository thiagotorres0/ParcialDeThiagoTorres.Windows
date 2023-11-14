using ArraySegundoParcial.Entidades;

namespace SegundoParcialTema2.Windows
{
    public partial class FrmPrincipalAE : Form
    {
        public FrmPrincipalAE()
        {
            InitializeComponent();
        }
        private Esfera esfera;

        List<TipoDeBorde> listaBordes = Enum.GetValues(typeof(TipoDeBorde))
              .Cast<TipoDeBorde>().ToList();

        public Esfera GetEsfera()
        {
            return esfera;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esfera == null)
                {
                    esfera = new Esfera();
                }
                esfera.medidaRadio = int.Parse(txtLado.Text);
                esfera.TipoDeRelleno = (TipoRelleno)cboColores.SelectedItem;
                esfera.TipoDeBorde = ObtenerTipoDeBorde();
                DialogResult = DialogResult.OK;
            }
        }

        private TipoDeBorde ObtenerTipoDeBorde()
        {
            TipoDeBorde tipo = 0;
            foreach (var itemBorde in listaBordes)
            {
                var key = $"rbt{itemBorde.ToString()}";
                var rb = (RadioButton)gbxBordes.Controls.Find(key, true)[0];
                if (rb.Checked)
                {
                    tipo = itemBorde;
                    break;
                }
            }
            return tipo;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLado.Text, out int lado))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Numero mal ingresado");
            }
            else if (lado <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Valor del lado no valido");
            }
            return valido;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
            CrearRadioButtonsBordes();
            if (esfera != null)
            {
                txtLado.Text = esfera.medidaRadio.ToString();
                cboColores.SelectedItem = esfera.TipoDeRelleno;
                SelectRadioButton(esfera.TipoDeBorde);
            }
        }

        private void SelectRadioButton(TipoDeBorde tipoDeBorde)
        {
            var key = $"rbt{tipoDeBorde.ToString()}";
            var rb = (RadioButton)gbxBordes.Controls.Find(key, true)[0];
            rb.Checked = true;
        }

        private void CrearRadioButtonsBordes()
        {
            int x = 6;
            int y = 22;
            bool check = true;
            foreach (var itemBorde in listaBordes)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rbt{itemBorde.ToString()}",
                    Text = itemBorde.ToString(),
                    Location = new Point(x, y),
                    Checked = check
                };
                gbxBordes.Controls.Add(rb);
                y += 20;
                check = false;
            }
        }

        private void CargarComboColores()
        {
            var listaColores = Enum.GetValues(typeof(TipoRelleno))
               .Cast<TipoRelleno>().ToList();
            cboColores.DataSource = listaColores;
            cboColores.SelectedIndex = 0;
        }

        public void SetEsfera(Esfera esfera)
        {
            this.esfera = esfera;

        }

        private void FrmPrincipalAE_Load(object sender, EventArgs e)
        {

        }
    }
}
