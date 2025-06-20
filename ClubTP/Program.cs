/*
 * Created by SharpDevelop.
 * User: demondev
 * Date: 19/6/2025
 * Time: 19:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ClubTP
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Persona a = new Persona();
			a.mostrarNombre();
			a.definirNombre();
			a.mostrarNombre();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}