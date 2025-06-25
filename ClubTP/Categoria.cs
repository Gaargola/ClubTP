
using System;
using System.Collections;
namespace ClubTP
{
	public class Categoria
	{
	private string nombreCat;
    private Entrenador entrenador;
    private int cupo;
    private int cantidadInscriptos;
    private ArrayList dias;
    private ArrayList horarios;
  //  private ArrayList niniosInscriptos;
    private float precioCuota;
    private byte descuentoPorCategoria;


    public Categoria()
    {
    	this.dias = new ArrayList();
        this.horarios = new ArrayList();
    }
    public Categoria(string nombrecat,Entrenador entrenador,int cupo,int cantidadinscriptos,float preciocuota,byte descuentoporcategoria)
		{
	      this.nombreCat = nombrecat;
	      this.entrenador = entrenador;
          this.cupo = cupo;
          this.cantidadInscriptos = cantidadinscriptos;
          this.precioCuota = preciocuota;
          this.descuentoPorCategoria = descuentoporcategoria;
          this.dias = new ArrayList();
          this.horarios = new ArrayList();
        //  this.niniosInscriptos = new ArrayList();
		}

    // Propiedades corregidas.
	   
        public string NombreCat
        {
            get{return nombreCat;}
            set{nombreCat = value;}
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
			get{return precioCuota;}
			set{precioCuota = value;}
		}
		public byte DescuentoPorCategoria
		{
			get{return descuentoPorCategoria;}
			set{descuentoPorCategoria = value;}
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
       public void AgregarDia(string dia)
       {
           bool existe = false;
           for (int i = 0; i < dias.Count; i++)
           {
               if ((string)dias[i] == dia)
               {
                  existe = true;
                  break;
               }
           }

           if (!existe)
           {
              dias.Add(dia);
              Console.WriteLine("Día agregado correctamente.");
           }
           else
           {
              Console.WriteLine("El día ya está cargado.");
           }
       }

       public void AgregarHorario(string horario)
       {
           bool existe = false;
           for (int i = 0; i < horarios.Count; i++)
           { 
               if ((string)horarios[i] == horario)
               {
                  existe = true;
                  break;
               }
           }

           if (!existe)
           {
              horarios.Add(horario);
              Console.WriteLine("Horario agregado correctamente.");
           }
           else
           {
               Console.WriteLine("El horario ya está cargado.");
           }
       }
       //sacar horario y dia
	}
}
// cambios nico