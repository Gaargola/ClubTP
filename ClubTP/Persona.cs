using System;

namespace ClubTP
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string Nombre;
		private int Dni;
		private int Edad;
		
		public Persona(string Nombre, int Dni, int Edad)
		{
			this.Nombre = Nombre;
			this.Dni = Dni;
			this.Edad = Edad;
		}
		public definirNombre(){
			Console.WriteLine("Ingrese nombre de la persona: ");
		
		}
	}
}

