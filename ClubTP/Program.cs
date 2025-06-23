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
      Console.WriteLine("Ingrese el nombre del club: ");
      string nombre = Console.ReadLine();
      Club auxclub = new Club(nombre);
      bool flag = true;

      while (flag)
      {
       Console.WriteLine("0. Salir del creador de Clubs.");
       Console.WriteLine("1. Dar de ALTA un Entrenador.");
       Console.WriteLine("2. Dar de BAJA un Entrenador.");
       Console.WriteLine("3. Dar de ALTA un niño/socio en deporte.");
       Console.WriteLine("4. Dar de BAJA a un niño/socio en deporte.");
       Console.WriteLine("5. Pagar Cuota.");
       Console.WriteLine("6. Listado de inscriptos (Sub menú).");
       Console.WriteLine("7. Listado de deudores.");
       Console.WriteLine("8. Agregar un deporte.");
       Console.WriteLine("9. Eliminar un deporte.");
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
       	case "0":
       	  Console.WriteLine("Saliendo del programa..");
       	  flag = false;
       	  break;
        case "1":
       	  Console.WriteLine("--Alta Entrenador--");
       	  Console.WriteLine("Ingrese el nombre del entrenador: ");
       	  string nombreEnt = Console.ReadLine();
       	  Console.WriteLine("Ingrese el dni del entrenador: ");
       	  int dni = int.Parse(Console.ReadLine());
       	  Console.WriteLine("Ingrese la edad del entrenador: ");
       	  int edad = int.Parse(Console.ReadLine());
       	  Console.WriteLine("Ingrese el legajo del entrenador: ");
       	  int legajo = int.Parse(Console.ReadLine());
       	  Entrenador ent = new Entrenador(nombreEnt,dni,edad,legajo);
       	  auxclub.registrarEntrenador(ent);
       	  Console.WriteLine("Entrenador dado de alta.");
          break;
        case "2":
          Console.WriteLine("Dado de baja entrenador.");
          break;
        case "3":
          Console.WriteLine("Dado de alta niño/socio en deporte.");
          break;
        case "4":
          Console.WriteLine("Dado de baja niño/socio en deporte.");
          break;
        case "5":
          Console.WriteLine("Cuota pagada.");
          break;
        case "6":
          Console.WriteLine("a. Listado por deporte.");
          Console.WriteLine("b. Listado por deporte y categoría.");
          Console.WriteLine("c. Listar todo.");
          Console.Write("Opción: ");
          string res = Console.ReadLine();
          // Llamas a funciones y usar if, else if y else. 
          break;
        case "7":
          Console.WriteLine("Listado de deudores.");
          break;
        case "8":
          Console.WriteLine("Agregado el deporte.");
          break;
        case "9":
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
          continue;
       }
      }
			Console.Write("Presiona una tecla para finalizar . . . ");
			Console.ReadKey(true);
		}
	}
}
