using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la linea que desea interpretar: ");
            string Comando = Console.ReadLine();

            if (!Sintactica(Comando))
                Console.WriteLine("La línea de comando posee un error de sintaxis.");




            Console.ReadKey();
        }

        public static bool Sintactica(string Comando)
        {
            bool paso = false;
            string Ultimo = Comando.Substring(Comando.Length - 1, 1);

            if (Ultimo == ";")
                paso = true;

            return paso;
        }
    }
}
