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

    [SerializeField] private string name;
    [SerializeField] private int level;
    [SerializeField] private int experience;
    [SerializeField] private int maxHealth;
    [SerializeField] private int attackPower;
    [SerializeField] private int defense;
    [SerializeField] private int gold;
    [SerializeField] private int speed;

    private void Awake()
    {
        Name = name;
        Level = level;
        Experience = experience;
        MaxHealth = maxHealth;
        AttackPower = attackPower;
        Defense = defense;
        Gold = gold;
        Speed = speed;
    }
}
