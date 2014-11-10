using System;

namespace MmmMethody
{
	class MainClass
	{
		static int sillyReturnPlus (int i)
		{
			i = i + 1;
			Console.WriteLine ("i is: " + i);
			return i;
		}
		public static void Main ()
		{
			int res;
			res = sillyReturnPlus (5);
			Console.WriteLine ("res is: " + res);

			int min = 2;
			int max = 10;
			double pick = readValue ("Pick a number", min, max); 
			Console.WriteLine ("You picked " + pick);
		}
		static double readValue ( 
		                         string prompt, // prompt for user
		                         double min,    // lowest allowable value
		                         double max     // largest allowable value
		                         )
		{
			double result = 0;
			do
			{
				Console.WriteLine (prompt + " between " + min + " and " + max );
				string resultString = Console.ReadLine ();
				result = double.Parse(resultString);
			} while ( (result < min) || (result > max) );
			return result;
		}

		void InsAndOuts();
	}
}
