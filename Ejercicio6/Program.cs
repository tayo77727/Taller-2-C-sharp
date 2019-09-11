/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 6:37 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			double F, N, var1, var2, var3;
			
			Console.Write("Digite el valor de N: ");
			N = double.Parse(Console.ReadLine());
			
			var1 = 1/Math.Sqrt(5);
			var2 = (1+Math.Sqrt(5))/2;
			var3 = (1-Math.Sqrt(5))/2;
			
			F = var1*((Math.Pow(var2,N)-Math.Pow(var3,N)));
			
			Console.Write("El valor de la expresion es: "+F);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}