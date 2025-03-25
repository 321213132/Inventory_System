using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI quantity;

    public void SetItme(Sprite itemIcon, string name, int count)
    {
        icon.sprite = itemIcon;
        itemName.text = name;
        quantity.text = count > 1 ? count.ToString() : "";
    }

    public void RefreshUI()
    {

    }
}
