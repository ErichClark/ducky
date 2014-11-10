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



class LeaderBoard
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
	}
	
	public void PrintAccount ( Account a ) 
	{ 
		Console.WriteLine ( "Name: " + a.Name ); 
		Console.WriteLine ( "Address: " + a.Email ); 
		Console.WriteLine ( "Balance: " + a.PersonalBest ); 
	}
}


