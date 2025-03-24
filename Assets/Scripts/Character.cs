using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Character : MonoBehaviour
{

    public string name;
    public int level;
    public int experience;

    public int maxhealth;
    public int attackPower;
    public int defense;
    public int Gold;
    public int speed;

    public Character(string name, int level, int experience, int maxhealth, int attackPower, int defense, int gold, int speed)
    {
        this.name = name;
        this.level = level;
        this.experience = experience;
        this.maxhealth = maxhealth;
        this.attackPower = attackPower;
        this.defense = defense;
        Gold = gold;
        this.speed = speed;
    }
}
