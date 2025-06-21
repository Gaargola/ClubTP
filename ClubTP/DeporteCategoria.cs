using System;
using System.Collections;
namespace ClubTP
{
	public class DeporteCategoria: Deporte
	{
		private string Categoria;
    private Entrenador Entrenador;
    private int Cupo;
    private int CantidadInscriptos;
    private ArrayList Dias;
    private ArrayList Horarios;
    private ArrayList NiniosInscriptos;
    private float PrecioCuota;


    // Te falto usar ' : base() ' si se quiere heredar algo.
    // No se puede usar un atributo private, tampoco llamarlo así.
		public DeporteCategoria(string categoria,Entrenador entrenador,int cupo,int cantidadinscriptos,float preciocuota)
		{
			// nombrarDeporte();
			this.Categoria = categoria;
			this.Entrenador = entrenador;
      this.Cupo = cupo;
      this.CantidadInscriptos = cantidadinscriptos;
      this.PrecioCuota = preciocuota;
      this.Dias = new ArrayList();
      this.Horarios = new ArrayList();
      this.NiniosInscriptos = new ArrayList();
		}

    // Propiedades mal hechas, falta corregir.
		public string definirCategoria()
		{
			Console.WriteLine("Ingrese el nombre de la categoría: ");
			this.Categoria = Console.ReadLine();
			return Categoria;
		}
		public Entrenador asignarEntrenador(Entrenador entrenador)
		{
			this.Entrenador = entrenador;
			return Entrenador;
		}
		public int definirCupo(int cupo)
		{
			Console.WriteLine("Ingrese la cantidad de cupos: ");
			this.Cupo = int.Parse(Console.ReadLine());
			return Cupo;
		}
		public int definirInscriptos()
		{
			Console.WriteLine("Ingrese la cantidad de inscriptos: ");
			this.CantidadInscriptos = int.Parse(Console.ReadLine());
		    return CantidadInscriptos;
		}
		public float definirPrecioCuota()
		{
			Console.WriteLine("Ingrese el precio de la cuota: ");
			this.PrecioCuota = float.Parse(Console.ReadLine());
		  return PrecioCuota;
		}
    // Métodos
		public bool hayCupo()
		{
			if(Cupo-CantidadInscriptos > 0)
			{
			   return true; 
			}
			else
			{
			   return false;
			}
		}
		public bool inscribirNinio(Ninio ninio)
		{
			if(hayCupo())
			{
				NiniosInscriptos.Add(ninio);
				Console.WriteLine("La inscripción fue realizada con éxito.");
				return true;
			}
			else
			{
				Console.WriteLine("No se pudo realizar la inscripción por falta de cupos.");
				return false;
			}
		}
	}
}
