using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void GetDamage();
}

public interface IDropable
{
    void DropItem();
}

public interface IAttackable
{
    void Attack();
}

public interface IUsable
{
    void Use();
}
