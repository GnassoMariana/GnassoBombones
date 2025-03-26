
using GnassoBombones.Entidades;
using GnassoBombones.Servicios;

//var paisesServicio = new PaisServicio("Paises.txt");
//var frutosServicio = new FrutoSecoServicio("Frutos.txt");

//List<Pais> paises = paisesServicio.GetPaises();
//List<FrutoSeco> frutos = frutosServicio.GetFrutos();

Console.WriteLine("Seleccionar una opcion");
Console.WriteLine("1_ Mopstrar paises:");
Console.WriteLine("2_Mostrar frutos secos:");

string seleccion = Console.ReadLine();

switch (seleccion)
{
    case "1":
        var paisesServicio = new PaisServicio("Paises.txt");
        List<Pais> paises = paisesServicio.GetPaises();
        Console.WriteLine("PAises:");
        foreach (var pais in paises)
        {
            Console.WriteLine(pais.ToString());
        }
        break;
    case "2":
        var frutosServicio = new FrutoSecoServicio("Frutos.txt");

        List<FrutoSeco> frutos = frutosServicio.GetFrutos();
        Console.WriteLine("Frutos:");
        foreach (var fruto in frutos)
        {
            Console.WriteLine(fruto.ToString());
        }
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}
Console.ReadLine();
//foreach (Pais pais in paises)
//{
//    Console.WriteLine(pais.ToString());
