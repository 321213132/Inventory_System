using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    List<Item> itemDatas = new List<Item>();
    public Character player {  get; private set; }
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
        SetData();
        UIManager.Instance.UpdateUI();
    }

    private void SetData()
    {
        player = FindObjectOfType<Character>();
        player.SetData("barbarian", 12, 5, 50, 20, 10, 10000, 10);

        Item healthPotion = new Item("ü������", null, 3, ItemType.Consumable);
        Item ManaPotion = new Item("��������", null, 5, ItemType.Consumable);
        Item woodSword = new Item("������", null, 1, ItemType.Equipment);


        //������ �������� �÷��̾ ����
        player.AddItem(healthPotion);
        player.AddItem(ManaPotion);
        player.AddItem(woodSword);
    }
}
