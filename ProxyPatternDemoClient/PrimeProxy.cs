/*
 * Created by SharpDevelop.
 * User: thieu
 * Date: 12/15/2019
 * Time: 12:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using ICalculations;

namespace ProxyPatternDemoClient
{
	/// <summary>
	/// Description of PrimeProxy.
	/// </summary>
	public class PrimeProxy : IPrime
	{
		public PrimeProxy()
		{
		}
		
		public long FindNthPrimeNumber(int n)
		{
			Process process = new System.Diagnostics.Process();
			process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.FileName = "ProxyPatternDemoServer.exe";
			process.StartInfo.Arguments = n.ToString();
			process.Start();
			string raw = process.StandardOutput.ReadToEnd();
			string filtered = raw.Trim(System.Environment.NewLine.ToCharArray());
			return Convert.ToInt16(filtered);

		}
	}
}
