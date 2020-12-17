using System;

namespace ejercicio2 {
    class Program {
        static void Main(string[] args) {
            int n = -1, suma = 0;


            do {
                n = pedirNum("Ingresa números. Ingresa un 0 para terminar: ");

                if(n != 0) {
                    PintarAsteriscos(n);
                    suma += n;
                }

            } while(n != 0);

            if(suma == 0){
                Console.WriteLine("Solo has metido un cero");
            } else {
                Console.WriteLine("La suma total es: " + suma);
            }
            

            Console.ReadKey();
        }

        static void PintarAsteriscos(int n) {
            for(int j = 0; j < n; j++) {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        static int pedirNum(string msg) {
            try {
                Console.Write(msg);
                return int.Parse(Console.ReadLine());
            } catch(Exception e) {
                Console.WriteLine("No puedes meter algo que no sea un número. ");
                return pedirNum("Inténtalo otra vez: ");
            }
        }
    }
    
}
