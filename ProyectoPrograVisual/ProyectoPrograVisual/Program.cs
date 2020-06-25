using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CreandoSistema
{
    class Principal

    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Sus Nombres: ");

            string nombres = Convert.ToString(Console.ReadLine());

            //*************//

            Console.Write("Ingrese sus Apellidos: ");

            string apellidos = Convert.ToString(Console.ReadLine());

            //*************//

            Console.Write("Ingrese su Edad: ");
            double numEdad = Convert.ToDouble(Console.ReadLine());

            double resultado;

            resultado = numEdad;

            //*************//

            Console.WriteLine("Sus Nombres Completos son: " + nombres + apellidos);

            Console.WriteLine("su edad es " + resultado);

            Console.ReadLine();

        }


    }
}



