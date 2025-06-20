using System;
using System.Collections;
namespace ClubTP
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Entrenador b = new Entrenador();
			b.definirNombre();
			b.definirDni();
			b.definirEdad();
			b.definirLegajo();
			b.mostrarNombre();
			b.mostrarDni();
			b.mostrarEdad();
			b.mostrarLegajo();
			
			DeporteCategoria a = new DeporteCategoria("2006",b,20,15,15000);
			a.mostrarNombreDeporte();
			a.nombrarDeporte();
			a.mostrarNombreDeporte();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}
