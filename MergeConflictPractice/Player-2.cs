public class Player
{
    // TODO: branches will replace these 0 placeholders
    public float MoveSpeed = 100000f;
    public float JumpForce = 100000000f;

    public void Move(float horizontal)
    {
        Console.WriteLine($"Moving at speed {MoveSpeed}, input: {horizontal}");
    }
}