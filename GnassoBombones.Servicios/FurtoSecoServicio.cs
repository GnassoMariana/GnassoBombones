using GnassoBombones.Datos.Repositorios;
using GnassoBombones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoBombones.Servicios
{
    public class FrutoSecoServicio
    {
        private readonly FrutosSecosRepositorio? frutosSecosRepositorio;

        public FrutoSecoServicio(string ruta)
        {
            frutosSecosRepositorio = new FrutosSecosRepositorio(ruta);
        }

        public List<FrutoSeco> GetFrutos()
        {
            return frutosSecosRepositorio.GetFrutos();
        }
    }
}
