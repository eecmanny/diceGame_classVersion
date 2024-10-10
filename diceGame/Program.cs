//bool appOff = false;

// Instantiate the DicePick class
DicePick userDicePick = new DicePick();
// Instantiate the Random number class
DiceRollGenerator roll = new DiceRollGenerator();
////verified random roll method works
//Console.WriteLine(roll.DiceRoll());

//Console.WriteLine(roll.dice);


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

public class DiceRollGenerator
{
    private Random randomRoll = new Random();
    public int DiceRoll()
    {
        int dice = randomRoll.Next(1, 7);   // creates a number between 1 and 6
        //Console.WriteLine(dice);
        return dice;
    }
}

public class DicePick
{
    private int userTurn = 0;

    public void UserPick(int userTypedDicePickNumber, int computerRoll)
    {
        if (userTurn == 0)
        {
            userTurn++;
            //if (userTypedDicePickNumber == roll.DiceRoll())
            if (userTypedDicePickNumber == computerRoll)
            {
                Console.WriteLine("Number doesn't match try again");
            }
            else if (userTurn == 1)
            {
                Console.WriteLine("Sorry you guessed wrong again, you have one more chance.");
            }
            else
            {
                Console.WriteLine("You lose!");

            }
            Console.WriteLine("method works");
        }
        Console.WriteLine("method works");
    }
}

class DiceMatchUp
{
    private void DiceNumberGuess()
    {
        Console.WriteLine("method worked");
    }
}
