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
