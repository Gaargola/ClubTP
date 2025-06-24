
using System;

namespace ClubTP
{
	public class Deporte
	{
		private string nombre;

		public Deporte(){}

		public Deporte(string nombre)
		{
		    this.nombreDeporte = nombre;
		}

    // Propiedad
		public string Nombre
		{
		  get {return nombre;}
      set {nombre = value;}
    }

    // Métodos de instancia
		public void mostrarNombreDeporte()
		{
			Console.WriteLine("El nombre del deporte es: {0} ", Nombre);
		}
    
    public int ObtenerDescuento()
    {
      if(nombre == "futbol" || nombre == "Futbol") {
          return 30;
      } else if (nombre == "tenis" || nombre == "Tenis") {
          return 25;
      } else if (nombre == "voley" || nombre == "Voley") {
         return 20;
      } else if (nombre == "basket" || nombre == "Basket") {
        return 15;
      }   else {
        return 10; // descuento por para los otros deportes.
      }
    }


	  public virtual void definirNombre()
    {
      // Definir nombre de deporte.
    }
  }
}
