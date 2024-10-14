public class DiceRollGenerator
{
    private Random randomRoll = new Random();
    public int DiceRoll()
    {
        int dice = randomRoll.Next(1, 7);   // creates a number between 1 and 6
        //reads the random number of the dice
        //Console.WriteLine(dice);
        return dice;
    }
}
