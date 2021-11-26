using System;

namespace part2_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int zahl1, zahl2, quotient, modulo;
			
			Console.WriteLine("Geben Sie den Dividenden ein: ");
			zahl1 = Convert.ToInt32(Console.ReadLine());
				
			Console.WriteLine("Geben Sie den Divisor ein: ");
			zahl2 = Convert.ToInt32(Console.ReadLine());
			while (zahl2 == 0)
			{		
				Console.WriteLine("Durch 0 kann nicht geteilt werden, geben Sie einen gültigen Divisor ein: ");
				zahl2 = Convert.ToInt32(Console.ReadLine());
			}

			quotient = zahl1 / zahl2;
			modulo = zahl1 % zahl2;

			Console.WriteLine("Ergebnis: {0}", quotient);
			Console.WriteLine("Der Rest der Division ist: {0}", modulo);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
