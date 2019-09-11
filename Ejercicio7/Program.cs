/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 6:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num1, num2, num3;
			
			Console.Write("Digite el primer numero: ");
			num1 = double.Parse(Console.ReadLine());
			Console.Write("Digite el segundo numero: ");
			num2 = double.Parse(Console.ReadLine());
			Console.Write("Digite el tercer numero: ");
			num3 = double.Parse(Console.ReadLine());
			
			if (num1==num2 && num1==num3){
				Console.Write("Los numeros son iguales. ");
				
			}else if(num1>=num2 && num1>=num3){
				Console.Write("El numero mayor es: "+num1);
				
			}else if(num2>=num1 && num2>=num3){
				Console.Write("El numero mayor es: "+num2);
			}else if(num3>=num1 && num3>=num2){
				Console.Write("El numero mayor es: "+num3);
			}
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}