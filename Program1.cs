using System;

namespace part2_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double zahl1, zahl2, produkt, quotient;
			
			Console.WriteLine("Geben Sie die erste Zahl ein:");
			zahl1 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Geben Sie die zweite Zahl ein:");
			zahl2 = Convert.ToInt32(Console.ReadLine());
			
			produkt = zahl1* zahl2;
			quotient = zahl1 / zahl2;
			
			Console.WriteLine("Ihr Produkt ist: {0}", produkt);
			Console.WriteLine("Ihr Quotient ist: {0}", quotient);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}