using System;

namespace Practica3{
	
	class Persona{
		public string nombre;
		public string correo;
		public int edad;
		
		public static void Main(string[] args){
			
			string opc;
			Persona p=new Persona();
			
			do{
				Console.WriteLine("\t\t *Menu");
				Console.WriteLine("\t 1- Introducir datos Prsonales");
				Console.WriteLine("\t 2- Mostrar datos Prsonales");
				Console.WriteLine("\t 3- Salir");
				opc = Console.ReadLine(); 
			
				switch(opc){
					
					case "1":
						Console.Clear();
						Console.WriteLine("\t\t\tIntroducir Datos: ");
						Console.WriteLine("Introdusca su Nombre: ");
						p.nombre = Console.ReadLine();
						Console.WriteLine("Introdusca su edad: ");
						p.edad = int.Parse(Console.ReadLine());
						Console.WriteLine("Introdusca su correo: ");
						p.correo = Console.ReadLine();
						Console.Clear();
					break;
				
					case "2":
						Console.Clear();
						Console.WriteLine("\t\t\tDatos:");
						Console.WriteLine("Nombre: "+ p.nombre);
						Console.WriteLine("Edad:   "+ p.edad);
						Console.WriteLine("Correo: "+ p.correo);
						Console.WriteLine("\n");
					break;
					
					default:
						Console.Clear();
						Console.WriteLine("\t La opcion "+ opc +" es incorrecta\n");
					break;
				}
			}while(opc!="3");
		}
	}
}
