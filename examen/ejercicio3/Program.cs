using System;

namespace ejercicio3 {
    class Program {
        static void Main(string[] args) {
            int n;
            Boolean nPar;

            n = pedirNum("Ingresa un número: ");
            nPar = esPar(n);

            if(nPar) { mostrarNumPares(n); }
            else { mostrarNumImpares(n); }


        }




        static void mostrarNumImpares(int n) {
            for(int i = (n -= 2), j = 0; j < 10; i -= 2, j++ ) {
                Console.WriteLine(i);
            }
        }




        static void mostrarNumPares(int n) {
            for(int i = (n -= 2), j = 0; j < 10; i -= 2, j++) {
                Console.WriteLine(i);
            }
        }




        static Boolean esPar(int n) {
            return n % 2 == 0;
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
