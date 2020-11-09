using System;

namespace Tarea12{
    
    class Program {
    
        static void Main(string[] args) {
            // Programa que pida una fecha y compruebe si coincide con la fecha de navidad
            // Formato de fecha: dd/mm/aaaa o dd-mm-aaaa

            String fecha = pedirDato("Introduce una fecha");
            int datos = {};

            datos = fecha.Split("/");

            Console.WriteLine(datos);

            DateTime fecha = new DateTime()

            
        }





        static void pedirDato(string msg) {
            Console.Write(msg);
            retrun Console.ReadLine();
        }
    }
}