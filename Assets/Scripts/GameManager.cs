using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Enemy goblin = new Enemy("Goblin", "Un pequeño pero rápido enemigo.", 100, 15, EnemyType.Goblin);
        Enemy orc = new Enemy("Orco", "Fuerte pero lento.", 200, 30, EnemyType.Orc);

        goblin.Attack();
        goblin.GetDamage();
        goblin.DropItem();

        orc.Attack();
        orc.GetDamage();
        orc.DropItem();

        Item potion = new Item("Poción de Salud", "Recupera vida.", ItemType.Consumible);
        Item speedBuff = new Item("Buff de Velocidad", "Aumenta velocidad.", ItemType.Buff);

        potion.Use();
        speedBuff.Use();
    }
}
