/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 1:26 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, resultado, opcion;
			
			Console.Write("Digite un numero: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Digite otro numero: ");
			num2 = int.Parse(Console.ReadLine());
			
			Console.Write("\nLas opciones son: \n1 - Adicion. \n2 - Sustraccion. \n3 - Multiplicacion. \n4 - Division. \n");
			Console.Write("\nIngrese su opcion: ");
			opcion = int.Parse(Console.ReadLine());
			
			if (opcion==1){
				resultado=num1+num2;
				Console.Write("\nEl resultado de la Adicion de los numeros es: "+resultado);
			}else if (opcion==2){
				resultado=num1-num2;
				Console.Write("\nEl resultado de la Sustraccion de los numeros es: "+resultado);
			}else if (opcion==3){
				resultado=num1*num2;
				Console.Write("\nEl resultado de la multiplicacion de los numeros es: "+resultado);
			}else if (opcion==4){
				resultado=num1/num2;
				Console.Write("\nEl resultado de la division de los numeros es: "+resultado);
			}else{
				Console.Write("\nOpcion invalida.");
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}