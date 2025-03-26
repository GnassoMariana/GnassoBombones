using GnassoBombones.Entidades;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoBombones.Datos.Repositorios
{
    public class FrutosSecosRepositorio
    {
        private List<FrutoSeco>? frutosSecos;
        private readonly string? ruta;

        public List<FrutoSeco>? FrutosSecos { get => frutosSecos; set => frutosSecos = value; }

        public string? Ruta => ruta;

        public FrutosSecosRepositorio(string rutaArhivo)
        {
            frutosSecos = new List<FrutoSeco>();
            ruta = rutaArhivo;
            LeerDatos();
        }

        private void LeerDatos()
        {
            if(File.Exists(ruta))
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    string? registro;
                    while((registro = reader.ReadLine())!= null) 
                    {
                        FrutoSeco fruto = ConstruirFruto(registro);
                        if(fruto != null)
                        {
                            frutosSecos?.Add(fruto);
                        }
                    }
                }
            }
        }

        private FrutoSeco ConstruirFruto(string registro)
        {
            var campos = registro.Split('|');
            var frutoId = int.Parse(campos[0]);
            var nombre = campos[1];
            return new FrutoSeco
            {
                Nombre = nombre,
                FrutoId = frutoId,
            };

        }
        
        public List<FrutoSeco> GetFrutos()
        {
            return frutosSecos;
        }
}
}
