using System;
class PortCalc
{
	static void Main()
	{
		const double PI = 3.1415;
		const double MAX_RADIUS = 12;
		const double MIN_RADIUS = 4;
		const double GLASS_COST_PER_SQ_IN = 20.00;
		const double GASKET_COST_PER_IN = 5.00;
		const double GASKET_THICKNESS = 0.25 * 2; // gasket is found around the entire edge of port

		string radiusString;
		double radius;
		double holeRadius;

		double glassArea;
		double glassCost;

		double gasketLength;
		double gasketCost;

		double totalCost;


		Console.Write ("This program calculates the area of a port window \n and the gasket length around it.\n" +
			"We can make windows with radii between " + MIN_RADIUS + " and " + MAX_RADIUS + " inches.\n\n");


		radius = readValue ("Enter port window radius between ", MIN_RADIUS, MAX_RADIUS);

		holeRadius = radius + GASKET_THICKNESS;
		glassArea = PI * ( radius * radius ) ;
		glassCost = glassArea * GLASS_COST_PER_SQ_IN;
		gasketLength = 2 * PI * radius;
		gasketCost = gasketLength * GASKET_COST_PER_IN;
		totalCost = glassCost + gasketCost;


		Console.WriteLine ( "\nFor a window with a radius of " + radius + " inches:");
		Console.WriteLine ( "Area in sq inches: {0,-20:0.00} Cost: ${1,-15:##,##0.00}", glassArea, glassCost ) ;
		Console.WriteLine ( "Gasket in inches:  {0,-20:0.00} Cost: ${1,-15:##,##0.00}", gasketLength, gasketCost ) ;
		Console.WriteLine ( "Total window cost: ${0,-20:0.00}", totalCost );
		Console.WriteLine ( "INSTALLATION NOTE: This port will require a hole with a radius of " + holeRadius + " inches.");
		Console.WriteLine ( "Enter another port radius or 0 to exit program.\n");


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
}
