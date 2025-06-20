using System;
using System.Collections;
namespace ClubTP
{

	public class Club
	{
		private string Nombre;
		private ArrayList Deportes;
		private ArrayList DeportesCat;
		private ArrayList Entrenadores;
		private ArrayList Ninios;
		
		public Club()
		{
			this.Deportes = new ArrayList();
			this.DeportesCat = new ArrayList();
			this.Entrenadores = new ArrayList();
			this.Ninios = new ArrayList();
		}
		public Club(string nombre)
		{
			this.Nombre = nombre;
			this.Deportes = new ArrayList();
			this.DeportesCat = new ArrayList();
			this.Entrenadores = new ArrayList();
			this.Ninios = new ArrayList();
		}
		public string definirNombreClub()
		{
			Console.WriteLine("Ingrese el nombre del Club: ");
			this.Nombre = Console.ReadLine();
			return Nombre;
		}
		
	}
}
