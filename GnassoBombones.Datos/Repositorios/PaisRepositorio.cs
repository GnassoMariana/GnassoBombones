using GnassoBombones.Entidades;

namespace GnassoBombones.Datos.Repositorios
{
    public class PaisRepositorio
    {
        private List<Pais> paises;
        private readonly string ruta = null!;


        public PaisRepositorio(string rutaArchivo)
        {
            paises = new List<Pais>();
            ruta = rutaArchivo;
            LeerDatos();
        }

        public List<Pais> GetPaises()
        {
            return paises;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        public void LeerDatos()
        {
            if (File.Exists(ruta))
            {
                var registros = File.ReadAllLines(ruta);
                foreach (var registro in registros)
                {
                    if (string.IsNullOrEmpty(registro)) continue;
                    Pais pais = ConstuirPais(registro);
                    paises.Add(pais);
                }
            }
            else
            {
                return;
            }
        }

        private Pais ConstuirPais(string registro)
        {
            var campos = registro.Split('|');
            var paisId = int.Parse(campos[0].Trim());
            var nombre = campos[1];
            return new Pais
            {
                Nombre = nombre,
                PaisId = paisId,
            };
        }
    }
}
