using System;

enum Difficulty
{
	Expert,
	Medium,
	Casual,
};

struct Account
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

		// PrintAccount (ErichsAccount);

		if (ErichsAccount.HighScore (10000)) {
			Console.WriteLine ("New high score!");
		} else {
			Console.WriteLine ("Your highest score was: " + Account.PersonalBest);
		}
	}
}

public class HighScore
{
	public void PrintAccount ( Account a ) 
	{ 
		Console.WriteLine ( "Name: " + a.Name ); 
		Console.WriteLine ( "Address: " + a.Email ); 
		Console.WriteLine ( "Balance: " + a.PersonalBest ); 
	}

	private bool NewHighScore ( int newScore )
	{
		if (newScore < PersonalBest) {
			return false;
		}
		PersonalBest = newScore;
		return true;
	}


}


