using System;
using System.Collections;

namespace ClubTP
{

	public class Club
	{
    // Valores con Propiedades en minúscula.
		private string nombre;
		private ArrayList Deportes;
		private ArrayList DeportesCat;
		private ArrayList Entrenadores;
		private ArrayList Ninios;
		
		public Club(string nombre)
		{
			this.nombre = nombre;
			this.Deportes = new ArrayList();
			this.DeportesCat = new ArrayList();
			this.Entrenadores = new ArrayList();
			this.Ninios = new ArrayList();
		}

    // Método o Propiedad mal hechas.
		//public string definirNombreClub()
		//{
		//	Console.WriteLine("Ingrese el nombre del Club: ");
		//	this.Nombre = Console.ReadLine();
		//	return Nombre;
		//}
		
    // Propiedad
    // Empieza con Mayúscula el mismo nombre que el atributo.
    public string Nombre
    {
      get {return nombre;}
      set {nombre = value;}
    }

	}
}
