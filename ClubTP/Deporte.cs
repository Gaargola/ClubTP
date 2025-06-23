
using System;

namespace ClubTP
{
	public class Deporte
	{
		private string nombreDeporte;
		
		public Deporte(){}

		public Deporte(string nombre)
		{
		    this.nombreDeporte = nombre;
		}

    // Propiedades 
		public string NombrarDeporte
		{
		  get {return nombreDeporte;}
          set {nombreDeporte = value;}
		}
		public void mostrarNombreDeporte()
		{
			Console.WriteLine(nombreDeporte);
		}

  //Esto rompe el encapsulamiento.
  //public string NombreDeporte()
  // {
	    //Console.WriteLine("Ingrese nombre del deporte: ");
      //this.Nombre = Console.ReadLine();
		  //return Nombre;
  //}


    // Métodos
    // no funciona (revisar)
	//	public void mostrarNombreDeporte()
	//	{
	//		Console.WriteLine("El nombre del deporte es: {0} ", Nombre);
	//	}
		//public string retornarNombre()
		//{
		//    return Nombre;
		//}
	}
}
// cambios nico