using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoBombones.Entidades
{
    public class FrutoSeco
    {
        private string? nombre;
        private int? frutoId;

        public string? Nombre { get => nombre; set => nombre = value; }
        public int? FrutoId { get => frutoId; set => frutoId = value; }

        public FrutoSeco()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
