using System;

namespace ejercicio1 {
    class Program {
        static void Main(string[] args) {
            string nIntroducidos = "";
            int n = -1;
            do {
                n = pedirNum("Ingresa números. Ingresa un 0 para terminar: ");
                
                if(n != 0) {
                    nIntroducidos += n + " ";
                }

            } while(n != 0);

            Console.WriteLine(nIntroducidos);

            Console.ReadKey();
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
