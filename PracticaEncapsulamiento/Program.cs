using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de contacto
            Contacto contactoUno
                = new Contacto();

            contactoUno.nombre = "El Weon";
            contactoUno.direccion = "La esquina de la 300";
            contactoUno.correoElectronico = "fdjlfs@fkjkf.com";
            contactoUno.telefonoCasa = "4329878389";
            contactoUno.telefonoCelular = "5435343454";



            Console.WriteLine("Nombre: " +
                contactoUno.nombre);
            Console.WriteLine("Direccion: " +
                contactoUno.direccion);
            Console.WriteLine("Correo: " +
                contactoUno.correoElectronico);
            Console.WriteLine("Tel. Casa: " +
                contactoUno.telefonoCasa);
            Console.WriteLine("Tel. Celular: " +
                contactoUno.telefonoCelular);

            Console.ReadLine();
        }
    }
}
