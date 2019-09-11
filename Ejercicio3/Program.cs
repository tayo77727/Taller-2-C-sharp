/*
 * Created by SharpDevelop.
 * User: oldta
 * Date: 10/09/2019
 * Time: 5:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("");
			
			 int mes;

    		Console.Write("Digite el mes como numero entero: ");
    		mes = int.Parse(Console.ReadLine());

   			if (mes==2){
        		Console.Write("El mes tiene 28 dias. ");
    		}else if (mes == 4 || mes == 6 || mes == 9 || mes == 11){
        		Console.Write("El mes tiene 30 dias. ");
    		}else if (mes ==1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 12){
       		 	Console.Write("El mes tiene 31 dias.");
    		}else{
        		Console.Write("Digite el numero correspondiente a el mes. ");
    		}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}