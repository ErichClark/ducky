using System;

class Assignment
	{
		static void Main ()
		{

		string firstString = "ok";
		string secondString = "ay";
		string thirdString;

		string firstNumber = "1";
		string secondNumber = "2";
		string thirdNumber;

		int first = 1;
		int second = 2;
		int third;

		Console.WriteLine ("First, let's add some text strings.");
		thirdString = firstString + secondString;
		Console.WriteLine ("If we add " + firstString + " with " + secondString + ", we get : " + thirdString);

		Console.WriteLine ("Now, we are going to add numbers that are actually text strings.");
		thirdNumber = firstNumber + secondNumber;
		Console.WriteLine ("If we add " + firstNumber + " and " + secondNumber + ", we get : " + thirdNumber);

		Console.WriteLine ("This is how to add and print integers.");
		third = first + second;
		Console.WriteLine ("If we add " + first + " and " + second + ", we get : " + third);


		}
	}

