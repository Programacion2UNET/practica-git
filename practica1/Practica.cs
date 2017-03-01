using System;
namespace practica1{
	
	public class Practica{
			public Int32 gcd(Int32 a, Int32 b){
    				if (b = 0)
      					return a; 
    				else
       					return gcd(b, a%b);
		}
		public static void Main(string[] args){

			//Probando que en C# el numero es un objeto
			Int32 num = 2017,x,y;
      
			Console.WriteLine("Hola Mundo.");
            Console.Write("hola compatriotas y compatriotos por aqui paso @nico");
			Console.WriteLine(num.ToString());
            x = Console.ReadLine();
			y = Console.ReadLine();
			Console.Write(gcd(x,y));
	
		}

	}

}
