public class EnemyAi
{
    public float DetectionRadius = 10f;
    public float PatrolSpeed = 3f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}