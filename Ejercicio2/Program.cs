/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 5:21 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcion;
			double area, bas, altura, radio;
			Console.WriteLine("Programa para calcular diferentes figuras geometricas: ");
			Console.WriteLine("-----------------------------------------------------------");
			
			Console.Write("\nDigite 1 para el area del circulo. ");
			Console.Write("\nDigite 2 para el area del rectangulo. ");
			Console.Write("\nDigite 3 para el area del triangulo. ");
			Console.Write("\nDigite su opcion: ");
			opcion = int.Parse(Console.ReadLine());
			
			if (opcion==1){
				Console.Write("Digite el radio del circulo: ");
				radio = double.Parse(Console.ReadLine());
				area = Math.PI*Math.Pow(radio,2);
				Console.Write("El area del circulo es: "+area);
			}else if (opcion==2){
				Console.Write("Digite la base: ");
				bas = double.Parse(Console.ReadLine());
				Console.Write("Digite la altura: ");
				altura = double.Parse(Console.ReadLine());
				area = bas*altura;
				Console.Write("\nEl area del rectangulo es: "+area);
			}else if (opcion==3){
				Console.Write("Digite la base: ");
				bas = double.Parse(Console.ReadLine());
				Console.Write("Digite la altura: ");
				altura = double.Parse(Console.ReadLine());
				area = (bas*altura)/2;
				Console.Write("El area del triangulo es: "+area);
			}else{
				Console.Write("Opcion invalida.");
			}
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}