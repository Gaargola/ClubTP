
using System;

namespace ClubTP
{
	public class Persona
	{

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

    // Método de instancia.
    public void MostrarDatos()
    {
      Console.WriteLine("Datos de la Persona: ")
      Console.WriteLine("Nombre: {0} - DNI: {1} - Edad: {2} ", nombre, dni, edad);
    }
    // Métodos
    public void MostrarDatos()
    {
      Console.WriteLine("Nombre: {0} - DNI: {1} - Edad: {2} ", nombre, dni, edad);
    }
	}
}
