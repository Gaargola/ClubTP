using System;

namespace ClubTP
{
	/// <summary>
	/// Description of Entrenador.
	/// </summary>
	public class Entrenador: Persona
	{
		private int Legajo;
		
		public Entrenador(){}
		public Entrenador(int legajo)
		{
			this.Legajo = legajo;
		}
		public int definirLegajo(){
			Console.WriteLine("Ingrese el Legajo del entrenador: ");
			this.Legajo = int.Parse(Console.ReadLine());
			return Legajo;
		}
		public int retornarLegajo()
		{
			return Legajo;
		}
		public void mostrarLegajo(){
			Console.WriteLine("El legajo del entrenador es "+Legajo);
    	}
	}
}
