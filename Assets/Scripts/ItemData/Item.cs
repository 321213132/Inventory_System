using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable, //�Һ���
    Equipment,  //�����
    Material    //���
}

[CreateAssetMenu(fileName = "Itme", menuName = "New Item")]
public class Item : ScriptableObject
{
    public string ItemName; //������ �̸�
    public Sprite Icon; //������ ������
    public int Quantity; //����
    public ItemType Type; //������ Ÿ��
    public bool IsEquipped = false;

    public Item(string itemName, Sprite icon, int quantity, ItemType type)
    {
        ItemName = itemName;
        Icon = icon;
        Quantity = quantity;
        Type = type;
    }
}
