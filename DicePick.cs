using System.Threading.Channels;

public class DicePick
{
    //int userTurn = 0;

    public void UserPick(int userTypedDicePickNumber, int computerRoll)
    //public void UserPick(int userTypedDicePickNumber, int computerRoll, GameMenu gameMenu)
    {
        //bool winGame = true;

        for (int userTurn = 1; userTurn <= 3; userTurn++)
        {
            if (userTypedDicePickNumber == computerRoll)
            //if (userTypedDicePickNumber == computerRoll && winGame == true)
            {
                Console.WriteLine("You win");
                break ;
            }
            if (userTurn == 1)
            //if (userTurn == 1 && winGame == false)
            {
                //gameMenu.GameMenuUserPicker();

                //userTurn++;
                Console.WriteLine("Sorry you guessed wrong, you have two more chance.");
                Console.WriteLine("guess 1");
                userTypedDicePickNumber = int.Parse(Console.ReadLine());
            }

            else if (userTurn == 2)
            //else if (userTurn == 2 && winGame == false)
            {
                //gameMenu.GameMenuUserPicker();

                Console.WriteLine("Sorry you guessed wrong, you have one more chance.");
                Console.WriteLine("guess 2");
                userTypedDicePickNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You lose the the dice roll was " + computerRoll);
            }
        }
        Console.ReadKey();
    }
}
