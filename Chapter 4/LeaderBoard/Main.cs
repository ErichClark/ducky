using System;

public enum Difficulty
{
	Expert,
	Medium,
	Casual,
};

public struct Account
{
	public Difficulty State;
	public string Name;
	public string Email;
	public int AccountNumber;
	public int PersonalBest;
}



public class LeaderBoard
{
	public static void Main ()
	{

		Account ErichsAccount;
		ErichsAccount.State = Difficulty.Expert;
		ErichsAccount.Name = "Erich Clark";
		ErichsAccount.Email = "erich.clark@gmail.com";
		ErichsAccount.AccountNumber = 1;
		ErichsAccount.PersonalBest = 10000;

		Console.WriteLine ("Name is: " + ErichsAccount.Name);
		Console.WriteLine ("Personal Best: " + ErichsAccount.PersonalBest);
		Console.WriteLine ("Difficulty: " + ErichsAccount.State);

		PrintAccount (ErichsAccount);

		if (IsNewHighScore (ErichsAccount, 10000)) {
			Console.WriteLine ("New high score!");
		} else {
			Console.WriteLine ("Your highest score was: " + ErichsAccount.PersonalBest);
		}
 		
	}

	public static void PrintAccount ( Account a ) 
	{ 
		Console.WriteLine ( "Name: " + a.Name ); 
		Console.WriteLine ( "Address: " + a.Email ); 
		Console.WriteLine ( "High Score: " + a.PersonalBest ); 
	}


	private static bool IsNewHighScore ( Account a, int newScore )
	{
		if (newScore < a.PersonalBest) {
			return false;
		}

		return true;
	}


}



