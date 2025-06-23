
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
		
		public Club()
		{
		    this.Deportes = new ArrayList();
			this.DeportesCat = new ArrayList();
			this.Entrenadores = new ArrayList();
			this.Ninios = new ArrayList();
		}
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
// agregue metodos de registro   
    public void registrarDeporte(Deporte deporte)
    {
    	Deportes.Add(deporte);
    }
    public void registrarDeporteCat(DeporteCategoria deporteCat)
    {
    	DeportesCat.Add(deporteCat);
    }
    public void registrarNinio(Ninio ninio)
    {
    	Ninios.Add(ninio);
    }
    public void registrarEntrenador(Entrenador entrenador)
    {
    	Entrenadores.Add(entrenador);
    }
    public void mostrarDeportes()
    {
    	Console.WriteLine("Los deportes practicados en el club son: ");
    	for(int i=0;i<Deportes.Count;i++)
    	{
    		Deporte aux = (Deporte)Deportes[i];
    		aux.mostrarNombreDeporte();
    	}
    }
    public void mostrarEntrenadores()
    {
    	Console.WriteLine("Los entrenadores del club son: ");
    	for(int i=0;i<Entrenadores.Count;i++)
    	{
            Entrenador aux = (Entrenador)Entrenadores[i];
            aux.MostrarDatos();
    	}
    }
    // falta metodo eliminar entrenador
  }
}
// cambios nico