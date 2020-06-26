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

            if(!Lexicografia(Comando))
                Console.WriteLine("La línea de comando posee un error lexicográfico!");
            
            //if (!Sintactica(Comando))
            //    Console.WriteLine("La línea de comando posee un error de sintaxis!");

            Console.ReadKey();




            //string datos = "hola esto es un ejemplo para extraer";
            //string[] datoscortados = data.Split(' ');
            //MessageBox.Show(datoscortados[1]);

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
