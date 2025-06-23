
using System;

namespace ClubTP
{
	public class Persona
	{
    // Minúscula las que tiene Propiedades, Para no tener error.
		private string nombre;
		private int dni;
		private int edad;
		

		public Persona(){}
		public Persona(string nombre, int dni, int edad)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.edad = edad;
		}
    
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
     // si no se agrega queda mejor Console.WriteLine("Datos de la Persona: ");
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

// cambios nico
