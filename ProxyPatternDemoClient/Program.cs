/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/14/2019
 * Time: 11:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using ICalculations;

namespace ProxyPatternDemoClient
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = Convert.ToInt16(args[0]);
			IPrime primeCalculator = new PrimeProxy();
			long prime = primeCalculator.FindNthPrimeNumber(n);
			
			string message = string.Format("The {0}th prime number is {1}", n, prime);
			Console.Write(message);
	//		Console.ReadKey(true);
		}
	}
}