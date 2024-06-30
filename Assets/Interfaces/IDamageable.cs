using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public int CurrentHealth { get; }
    public int MaxHealth { get; }

    public void TakeDamage(int damagePoints);
}
