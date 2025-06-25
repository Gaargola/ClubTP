
using System;
using System.Collections;

namespace ClubTP
{
	public class Deporte
	{
		private string nombreDeporte;
		private byte descuentoPorDeporte;
		private ArrayList Categorias;
		private ArrayList Inscriptos;
		
		public Deporte()
		{
			this.Categorias = new ArrayList();
			this.Inscriptos = new ArrayList();
		}

		public Deporte(string nombre, byte descuentopordeporte)
		{
			this.Categorias = new ArrayList();
			this.Inscriptos = new ArrayList();
			this.nombreDeporte = nombre;
			this.descuentoPorDeporte = descuentopordeporte;
		}

    // Propiedades 
		public string NombreDeporte
		{
		  get {return nombreDeporte;}
          set {nombreDeporte = value;}
		}
		public byte DescuentoPorDeporte
		{
		  get{return descuentoPorDeporte;}
	      set{descuentoPorDeporte = value;}
		}
	  
    // Métodos
	  public ArrayList retornarCategorias()
	  {
		  return Categorias;
    }
		public void mostrarNombreDeporte()
		{
			Console.WriteLine("El nombre del deporte es: {0} ", Nombre);
		}
		public void agregarCategoria(Categoria cat)
		{
			Categorias.Add(cat);
		}
		public void eliminarCategoria(string nombreCat)
		{
			bool eliminada = false;
		    for (int i = 0; i < Categorias.Count; i++)
            {
              Categoria cat = (Categoria)Categorias[i];
              if (cat.NombreCat == nombreCat)
              {
                Categorias.RemoveAt(i);
                Console.WriteLine("Categoria eliminada correctamente");
                eliminada = true;
                break;
              }
            }
		    if(!eliminada){Console.WriteLine("No se encontro la categoria para este deporte");}
		}
		public void inscribirNinio(Ninio ninio)
		{
			string cat = ninio.NomCategoria;
			bool existe = false;
			for(int i = 0; i<Categorias.Count;i++)
			{
				Categoria ncat = (Categoria)Categorias[i];
				if (ncat.NombreCat == cat)
				{
					existe = true;
					if(ncat.hayCupo())
			        {
				        Inscriptos.Add(ninio);
				        ncat.CantidadInscriptos++;
				        Console.WriteLine("La inscripción fue realizada con éxito.");
		        	}
			        else
			        {
				        Console.WriteLine("No se pudo realizar la inscripción por falta de cupos.");
			        }
			    }   
			}
			if (!existe)
			{
				Console.WriteLine("La categoria no existe para este deporte.");
			}
		}
		public void desinscribirNinio(Ninio ninio)
		{
		   bool eliminado = false;
           for (int i = 0; i<Inscriptos.Count; i++)
            {
         	  Ninio nin = (Ninio) Inscriptos[i];
              if (nin == ninio)
        	   {
       	 	       Inscriptos.RemoveAt(i);
       	 	       for (int s = 0; s<Inscriptos.Count; s++)
       	 	       {
       	 	         	Categoria cat = (Categoria)Categorias[s];
       	 	         	if (cat.NombreCat == ninio.NomCategoria)
       	 	         	{
       	 	         		cat.CantidadInscriptos--;
       	 	         	}
       	 	       }
       	           eliminado = true;
       	           Console.WriteLine("Ninio/a eliminado correctamente.");
       	           break;
        	   }
        	  }
           if (!eliminado)
            {
       	     Console.WriteLine("El ninio/a con el dni {0} no se encuentra registrado en este deporte", ninio.Dni);
            }
		}
		public ArrayList retornarInscriptos()
		{
			return Inscriptos;
		}
	}
}
