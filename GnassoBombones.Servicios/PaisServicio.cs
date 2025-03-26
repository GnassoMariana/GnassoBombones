using GnassoBombones.Datos.Repositorios;
using GnassoBombones.Entidades;

namespace GnassoBombones.Servicios
{
    public class PaisServicio
    {
        private readonly PaisRepositorio paisRepositorio = null!;

        public PaisServicio(string ruta)
        {
            paisRepositorio = new PaisRepositorio(ruta);
        }

        public List<Pais> GetPaises()
        {
            return paisRepositorio.GetPaises();
        }
    }
}
