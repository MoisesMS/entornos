using System;

namespace bucles {

	internal class bucles {

		private static void Main(string[] args) {
			int n = 0;

			for(int i = 0; i < 10; i++) {
				n += int.Parse(Console.ReadLine());
            }

			Console.WriteLine(n / 10);

			Console.ReadKey();
		}
	}
}