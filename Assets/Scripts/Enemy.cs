using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : IDamageable, IDropable, IAttackable
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int MaxHealth { get; private set; }
    public int Damage { get; private set; }
    public EnemyType Type { get; private set; }

    public Enemy(string name, string description, int maxHealth, int damage, EnemyType type)
    {
        Name = name;
        Description = description;
        MaxHealth = maxHealth;
        Damage = damage;
        Type = type;
    }

    public void Attack()
    {
        Debug.Log($"{Name} ataca con {Damage} de daño.");
    }

    public void GetDamage()
    {
        Debug.Log($"{Name} recibe daño.");
    }

    public void DropItem()
    {
        Debug.Log($"{Name} ha soltado un objeto al morir.");
    }
}
