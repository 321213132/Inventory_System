using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable, //�Һ���
    Equipment,  //�����
    Material    //���
}

public class Item
{
    public string ItemName {  get; private set; }//������ �̸�
    public Sprite Icon { get; private set; }//������ ������
    public int Quantity { get; private set; }//����
    public ItemType Type { get; private set; }//������ Ÿ��
    public bool IsEquipped { get; private set; } = false;

    public Item(string itemName, Sprite icon, int quantity, ItemType type)
    {
        ItemName = itemName;
        Icon = icon;
        Quantity = quantity;
        Type = type;
    }
}
