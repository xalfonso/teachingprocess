using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ProDocente.dominio;

namespace ProDocente.fichero
{
    class CFichero
    {

        public CFichero()
        {
             
        }


        static public String getDirImage(){
            return "..\\Imagenes\\";
        }

        static public String DirImg(String CI)
        {
            return getDirImage() + CI + ".jpg";
        }

       static public void escribirFicheroBinario(Object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("..\\Datos\\FicheroProDocente.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }

       static public Object leerFicheroBinario(Object obj)
        {
            IFormatter formatter1 = new BinaryFormatter();
            try
            {
                Stream stream1 = new FileStream("FicheroProDocente.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                obj = (CInstitucionN)formatter1.Deserialize(stream1);
                stream1.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se ha encontrado el fichero para cargar los datos");
            }
            
            
            return obj;
        }

    }
}
