using System.Security.Cryptography.X509Certificates;

namespace litrosdeleche
{

    public static void Main()
    {

        double LV, PG, CG, VV;
        double LPG = 3.785; 

        Console.WriteLine("Dijite los litros de la venta");
        LV = double.Parse(Console.ReadLine());
        Console.WriteLine("Dijite el precio del galon");
        PG = double.Parse(Console.ReadLine());
        CG = LV / LPG;
        VV = CG * PG;
        Console.WriteLine($"El valor de venta es {VV}");
        Console.WriteLine($"La cantidad de galones es {CG}");

    }
        
}
