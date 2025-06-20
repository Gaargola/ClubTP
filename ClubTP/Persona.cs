using System;

namespace ClubTP
{
	public class Persona
	{
		private string Nombre;
		private int Dni;
		private int Edad;
		
		public Persona(){}
		public Persona(string nombre, int dni, int edad)
		{
			this.Nombre = nombre;
			this.Dni = dni;
			this.Edad = edad;
		}
		public string definirNombre(){
			Console.WriteLine("Ingrese nombre de la persona: ");
			this.Nombre = Console.ReadLine();
			return Nombre;
		}
		public int definirDni(){
			Console.WriteLine("Ingrese DNI de la persona: ");
			this.Dni = int.Parse(Console.ReadLine());
			return Dni;
		}
		public int definirEdad(){
			Console.WriteLine("Ingrese edad de la persona: ");
			this.Edad = int.Parse(Console.ReadLine());
			return Edad;
		}
		public void mostrarNombre(){
			Console.WriteLine("El nombre de la persona es: " +Nombre);
		}
		public void mostrarDni(){
			Console.WriteLine("El DNI de la persona es: " +Dni);
		}
		public void mostrarEdad(){
			Console.WriteLine("La edad de la persona es: " +Edad);
		}
	}
}

