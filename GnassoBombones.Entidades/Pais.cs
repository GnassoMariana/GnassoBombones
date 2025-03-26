namespace GnassoBombones.Entidades
{
    public class Pais
    {
        public string Nombre { get; set; } = null!;
        public int PaisId { get; set; }

        public Pais()
        {


        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
