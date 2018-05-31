using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMakeADeal {
	class Program {
		static void Main(string[] args) {

			/*
			•	Coding challenge:
				o Let’s Make A Deal 1,2,3-- - behind either curtain 1, 2, or 3 is a grand prize
				o   You pick a number 1, 2, or 3
				o A number that you didn’t pick is revealed as not being the grand prize
				o You are now given the option to change your guess…should you change it?
				o Now write a program to simulate it
			*/
			int winnerwinnerchickendinner = 0;
			int stay = 0;
			int change = 0;

			//run the game 5,000 times
			for (int idx = 0; idx < 5000; idx++) {

				//step 1 - pick a random number 1, 2, or 3 that is the grand prize
				Random gp = new Random();
				int GrandPrize = gp.Next(1, 4);

				//step 2 - have user select a # 1,2, or 3
				int pick = int.Parse(Console.ReadLine());
				int notpick = 0;

				if (pick != GrandPrize & pick == 1 & GrandPrize == 2) {
					notpick = 3;
				//need to code the rest of this below as above
				} else if () { 
					notpick = 2;
				} else if (pick == 1 & GrandPrize == 3) {
					notpick = 3;
				} else if (pick == 2 & GrandPrize == 1) {
					notpick = 1;
				} else if (pick == 2 & GrandPrize == 3) {
					notpick = 3;
				} else if (pick == 3 & GrandPrize == 1) {
					notpick = 1;
				} else if (pick == 3 & GrandPrize == 2) {
					notpick = 2;
				} else {
					Console.WriteLine("Winner winner chicken dinner");
				}

				string changepick;
				Console.WriteLine("That wasn't the right answer...do you want to change your pick?");
				string response = Console.ReadLine();
				response = response.ToUpper(); //converts the answer to upper case
				changepick = response.StartsWith("Y"); //start with function which determines if answer variable starts with a Y
				//if they change their pick and it is correct then a plus 1 in the change int and if they change it and they are wrong then plus 1 in the stay int
				
			}
			//create an if statement that tells user what to do and gives % of wins if staying vs changing
			/*
			Console.WriteLine($"The grand prize was guessed on the first try: {winnerwinnerchickendinner}");
			Console.WriteLine($"Stay won the grand prize: {stay}");
			Console.WriteLine($"Change won the grand prize: {change}");
			*/
		}
	}
}
