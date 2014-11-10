using System;
using System.IO;

namespace InsAndOuts
{
	public class InsAndOuts
	{
		static void Main ()
		{
			StreamWriter writer ; 
			writer = new StreamWriter("test.txt");
			
			writer.WriteLine("hello world");
			writer.WriteLine("Let's see how this works.");

			for(var i = 1; i <= 5; i++){
				writer.WriteLine(i + " This works.");
			}

			writer.Close ();
			
			StreamReader reader; 
			reader = new StreamReader("Test.txt"); 
			while (reader.EndOfStream == false) 
			{ 
				string line = reader.ReadLine(); 
				Console.WriteLine(line); 
			} 
			reader.Close();
		}
	}
}
