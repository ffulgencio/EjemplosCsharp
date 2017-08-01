using System;

namespace Delegados
{
	// Creamos tipo delegado para representar metodos que no retornan valor y no tienen parametros
	public delegate void MiDelegado();

	//Creamos un tipo de delegado para representar metodos que retorna valor y recibe parametos
	public delegate int DelegadoInt(int a);


	class MainClass
	{
		public static int Num;

		public static void Main (string[] args)
		{
			
//
		    MiDelegado del = new MiDelegado (Saludar);
			del();
			del.Invoke (); // Los delegados se pueden llamar mediante () o por el metodo Invoke.


			DelegadoInt ConLambda = x => x * 2;
			Console.WriteLine (ConLambda (4));


			// Asignacion de un metodo anonimo a un delegado que no retorna valor
			del = delegate()
					{
						Console.WriteLine("Metodo Anonimo");
						Console.WriteLine ("Otra");		
					};

			// Asignacion de un metodo anonimo a un delegado que retorna valor
			DelegadoInt delint = delegate(int a) 
			{
				return a*2;
			};
   			
			Console.WriteLine (delint(4));

			recibeDelegado(del);
	
			delint(4);

			Persona Juan = new Persona ("Juan");
			Persona Marco;
//			Persona Marco = Juan;
			Marco = DPersona();
			Console.WriteLine (Marco.Nombre);
			RecibePErsona (new Persona("Pedro"), 12);
			Num = AsignarNumero();
		    Console.WriteLine (Num);
			Console.ReadKey ();
		}


		//
		public static Persona DPersona()
		{
			return new Persona ("Maria"); // se crea un objeto anonimo de tipo Persona.
			/* lo anterior es quivalente a que hayamos escrito:
			 * Persona p = new Persona("Maria");
			 * return p;
			 */ 
		}

		// Este metodo retorna un valor de tipo entero
		public static int AsignarNumero(){
			return  14;
		}	

		// Este metodo recibe un objeto del tipo persona como parametro
		public static void RecibePErsona(Persona p, int x)
		{
			Console.WriteLine (p.Nombre + x);
		}


		// Este metodo se uso para probar la forma basica del un delegado
		public static  void Saludar()
		{
			Console.WriteLine ("Hola a todos!");
		}

		// Recibe un delegado como parametro, de esta forma
		// podemos pasar un metodo como parametro a otro metodo
		public static void recibeDelegado(MiDelegado d)
		{
			d(); // llamada a un delegado pasado como parametro
		}
	}

	// Esta clase se para ejemplo de uso de objetos anonimos
	class Persona{

		public Persona(string n){
			Nombre = n;
		}
		public string Nombre {
			get;
			set;
		}
	}

}
