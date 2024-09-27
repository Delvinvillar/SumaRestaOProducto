using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularNivelPostulante
{
   public  class calcularNivel
    {
        public static void NivelPostulante()
        {
            double  pregunta = 0;
            double  respuesta = 0;
            double  porcentaje = 0;

            try
            {
                Console.WriteLine("ingrese el numero de pregunta ");
                pregunta = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el numero de respuesta correcta ");
                respuesta = double.Parse(Console.ReadLine());

                porcentaje = (respuesta / pregunta) * 100;
                Console.WriteLine($"el porcentaje es ");
                Console.WriteLine($" porcentaje : {porcentaje}%");
                if (porcentaje >= 90)
                {
                    Console.WriteLine("nivel maximo");

                }
                else if (porcentaje >= 75 && porcentaje <= 89)
                {
                    Console.WriteLine("nivel medio ");
                }
                else if (porcentaje >= 50 && porcentaje <= 74)
                {
                    Console.WriteLine("nivel regular");
                } else if (porcentaje < 50)
                {
                    Console.WriteLine(" esta fuera de rango");
                }
            }catch  (Exception ex)
            {


                Console.WriteLine($"hay un error {ex.Message}");

            }
           
        
        }
    }
}
