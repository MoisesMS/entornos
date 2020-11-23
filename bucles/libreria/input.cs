using System;

namespace bucles {

	internal class input {

		public static int entrada(String msg, String msgErr) {
			int n = 0;

			try {
				output.print(msg);
				n = int.Parse(Console.ReadLine());
			} catch(Exception e) {
				Console.Clear();

				output.println(msgErr);
				entrada(msg, msgErr);
			}

			return n;
		}
	}
}