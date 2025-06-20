using System;

namespace ClubTP
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Cambios hechos por Mauro");
			Persona a = new Persona();
			a.mostrarNombre();
			a.definirNombre();
			a.mostrarNombre();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
