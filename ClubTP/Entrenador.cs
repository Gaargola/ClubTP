﻿using System;

namespace ClubTP
{
	public class Entrenador: Persona
	{
		private int legajo;
		
		public Entrenador(){}
		public Entrenador(int legajo)
		{
			this.legajo = legajo;
		}

		//public int definirLegajo(){
		//	Console.WriteLine("Ingrese el Legajo del entrenador: ");
		//	this.Legajo = int.Parse(Console.ReadLine());
		//	return Legajo;
		//}
    
    // Propiedades
    public int Legajo
    {
      get {return legajo;}
      set {legajo = value;}
    }
    
    // Métodos
		public int retornarLegajo()
		{
			return Legajo;
		}
		public void mostrarLegajo(){
			Console.WriteLine("El legajo del entrenador es {0}",legajo);
    }
	}
}
