/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 5:51 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			double unidad, pago=0;
			
			Console.Write("Digite el nombre del cliente: ");
			nombre = Console.ReadLine();
			Console.Write("Digite el cargo de la unidad consumida: ");
			unidad = double.Parse(Console.ReadLine());
			
			if(unidad>0 && unidad<=199){
				pago = unidad*1.20;
			}else if (unidad>=200 && unidad<400){
				pago = unidad*1.50;
			}else if (unidad>=400 && unidad<600){
				pago = unidad*1.80;
			}else if (unidad>=600){
				pago = unidad*2;
			}
			Console.Write("El total a pagar del cliente "+nombre+" es: "+pago);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}