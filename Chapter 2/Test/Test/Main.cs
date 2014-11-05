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
		while(true)
		{

			Console.Write ("Enter port window radius between " + MIN_RADIUS + " and " + MAX_RADIUS + " inches or any negative number to exit:\n");
			radiusString = Console.ReadLine();
			radius = double.Parse(radiusString);

			if(radius < 0){
				break;
			}

			if  (radius > MAX_RADIUS) {
				Console.WriteLine ("\n-ERROR- A window with a radius greater than " + MAX_RADIUS + " inches is unsafe! \n");
				radius = MAX_RADIUS;
				continue;
			}

			if  (radius < MIN_RADIUS) {
				Console.WriteLine ("\n-ERROR- We can't make a port with a radius of less than " + MIN_RADIUS + " inches. \n");
				radius = MIN_RADIUS;
				continue;
			}

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
			Console.WriteLine ( "INSTALLATION NOTE: This port will require a hole with a radius of " + holeRadius + " inches.\n");
		}
	}
}
