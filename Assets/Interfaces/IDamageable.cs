public interface IDamageable
{
    public int CurrentHealth { get; }
    public int MaxHealth { get; }

    public void TakeDamage(int damagePoints);
}
