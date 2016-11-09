using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ej03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StreamReader mArchivo = null;
            string mContenido = "";
            string ruta = args[0];
            try
            {
                mArchivo = new StreamReader(ruta, Encoding.UTF8);
                mContenido = mArchivo.ReadToEnd();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: la ruta del archivo es nula");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: no se encontró el archivo");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: no se encontró el directorio");
            }
            catch (IOException)
            {
                Console.WriteLine("Error de entrada/salida");
            }
            finally
            {
                if (mArchivo != null )
                {
                    mArchivo.Close();
                }
            }
            Console.WriteLine(mContenido);
            Console.ReadKey();
        }
    }
}
