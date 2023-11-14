using ArraySegundoParcial.Entidades;
namespace ArraySegundoParcial.Datos
{
    public class RepositorioDeEsferas
    {
        private List<Esfera> listaEsferas;
        private readonly string _archivo = Environment.CurrentDirectory + "Esferas.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "Esferas.bak";

        public RepositorioDeEsferas()
        {
            listaEsferas = new List<Esfera>();
            LeerDatos();
        }

        private void LeerDatos()
        {
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Esfera cuadrado = ConstruirEsfera(lineaLeida);
                    listaEsferas.Add(cuadrado);
                }
                lector.Close();
            }
        }

        private Esfera ConstruirEsfera(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            var lado = int.Parse(campos[0]);
            TipoRelleno relleno = (TipoRelleno)int.Parse(campos[1]);
            TipoDeBorde borde = (TipoDeBorde)int.Parse(campos[2]);
            Esfera c = new Esfera(lado, relleno, borde);
            return c;
        }

        public bool Existe(Esfera esfera)
        {
           listaEsferas.Clear();
            LeerDatos();
            foreach (var itemEsfera in listaEsferas)
            {
                if (itemEsfera.medidaRadio == esfera.medidaRadio &&
                    itemEsfera.TipoDeRelleno == esfera.TipoDeRelleno &&
                    itemEsfera.TipoDeBorde == esfera.TipoDeBorde)
                {
                    return true;
                }
            }
            return false;
        }

        public void Agregar(Esfera esfera)
        {
            var escritor = new StreamWriter(_archivo, true);
            string lineaEscribir = ConstruirLinea(esfera);
            escritor.WriteLine(lineaEscribir);
            escritor.Close();
            listaEsferas.Add(esfera);
        }

        private string ConstruirLinea(Esfera esfera)
        {
            return $"{esfera.medidaRadio} | {esfera.TipoDeRelleno.GetHashCode()} |" +
                $" {esfera.TipoDeBorde.GetHashCode()}";
        }

        public object GetCantidad(int valorFiltro = 0)
        {
            if (valorFiltro > 0)
            {
                return listaEsferas.Count(c => c.medidaRadio >= valorFiltro);
            }
            return listaEsferas.Count;
        }

        public void Borrar(Esfera esferaBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Esfera esferaLeido = ConstruirEsfera(lineaLeida);
                        if (esferaBorrar.medidaRadio != esferaLeido.medidaRadio)
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaEsferas.Remove(esferaBorrar);
        }

        public void Editar(Esfera esferaEnArchivo,Esfera esferaEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Esfera esfera = ContruirEsfera(lineaLeida);
                        if (esferaEnArchivo.medidaRadio != esfera.medidaRadio)
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida = ConstruirLinea(esferaEditar);
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);

        }

        private Esfera ContruirEsfera(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            var Lado = int.Parse(campos[0]);
            TipoRelleno relleno = (TipoRelleno)int.Parse(campos[1]);
            TipoDeBorde borde = (TipoDeBorde)int.Parse(campos[2]);
            Esfera c = new Esfera(Lado, relleno, borde);
            return c;
        }

        public List<Esfera> Filtrar(int intValor)
        {
            return listaEsferas.Where(c => c.medidaRadio >= intValor).ToList();
        }

        public List<Esfera> GetLista()
        {
            return listaEsferas;
        }

        public List<Esfera> OrdenarAsc()
        {
            return listaEsferas.OrderBy(c => c.medidaRadio).ToList();
        }

        public List<Esfera> OrdenarDesc()
        {
            return listaEsferas.OrderByDescending(c => c.medidaRadio).ToList();

        }
    }
}