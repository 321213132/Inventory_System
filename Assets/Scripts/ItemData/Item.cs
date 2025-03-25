using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable, //소비형
    Equipment,  //장비형
    Material    //재료
}

public class Item
{
    public string ItemName {  get; private set; }//아이템 이름
    public Sprite Icon { get; private set; }//아이템 아이콘
    public int Quantity { get; private set; }//갯수
    public ItemType Type { get; private set; }//아이템 타입
    public bool IsEquipped { get; private set; } = false;

    public Item(string itemName, Sprite icon, int quantity, ItemType type)
    {
        ItemName = itemName;
        Icon = icon;
        Quantity = quantity;
        Type = type;
    }
}
