using System;
using System.Collections;

namespace ClubTP
{
	class Program
	{
		public static void Main(string[] args)
		{
      // Acordate de dejar comentarios para saber que quisiste hacer.
		  Persona auxA = new Persona();
			auxA.mostrarNombre();
			auxA.definirNombre();
			auxA.mostrarNombre();
			
			Entrenador auxB = new Entrenador();
			auxB.definirNombre();
			auxB.definirDni();
			auxB.definirEdad();
			auxB.definirLegajo();
			auxB.mostrarNombre();
			auxB.mostrarDni();
			auxB.mostrarEdad();
			auxB.mostrarLegajo();
			
			DeporteCategoria auxC = new DeporteCategoria("2006",b,20,15,15000);
			auxC.mostrarNombreDeporte();
			auxC.nombrarDeporte();
			auxC.mostrarNombreDeporte();
			
			Console.Write("Presiona una tecla para finalizar . . . ");
			Console.ReadKey(true);
			
		}
	}
}
