using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public int MaxHealth { get; private set; }
    public int AttackPower { get; private set; }
    public int Defense { get; private set; }
    public int Gold { get; private set; }
    public int Speed { get; private set; }

    public List<Item> inventory { get; private set; }//아이템 목록

    public void SetData(string name, int level, int experience, int maxHealth, int attackPower, int defense , int gold, int speed)
    {
        Name = name;
        Level = level;
        Experience = experience;
        MaxHealth = maxHealth;
        AttackPower = attackPower;
        Defense = defense;
        Gold = gold;
        Speed = speed;

        inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (item != null)
        {
            inventory.Add(item);
        }
    }

    public void Equip(Item item)
    {
        if(item == null || !item.IsEquipped)
        {
            return;
        }

    }
    public void UnEquip(Item item)
    {
        if (item == null || !item.IsEquipped)
        {
            return;
        }
    }
}
