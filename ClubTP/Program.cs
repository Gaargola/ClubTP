using System;
using System.Collections;

namespace ClubTP
{
	class Program
	{
		public static void Main(string[] args)
		{
      // Menú
      Console.WriteLine("Bienvenidos al creador de Clubs.");
      Console.WriteLine("Ingrese el nombre del club: ");
      string nombre = Console.ReadLine();
      Club auxclub = new Club(nombre);
      bool flag = true;

      while (flag)
      {
       Console.WriteLine("==Menu principal==");
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
        case "0":
       	  Console.WriteLine("Saliendo del programa..");
       	  flag = false;
       	  break;
        case "1":
       	  Console.WriteLine("--Alta Entrenador--");
       	  Console.WriteLine("Ingrese el nombre del entrenador: ");
       	  string nombreEnt = Console.ReadLine();
       	  Console.WriteLine("Ingrese el dni del entrenador: ");
       	  int dniEnt = int.Parse(Console.ReadLine());
       	  Console.WriteLine("Ingrese la edad del entrenador: ");
       	  int edadEnt = int.Parse(Console.ReadLine());
       	  Console.WriteLine("Ingrese el legajo del entrenador: ");
       	  int legajoEnt = int.Parse(Console.ReadLine());
       	  Entrenador ent = new Entrenador(nombreEnt,dniEnt,edadEnt,legajoEnt);
       	  auxclub.registrarEntrenador(ent);
       	  Console.WriteLine("Entrenador dado de alta.");
          break;
        case "2":
          Console.WriteLine("--Baja Entrenador--");
          Console.WriteLine("Ingrese el legajo del entrenador que desea dar de baja: ");
          int leg = int.Parse(Console.ReadLine());
          auxclub.eliminarEntrenador(leg);
          //se podria agregar un esVacio();
          break;
        case "3":
          Console.WriteLine("--Alta Ninio--");
          Console.WriteLine("Ingrese el nombre del ninio/a: ");
       	  string nombreNin = Console.ReadLine();
       	  Console.WriteLine("Ingrese el dni del ninio/a: ");
       	  int dniNin = int.Parse(Console.ReadLine());
       	  Console.WriteLine("Ingrese la edad del ninio/a: ");
       	  int edadNin = int.Parse(Console.ReadLine());
       	  Console.WriteLine("Ingrese el ultimo mes de pago del ninio/a (en numeros del 1 al 12): ");
       	  int ultimoPagoNin = int.Parse(Console.ReadLine());
       	  Console.WriteLine("Ingrese la categoria del ninio: ");
       	  string categoriaNin = Console.ReadLine();
       	  
          Console.WriteLine("Dado de alta niño/socio en deporte.");
          break;
        case "4":
          Console.WriteLine("--Baja Ninio--");
          Console.WriteLine("Ingrese el dni del ninio/a que desea dar de baja");
          int dni = int.Parse(Console.ReadLine());
          //auxclub.eliminarNinio(dni);
          Console.WriteLine("Dado de baja niño/socio en deporte.");
          break;
        case "5":
          Console.WriteLine("Cuota pagada.");
          break;
        case "6":
          Console.WriteLine("--Tipos de listado--");
          Console.WriteLine("a. Listado por deporte.");
          Console.WriteLine("b. Listado por deporte y categoría.");
          Console.WriteLine("c. Listar todo.");
          Console.Write("Elija una opción: ");
          string res = Console.ReadLine();
          if(res == "a")
          {
             
          }
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
          continue;
       }
       }
      }
			Console.Write("Presiona una tecla para finalizar . . . ");
			Console.ReadKey(true);
		}
	}
}
