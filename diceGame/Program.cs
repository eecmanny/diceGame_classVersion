GameMenu gameMenu = new GameMenu();
gameMenu.GameMenuUserPicker();

public class DiceRollGenerator
{
    private Random randomRoll = new Random();
    public int DiceRoll()
    {
        int dice = randomRoll.Next(1, 7);   // creates a number between 1 and 6
        Console.WriteLine(dice);
        return dice;
    }
}

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
    }
}

class DiceMatchUp
{
    private void DiceNumberGuess()
    {
        Console.WriteLine("DiceNumberGuess method worked");
    }
}
public class GameMenu
{
    public void GameMenuUserPicker()
    {

        DicePick userDicePick = new DicePick();
        // Instantiate the Random number class
        DiceRollGenerator roll = new DiceRollGenerator();

        Console.WriteLine("Do you want to play a game?");
        Console.WriteLine("");
        Console.WriteLine("Dice Just Rolled");
        Console.WriteLine("Please choose a number 1 through 6");
        string userTypedDicePick = Console.ReadLine();

        int userTypedDicePickNumber = int.Parse(userTypedDicePick);
        int computerRoll = roll.DiceRoll();

        switch (userTypedDicePick)
        {
            case "1":
                userDicePick.UserPick(userTypedDicePickNumber, computerRoll);
                break;
            case "2":
                userDicePick.UserPick(userTypedDicePickNumber, computerRoll);
                break;
            case "3":
                userDicePick.UserPick(userTypedDicePickNumber, computerRoll);
                break;
            case "4":
                userDicePick.UserPick(userTypedDicePickNumber, computerRoll);
                break;
            case "5":
                userDicePick.UserPick(userTypedDicePickNumber, computerRoll);
                break;
            case "6":
                userDicePick.UserPick(userTypedDicePickNumber, computerRoll);
                break;
            default:
                Console.WriteLine("Invalid option. Please choose 1, 2, 3, 4, 5, or 6.");
                break;
        }
    }
}
