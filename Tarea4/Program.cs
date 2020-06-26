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
            bool errores = false;

            if (!Lexicografia(Comando))
            {
                Console.WriteLine("La línea de comando posee un error lexicográfico!");
                errores = true;
            }


            if (!Sintactica(Comando))
            {
                Console.WriteLine("La línea de comando posee un error de sintaxis!");
                errores = true;
            }


            if (!Semantica(Comando))
            {
                Console.WriteLine("La línea de comando posee un error de semántica!");
                errores = true;
            }

            if (errores == false)
                Console.WriteLine("La linea de comando no posee ningun error!");

            Console.ReadKey();


        }

        public static bool Lexicografia(string Comando)
        {
            bool paso = false;

            string declaracion = " ";
            int contador = 0;

            while(Comando[contador] != ' ')
            {
                declaracion += Comando[contador];
                contador++;
            }

            if (PalabrasReservadas(declaracion) == true)
                paso = true;


            return paso;
        }



        public static bool Semantica(string Comando)
        {
            bool paso = true;

            int contador = 0;
            int espacios = 0;

            while (contador < Comando.Length)
            {
                if (Comando[contador] == ' ')
                    espacios++;

                if (espacios > 1)
                    paso = false;

                contador++;
            }

            string nombre = " ";

            nombre = string.Join(" ", Comando.Split(' ').Skip(1).Take(1).ToArray());
            nombre = nombre.Trim(';');
            if (PalabrasReservadas(nombre) == true)
                paso = false;

            return paso;
        }

        public static bool PalabrasReservadas(string declaracion)
        {
            bool paso = false;
            declaracion = declaracion.Trim();

            if (declaracion == "entero" ||
               declaracion == "flotante" ||
               declaracion == "letra" ||
               declaracion == "palabra" ||
               declaracion == "oracion" ||
               declaracion == "booleano")
                
                paso = true;

            return paso;
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
