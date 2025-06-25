
using System;
using System.Collections;

namespace ClubTP
{

	public class Club
	{
    // Valores con Propiedades en minúscula.
		private string nombre;
		private ArrayList Deportes;
		private ArrayList Entrenadores;
		private ArrayList Ninios;
		


		public Club()
		{
		  this.Deportes = new ArrayList();
			this.Entrenadores = new ArrayList();
			this.Ninios = new ArrayList();
		}

		public Club(string nombre)
		{
			this.nombre = nombre;
			this.Deportes = new ArrayList();
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

    // agregue métodos de registro   
    public void registrarDeporte(Deporte deporte)
    {
    	Deportes.Add(deporte);
    }
    public void registrarNinio(Ninio ninio)
    {
    	Ninios.Add(ninio);
    }
    public void registrarEntrenador(Entrenador entrenador)
    {
    	Entrenadores.Add(entrenador);
    }
    
    public void eliminarEntrenador(int legajo)
    {
       bool eliminado = false;
       for (int i = 0; i<Entrenadores.Count; i++)
       {
       	Entrenador entrenador = (Entrenador) Entrenadores[i];
       	if (entrenador.Legajo == legajo)
       	{
       		Entrenadores.RemoveAt(i);
       	    eliminado = true;
       	    Console.WriteLine("Entrenador eliminado correctamente.");
       	    break;
       	}
       }
       if (!eliminado)
       {
       	Console.WriteLine("El entrenador seleccionado no se encuentra registrado en el club");
       }
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
    public void mostrarNinios()
    {
    	Console.WriteLine("Los ninios socios del club son: ");
    	for (int i = 0; i<Ninios.Count;i++)
    	{
    		Ninio aux = (Ninio)Ninios[i];
    		aux.MostrarDatos();
    	}
    }
   public Deporte buscarDeporte(string nombreDeporte)
   {
      for (int i = 0; i < Deportes.Count; i++)
      {
        Deporte dep = (Deporte)Deportes[i];
        if (dep.NombreDeporte.Equals(nombreDeporte, StringComparison.OrdinalIgnoreCase))
        {
            return dep;
        }
      }
      return null;
   }  

   public Ninio buscarNinio(int dni)
   {
      for (int i = 0; i < Ninios.Count; i++)
      {
        Ninio ninio = (Ninio)Ninios[i];
        if (ninio.Dni == dni)
        {
            return ninio;
        }
      }
    return null;
   }
   public void eliminarDeporte(string nombre)
   {
   	  Deporte deporte = buscarDeporte(nombre);
      if (deporte != null)
      {
         if (deporte.retornarInscriptos().Count > 0)
         {
            Console.WriteLine("No se puede eliminar el deporte, tiene inscriptos.");
         }
         else
         {
            Deportes.Remove(deporte);
            Console.WriteLine("Deporte eliminado correctamente.");
         }
      }
      else
      {
        Console.WriteLine("El deporte seleccionado no se encuentra registrado en el club.");
      }
   }


   public void eliminarNinio(int dni)
   {
     Ninio ninio = buscarNinio(dni);
     if (ninio == null)
     {
        Console.WriteLine("El ninio/a con el dni {0} no se encuentra registrado en el club", dni);
     }
     else
     {
        Ninios.Remove(ninio);
        Console.WriteLine("Ninio/a eliminado correctamente.");
     }
   }
 }
}
