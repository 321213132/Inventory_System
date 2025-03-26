using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private TextMeshProUGUI itemQuantity;

    private Item curentItem;

    public void SetItme(Item item)
    {
        curentItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if(curentItem != null)
        {
            itemIcon.sprite = curentItem.Icon;
            itemIcon.enabled = true;
            itemQuantity.text = curentItem.Quantity > 1 ? curentItem.Quantity.ToString() : "";
            itemQuantity.enabled = curentItem.Quantity > 1;
        }
        else
        {
            itemIcon.sprite = null;
            itemIcon.enabled = false;
            itemQuantity.text = "";
            itemQuantity.enabled = false;
        }
    }
}