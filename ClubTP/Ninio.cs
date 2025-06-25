using System;
using System.Collections;

namespace ClubTP
{
  public class Ninio : Persona
	{
  	private int ultimoPago;
    private Deporte deporteRealizado;
    private string nomcategoria;
    private bool statusSocio;

    // Propiedades
    public Deporte DeporteRealizado
    {
      get{return deporteRealizado;}
      set{deporteRealizado = value;}
    }
    public bool StatusSocio
    {
      get{return statusSocio;}
      set{statusSocio = value;}
    }
    public int UltimoPago
    {
      get{return ultimoPago;}
      set{ultimoPago = value;}
    }
    public string NomCategoria
    {
      get{return nomcategoria;}
      set{nomcategoria = value;}
    }

    // Constructor
    public Ninio(){}
    public Ninio(string nombre, int dni, int edad, Deporte deporte, bool esSocio, int ultpago, string nomcategoria):base(nombre, dni, edad)
    {
        this.deporteRealizado = deporte;
        this.statusSocio = esSocio;
        this.ultimoPago = ultpago;
        this.nomcategoria = nomcategoria;
    }
    
    // Métodos de instancia.
    public float calcularDescuento()
    {
    	float descuentoxCat = 0;
    	float descuentoxDep = (float)DeporteRealizado.DescuentoPorDeporte;
    	string cat = nomcategoria;
    	ArrayList categos = DeporteRealizado.retornarCategorias();
      //	bool haydesc = false;
    	for (int i = 0; i<categos.Count;i++)
    	{
    		Categoria auxcat = (Categoria) categos[i];
    		if (auxcat.NombreCat == cat)
    		{
    			descuentoxCat = (float)auxcat.DescuentoPorCategoria;
    	//haydesc = true;
    			break;
    		}
    	}
    	//if (!haydesc){throw}
    	float descuentoTotal = descuentoxDep + descuentoxCat;
    	if (descuentoTotal > 100)
    	{
    		descuentoTotal = 100;
    	}
    	return descuentoTotal;
    }
    public bool Pagar()
    {
      if (deporteRealizado == null)
      {
        Console.WriteLine("Error: el niño no tiene asignado un deporte.");
        return false;
      }
      float descuentoTotal = calcularDescuento();
      float preciocuota = 0;
      ArrayList categos = deporteRealizado.retornarCategorias();
      bool categoriaEncontrada = false;
      for(int i = 0; i<categos.Count;i++)
      {
      	Categoria auxcat = (Categoria) categos[i];
      	if (auxcat.NombreCat == nomcategoria)
      	{
      		preciocuota = auxcat.PrecioCuota;
      		categoriaEncontrada = true;
      		break;
      	}
      }
      if (!categoriaEncontrada)
      {
      	//throw exception no existe esa categoria
      }
      float montoFinal = preciocuota * (1-(descuentoTotal/100));
      Console.WriteLine("Pagando cuota para: " + Nombre);
      Console.WriteLine("Deporte: " + deporteRealizado.NombreDeporte);
      Console.WriteLine("Categoría: " + nomcategoria);
      if (statusSocio){Console.WriteLine("Estado: asociado");}
      else{Console.WriteLine("Estado: desasociado");}
      Console.WriteLine("Descuento aplicado: " + descuentoTotal + "%");
      Console.WriteLine("Monto a pagar: " + montoFinal);
      ultimoPago = DateTime.Now.Month;
      Console.WriteLine("Pago registrado con éxito para el mes: " + ultimoPago);
      return true;
    }
 }
}
