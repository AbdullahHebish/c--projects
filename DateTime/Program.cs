
	
using System;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic;

public class GFG{ 
	
	static int sum(int [] arr)
	{	
		int sum= arr.Sum();
		return sum;
	}
	// Main Method 
	static void Main(string[] args) 
	{	
		Console.BackgroundColor=ConsoleColor.Red;
		Console.ForegroundColor=ConsoleColor.White;
		Console.WriteLine("Enter your birth date (year,month,day)");
	   DateOnly dateTime = DateOnly.Parse(Console.ReadLine());
	   Console.WriteLine ($"the day that you born in it is {dateTime.DayOfWeek}");
		System.Console.WriteLine($"{dateTime.DayOfWeek} of month {dateTime:MMMM} of year {dateTime.Year}");
	}
}

