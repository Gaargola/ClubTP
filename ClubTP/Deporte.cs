using System;

namespace ClubTP
{
	public class Deporte
	{
		private string nombreDeporte;

		public Deporte(string nombre)
		{
		    this.nombreDeporte = nombre;
		}

    // Propiedad
		public string NombrarDeporte
		{
		  get {return NombreDeporte;}
      set {NombreDeporte = value;}
		}
  
    // Métodos de instancia
		public void mostrarNombreDeporte()
		{
			Console.WriteLine("El nombre del deporte es: {0} ", Nombre);
		}
	  public virtual void definirNombre()
    {
      // Definir nombre de deporte.
    }
  }
}
