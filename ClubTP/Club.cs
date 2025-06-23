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

    // Propiedad
    // Empieza con Mayúscula el mismo nombre que el atributo.
    public string Nombre
    {
      get {return nombre;}
      set {nombre = value;}
    }

    // Métodos de instancia
    public string definirNombre()
    {
      // Definir nombre.
    }
    public void mostrarEntrenadores()
    {
      // Listado de entrenadores.
    }
    public void mostrarSocios()
    {
      // Listado de Socios.
    }
    public void mostrarDeportesCat()
    {
      // Listado de deportes por categoría.
    }

	}
}
