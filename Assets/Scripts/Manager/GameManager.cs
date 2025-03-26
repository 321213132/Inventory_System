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

        Item healthPotion = new Item("체력포션", null, 3, ItemType.Consumable);
        Item ManaPotion = new Item("마나포션", null, 5, ItemType.Consumable);
        Item woodSword = new Item("나무검", null, 1, ItemType.Equipment);


        //생성된 아이템을 플레이어에 저장
        player.AddItem(healthPotion);
        player.AddItem(ManaPotion);
        player.AddItem(woodSword);
    }
}
