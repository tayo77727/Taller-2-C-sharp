/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 6:11 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			string letra;
			
			Console.Write("Digite una letra: ");
			letra = Console.ReadLine();
			
			if (letra=="a" || letra=="e" || letra=="i" || letra=="o" || letra=="u" || letra=="A" || letra=="E" ||letra=="I" ||letra=="O" ||letra=="U"){
				Console.Write("Es una vocal. ");
			} else {
				Console.Write("Es una consonante.");
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}