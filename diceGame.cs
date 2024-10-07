bool appOff = false;
// Instantiate the DicePick class
DicePick userDicePick = new DicePick();
// Instantiate the Random number class


Console.WriteLine("Do you want to play a game?");
Console.WriteLine("");
Console.WriteLine("Dice Just Rolled");
Console.WriteLine("Please choose a number 1 through 6");
string dicePick = Console.ReadLine();






switch (dicePick)
{
    case "1":
        userDicePick.UserPick();
        break;
    case "2":
        userDicePick.UserPick();
        break;    
    case "3":
        userDicePick.UserPick();
        break;    
    case "4":
        userDicePick.UserPick();
        break;    
    case "5":
        userDicePick.UserPick();
        break;    
    case "6":
        userDicePick.UserPick();
        break;
    default:
        Console.WriteLine("Invalid option. Please choose 1, 2, 3, 4, 5, or 6.");
    break;
}





class DiceRollGenerator
{
    public DiceRollGenerator()
    {
        
    }

    private Random randomRoll = new Random();
    public void DiceRoll()
    {
        //int month = rnd.Next(1, 13);  // creates a number between 1 and 12
        //int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
        //int card = rnd.Next(52);     // creates a number between 0 and 51
        int dice = randomRoll.Next(1, 7);   // creates a number between 1 and 6
    }
}
}

public class DicePick
{
    private int userTurnes = 0;

    public void UserPick()
    {
        Console.WriteLine("method works");
    }
}


class DiceMatchUp
{

}

