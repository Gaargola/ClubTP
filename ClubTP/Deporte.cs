/*
 * Created by SharpDevelop.
 * User: nico user
 * Date: 20/6/2025
 * Time: 11:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ClubTP
{
	public class Deporte
	{
		private string Nombre;
		public Deporte(){}
		public Deporte(string nombre)
		{
		    this.Nombre = nombre;
		}
		public string nombrarDeporte()
		{
			Console.WriteLine("Ingrese nombre del deporte: ");
			this.Nombre = Console.ReadLine();
			return Nombre;
		}
		public void mostrarNombreDeporte()
		{
			Console.WriteLine("El nombre del deporte es: "+Nombre);
		}
		public string retornarNombre()
		{
		    return Nombre;
		}
	}
}
