using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable, //소비형
    Equipment,  //장비형
    Material    //재료
}

[CreateAssetMenu(fileName = "Itme", menuName = "New Item")]
public class Item : ScriptableObject
{
    public string ItemName; //아이템 이름
    public Sprite Icon; //아이템 아이콘
    public int Quantity; //갯수
    public ItemType Type; //아이템 타입
    public bool IsEquipped = false;

    public Item(string itemName, Sprite icon, int quantity, ItemType type)
    {
        ItemName = itemName;
        Icon = icon;
        Quantity = quantity;
        Type = type;
    }
}
