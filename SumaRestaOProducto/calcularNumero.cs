using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaRestaOProducto
{
    public class calcularNumero
    {
      public  static void CalcularN()
        {
            double numero1 = 0;
            double numero2 = 0;
            double suma = 0;
            double producto = 0;
            double conciente = 0;

            try
            {
                Console.WriteLine("ingrese el primer numero porfavor");
                numero1= double.Parse(Console.ReadLine());

                Console.WriteLine("ingrese elsegundo numero porfavor");
                numero2 = double.Parse(Console.ReadLine());
                if (numero1 > numero2)
                {
                    suma = numero1 + numero2;

                }
                else
                {
                    producto = numero1 * numero2;
                    conciente = numero1 / numero2;
                }
                if (numero2 < numero1)
                {
                    Console.WriteLine($"esta es la suma de los 2 numero ingresado: {suma}");
                }
                else
                {
                Console.WriteLine($"este es su producto : {producto} y este su cociente : {conciente}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($" no se acepta lestra {ex.Message}");
            }
        }
    }
}
