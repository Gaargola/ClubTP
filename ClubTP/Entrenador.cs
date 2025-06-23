
using System;

namespace ClubTP
{
	public class Entrenador: Persona
	{
		private int legajo;
		
		public Entrenador(){}
		public Entrenador(string nombre, int dni, int edad, int legajo):base(nombre,dni,edad)
		{
			this.legajo = legajo;
		}
    
    // Propiedades
    public int Legajo
    {
      get {return legajo;}
      set {legajo = value;}
    }
       public int Legajo
       {
            get {return legajo;}
            set {legajo = value;}
       }
    // Métodos
		public int retornarLegajo()
		{
		    return Legajo;
		}
		public void mostrarLegajo(){
			Console.WriteLine("El legajo del entrenador es {0}",legajo);
    }
	}
		Console.WriteLine("El legajo del entrenador es {0}",Legajo);
  }
 }
}
