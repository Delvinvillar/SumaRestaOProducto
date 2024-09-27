using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedioAcalcular
{
    public  class Promedio
    {
        public static void Calcular()
        {
            double numero1 = 0;
          double  numero2= 0;
            double numero3= 0;
            double promedio = 0;
            try
            {

                Console.WriteLine("ingres la primera califificacion porfavor");
                numero1 = double.Parse(Console.ReadLine());


                Console.WriteLine("ingres la segunda califificacion porfavor");
                numero2 = double.Parse(Console.ReadLine());


                Console.WriteLine("ingres la tercera califificacion porfavor");
                numero3 = double.Parse(Console.ReadLine());

                promedio =( numero1 + numero2 + numero3) / 3;
                if (promedio >= 7)
                {
                    Console.WriteLine($" su promedio es de : {promedio} felicidades acaba de pasar el curso de c#");
                }
                else
                {
                    Console.WriteLine("tiene que volver a respetir el curso");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($" hay un error {ex.Message}");
                
            }
        
        }
    }
}
