/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/14/2019
 * Time: 11:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using ICalculations;

namespace Calculations
{
	/// <summary>
	/// Description of Prime.
	/// </summary>
	public class Prime : IPrime
	{
		
		public Prime()
		{
			
		}
		
		public long FindNthPrimeNumber(int n)
		{
			int count=0;
			long a = 2;
			while(count<n)
			{
				long b = 2;
				int prime = 1;// to check if found a prime
				while(b * b <= a)
				{
					if(a % b == 0)
					{
						prime = 0;
						break;
					}
					b++;
				}
				if(prime > 0)
				{
					count++;
				}
				a++;
			}
			return (--a);
		} 
		
	}
}