using System;

namespace ClubTP
{
  public class Ninio : Persona
	{
    private int ultimoPago;
    private Deporte deporteRealizado;
    private string categoria;
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
    public string Categoria
    {
      get{return categoria;}
      set{categoria = value;}
    }

    // Constructor
    public Ninio(string nombre, string dni, int edad, Deporte deporte, bool esSocio, int pago, string categoria)
      : base(nombre, dni, edad)
    {
        this.deporteRealizado = deporte;
        this.statusSocio = esSocio;
        this.ultimoPago = pago;
        this.categoria = categoria;
    }
    
    // Métodos de instancia.
    public bool Pagar(bool statusSocio)
    {
      if (statusSocio == true)
      {
        int descuento = deporteRealizado.ObtenerDescuento();
        Console.WriteLine("Es socio.");
        Console.WriteLine("Deporte: {0}", deporteRealizado.nombre);
        Console.WriteLine("Descuento aplicado: {0} %", descuento);
        return true;
      }
      else 
      {
        Console.WriteLine("No es socio");
        return false;
      }
    }
    
    public void ModificarDeporte(bool nuevoEstatus)
    {
      statusSocio = nuevoEstatus;
      if (statusSocio == true)
      {
        Console.WriteLine("Ahora está inscripto como socio.");
        int descuento = deporteRealizado.ObtenerDescuento();
        Console.WriteLine("Descuento correspondiente: {0} %", descuento);
      }
      else
      {
        Console.WriteLine("Ahora no es socio.");
      }
    }

    //public void definirCategiria(){}
    //public void modificarEstatus(){}

    // Ejemplo en el Main.
    //Deporte futbol = new Deporte("Futbol");
    //Ninio ninio1 = new Ninio("Lucas", "12345678", 10, futbol, true, 1500, "Infantil");
    //ninio1.Pagar();              // Verifica si es socio y aplica descuento.
    //ninio1.ModificarEstatus(false); // Cambia su estatus a no es socio.

	}
}
