using System;
using CursoCs = PracticaOtrosTrucos.Cursos.Curso;
using Categoria = PracticaOtrosTrucos.Cursos.Categoria;
using static System.Math;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

namespace PracticaOtrosTrucos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region using directiva
            //Ej 1
            var curso = new CursoCs
            {
                Titulo = "C# Trucos",
                Categoria = Categoria.Backend,
            };

            //Ej 2
            var potencia = Pow(2, 3);
            var raiz = Sqrt(5);
            #endregion
            #region using sentencia
            var ruta = @"C:\Users\noemi\source\repos\PracticaOtrosTrucos\test.txt";
            ImprimirDeArchivo(ruta);

            //Ej 2
            string texto =
                @"C#
CSS
JS";
            string textoB = 
            @".NET
Bootstrap
Vue.js";
            ImprimirEnConsola(texto, textoB);
            #endregion
            #region nameof
            //Expresion nameof Ej 1 - 3
            Usuario usuario = null;
            ImprimirDeArchivo(ruta, usuario);

            //2-2
            Usuario usuarioB = new Usuario();
            //usuarioB.Id = 1;
            //usuarioB.Nombre = null;
            #endregion

            #region auto-property initializer
            Usuario usuarioC = new Usuario();
            Console.WriteLine($"Id de usuario: {usuarioC.Id}");
            //Ej 2
            //usuarioC.Id = Guid.NewGuid();
            //Console.WriteLine($"Id de usuario: {usuarioC.Id}");
            #endregion

        }

        //Using sentencia Ej 1
        static void ImprimirDeArchivo(string archivo)
        {
            if(archivo == null)
            {
                Log($"No se proporciono el nombre del archivo {nameof(archivo)}");
                return;
            }
               
            //Ej 1
            using (System.IO.StreamReader lector = System.IO.File.OpenText(archivo))
            {

                System.Console.WriteLine(lector.ReadToEnd());
            }
            
            
        }
        //Using sentencia Ej 2
        static void ImprimirEnConsola(string columna, string columnaB)
        {
            using StringReader sr = new StringReader(columna),
                srB = new StringReader(columnaB);
            string imp;
            
            do
            {
                imp = sr.ReadLine();
                Console.Write(imp);
                Console.Write("    ");
                imp = srB.ReadLine();
                Console.WriteLine(imp);
            } while (imp != null);
        }

        //Expresion nameof Ej 1 - 2
        public static void Log(string msg)
        {
            #region previous
            Console.WriteLine($">>Log: {msg}");
            Console.WriteLine($"TS: {DateTime.Now}");
            //Ej 1
            Console.WriteLine("----- Programa -----");
            Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);
            Console.WriteLine("Directorio actual: {0}", Environment.CurrentDirectory);
            
            #endregion
        }

        //Expresion nameof Ej 1 - 1 
        static void ImprimirDeArchivo(string archivo, Usuario usuarioEnSesion)
        {
            if (usuarioEnSesion == null)
            {
                Log($"Parametro invalido: {nameof(usuarioEnSesion)}");
                return;
            }
            else
            {

                //Validar usuario y continuar..
                using (StreamReader lector = File.OpenText(archivo))
                {

                    Console.WriteLine(lector.ReadToEnd());
                }
            }


        }
    }
}
