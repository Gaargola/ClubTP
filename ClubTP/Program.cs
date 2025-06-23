using System;
using System.Collections;

namespace ClubTP
{
	class Program
	{
		public static void Main(string[] args)
		{
		 /* Persona auxA = new Persona();
			auxA.mostrarNombre();
			auxA.definirNombre();
			auxA.mostrarNombre();
			
			Entrenador auxB = new Entrenador();
			auxB.definirNombre();
			auxB.definirDni();
			auxB.definirEdad();
			auxB.definirLegajo();
			auxB.mostrarNombre();
			auxB.mostrarDni();
			auxB.mostrarEdad();
			auxB.mostrarLegajo();
			
			DeporteCategoria auxC = new DeporteCategoria("2006",b,20,15,15000);
			auxC.mostrarNombreDeporte();
			auxC.nombrarDeporte();
			auxC.mostrarNombreDeporte();*/
      
      // Menú
      Console.WriteLine("Bienvenidos al creador de Clubs.");
      Console.Write("1.Menú 2.salir: ");
      int opc = int.Parse(Console.ReadLine());

      while (opc != 2)
      {
       Console.WriteLine("a. Dar de ALTA un Entrenador.");
       Console.WriteLine("b. Dar de BAJA un Entrenador.");
       Console.WriteLine("c. Dar de ALTA un niño/socio en deporte.");
       Console.WriteLine("d. Dar de BAJA a un niño/socio en deporte.");
       Console.WriteLine("e. Pagar Cuota.");
       Console.WriteLine("f. Listado de inscriptos (Sub menú).");
       Console.WriteLine("g. Listado de deudores.");
       Console.WriteLine("h. Agregar un deporte.");
       Console.WriteLine("i. Eliminar un deporte.");
       Console.Write("Opciones: ");
       string op = Console.ReadLine();

       switch (op)
       {
        case 'a':
          Console.WriteLine("Dado de alta entrenador.");
          break;
        case 'b':
          Console.WriteLine("Dado de baja entrenador.");
          break;
        case 'c':
          Console.WriteLine("Dado de alta niño/socio en deporte.");
          break;
        case 'd':
          Console.WriteLine("Dado de baja niño/socio en deporte.");
          break;
        case 'e':
          Console.WriteLine("Cuota pagada.");
          break;
        case 'f':
          Console.WriteLine("1. Listado por deporte.");
          Console.WriteLine("2. Listado por deporte y categoría.");
          Console.WriteLine("3. Listar todo.");
          Console.Write("Opción: ");
          string res = Console.ReadLine();
          // Llamas a funciones y usar if, else if y else. 
          break;
        case 'g':
          Console.WriteLine("Listado de deudores.");
          break;
        case 'h':
          Console.WriteLine("Agregado el deporte.");
          break;
        case 'i':
          Console.WriteLine("Deporte Eliminado.");
          break;
        default:
          Console.Write("Opción invalida...");
          Console.ReadKey(true);
          Console.Clear();
          continue;
       }
        Console.WriteLine("1. Menú 2. Salir");
        Console.Write("Opción: ");
        opc = int.Parse(Console.ReadLine());
      }
			
			Console.Write("Presiona una tecla para finalizar . . . ");
			Console.ReadKey(true);
			
		}
	}
}
