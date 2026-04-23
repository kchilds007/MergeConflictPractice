public class EnemyAi
{
    public float DetectionRadius = 420f;
    public float PatrolSpeed = 123456789f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}