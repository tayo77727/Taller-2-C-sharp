/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 6:57 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double precio, descuento=0;
			
			Console.Write("Digite el precio del articulo: ");
			precio = double.Parse(Console.ReadLine());
			
			if (precio>=200){
				descuento=precio*0.15;
				Console.Write("El descuento es del 15%");
			}else if (precio>=100 && precio<200){
				descuento=precio*0.12;
				Console.Write("El descuento es del 12%");
			}else if (precio<100){
				descuento=precio*0.10;
				Console.Write("El descuento es del 10%");
			}
			
			Console.Write("\nEl precio con el descuento aplicado es: "+(precio-descuento));
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}