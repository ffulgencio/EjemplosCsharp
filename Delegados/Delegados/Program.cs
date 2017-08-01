using System;

namespace Delegados
{
	public delegate void MiDelegado();
	public delegate int DelegadoInt(int a);

	class Persona{

		public Persona(string n){
			Nombre = n;
		}
		public string Nombre {
			get;
			set;
		}
	}
	class MainClass
	{
		public static int Num;

//		public static int AsignarNumero(){
//			return  14;
//		}	

		public static Persona DPersona(){
			Persona p = new Persona("Maria");
			return p;
		}

		public static void RecibePErsona(Persona p, int x){
			Console.WriteLine (p.Nombre);
		}
		public static void Main (string[] args)
		{
			Persona Juan = new Persona ("Juan");
			Persona Marco;
			Marco = DPersona();
			Console.WriteLine (Marco.Nombre);
			RecibePErsona (new Persona("Pedro"), 12);
//
//			MiDelegado del = new MiDelegado (Saludar);
//			Num = AsignarNumero();
//			Console.WriteLine (Num);
//			DelegadoInt ConLambda = 14;
//			Console.WriteLine (ConLambda (4));
//			//del();
////		
////				Console.WriteLine("Metodo Anonimo");
////				Console.WriteLine ("Otra");
////			};
////
//			DelegadoInt delint = delegate(int a) {
//				return a*2;
//			};
////			Console.WriteLine (delint(4));
			//recibeDelegado(del);
			//LlamaAnonimo();
		}




		public static  void Saludar(){
			Console.WriteLine ("Hola a todos!");
		}

		public static void recibeDelegado(MiDelegado d){
			d();
		}
	}
}
