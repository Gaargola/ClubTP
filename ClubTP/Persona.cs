using System;

namespace ClubTP
{
	public class Persona
	{
    // Minúscula las que tiene Propiedades, Para no tener error.
		private string nombre;
		private int dni;
		private int edad;
		

		public Persona(string nombre, int dni, int edad)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.edad = edad;
		}

		//public string definirNombre(){
		//	Console.WriteLine("Ingrese nombre de la persona: ");
		//	this.Nombre = Console.ReadLine();
		//	return Nombre;
		//}
		//public int definirDni(){
		//	Console.WriteLine("Ingrese DNI de la persona: ");
		//	this.Dni = int.Parse(Console.ReadLine());
		//	return Dni;
		//}
		//public int definirEdad(){
		//	Console.WriteLine("Ingrese edad de la persona: ");
		//	this.Edad = int.Parse(Console.ReadLine());
		//	return Edad;
		//}
    
    //Propiedades
    public string Nombre
    {
      get{return nombre;}
      set{nombre = value;}
    }
    public int Dni
    {
      get{return dni;}
      set{dni = value;}
    }
    public int Edad
    {
      get{return edad;}
      set{edad = value;}
    }

    // Métodos
    public void MostrarDatos()
    {
      Console.WriteLine("Datos de la Persona: ")
      Console.WriteLine("Nombre: {0} - DNI: {1} - Edad: {2} ", nombre, dni, edad);
    }
    
		//public void mostrarNombre(){
		//	Console.WriteLine("El nombre de la persona es: " +Nombre);
		//}
		//public void mostrarDni(){
		//	Console.WriteLine("El DNI de la persona es: " +Dni);
		//}
		//public void mostrarEdad(){
		//	Console.WriteLine("La edad de la persona es: " +Edad);
		//}
	}
}

