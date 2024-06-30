using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField]
    int maxHealth = 3;

    int health;

    public int CurrentHealth { get => health; }
    public int MaxHealth { get => maxHealth; } 

    private void Awake()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damagePoints)
    {
        int damage = Mathf.Max(0, damagePoints);
        health = Mathf.Max(0, health - damage);
    }
}
