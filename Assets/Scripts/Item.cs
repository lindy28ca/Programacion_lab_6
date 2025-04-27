using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : IUsable
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ItemType Type { get; private set; }

    public Item(string name, string description, ItemType type)
    {
        Name = name;
        Description = description;
        Type = type;
    }

    public void Use()
    {
        Debug.Log($"{Name} ({Type}) ha sido usado.");
    }
}
