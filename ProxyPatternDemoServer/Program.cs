/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/14/2019
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using ICalculations;
using Calculations;



namespace ProxyPatternDemoServer
{
	class Program
	{
		public static void Main(string[] args)
		{
			int indexNumber = Convert.ToInt16(args[0]);
			Prime prime = new Prime();
			Console.WriteLine(prime.FindNthPrimeNumber(indexNumber));
			//Console.ReadKey(true);
		}
		
		
		
		
	}
}