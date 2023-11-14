namespace ArraySegundoParcial.Entidades
{
    public class Esfera: ICloneable
    {
        public int medidaRadio { get; set; }
        public int Radio { get; set; }
        public int Altura { get; set; }

        private TipoDeBorde tipoDeBorde;

        public TipoDeBorde TipoDeBorde
        {
            get { return tipoDeBorde; }
            set { tipoDeBorde = value; }
        }

        private TipoRelleno tipoDeRelleno;

        public TipoRelleno TipoDeRelleno
        {
            get { return tipoDeRelleno; }
            set { tipoDeRelleno = value; }
        }

        public Esfera()
        {

        }

        public Esfera(int medidaDelLado, TipoRelleno relleno, TipoDeBorde borde)
        {
            medidaRadio = medidaDelLado;
            TipoDeRelleno = relleno;
            tipoDeBorde = borde;
        }

        public double Volumen() => Math.Round(Math.PI * Math.Pow(Radio, 2) * Altura);
        public double Area() => Math.Round((2 * Math.PI * Radio * Altura) + (2 * Math.PI * Math.Pow(Radio, 2)));

        public bool Validar()
        {
            return medidaRadio > 0;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}