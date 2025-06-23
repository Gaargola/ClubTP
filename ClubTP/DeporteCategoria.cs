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
    private float precioCuota;

    // Te falto usar ' : base() ' si se quiere heredar algo.
		public DeporteCategoria(string categoria,Entrenador entrenador,int cupo,int cantidadinscriptos,float preciocuota)
		{
			this.Categoria = categoria;
			this.Entrenador = entrenador;
      this.Cupo = cupo;
      this.CantidadInscriptos = cantidadinscriptos;
      this.PrecioCuota = preciocuota;
      this.Dias = new ArrayList();
      this.Horarios = new ArrayList();
      this.NiniosInscriptos = new ArrayList();
		}
     // Métodos de instancia.
		public Entrenador asignarEntrenador(Entrenador entrenador)
	
    private string categoria;
    private Entrenador entrenador;
    private int cupo;
    private int cantidadInscriptos;
    private ArrayList dias;
    private ArrayList horarios;
    private ArrayList niniosInscriptos;
    private float precioCuota;


    // Te falto usar ' : base() ' si se quiere heredar algo.
    // No se puede usar un atributo private, tampoco llamarlo así.
    public DeporteCategoria(){}
    public DeporteCategoria(string nombreDeporte, string categoria,Entrenador entrenador,int cupo,int cantidadinscriptos,float preciocuota) : base(nombreDeporte)
		{
			// nombrarDeporte();
	  this.categoria = categoria;
	  this.entrenador = entrenador;
      this.cupo = cupo;
      this.cantidadInscriptos = cantidadinscriptos;
      this.precioCuota = preciocuota;
      this.dias = new ArrayList();
      this.horarios = new ArrayList();
      this.niniosInscriptos = new ArrayList();
		}

    // Propiedades corregidas.
	   
        public string Categoria
        {
            get{return categoria;}
            set{categoria = value;}
        }
		public Entrenador Entrenador
		{
			get{return entrenador;}
			set{entrenador = value;}
		}
		public int Cupo
		{
			get{return cupo;}
			set{cupo = value;}
		}
		public int CantidadInscriptos
		{
			get{return cantidadInscriptos;}
			set{cantidadInscriptos = value;}
		}
		public float PrecioCuota
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

		public bool hayCupo()
		{
			if(Cupo - CantidadInscriptos > 0)
			get{return precioCuota;}
			set{precioCuota = value;}
		}
    // Métodos
		public bool hayCupo()
		{
			if(cupo-cantidadInscriptos > 0)
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
				niniosInscriptos.Add(ninio);
				cantidadInscriptos++;
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
