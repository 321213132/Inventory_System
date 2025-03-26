using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;

    [SerializeField] private UISlot slotprefab;//인벤토리 슬롯 프리펩
    [SerializeField] private Transform slotParent;

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        //뒤로가기 버튼
        backButton.onClick.AddListener(UIManager.Instance.ShowMainMenu);
        InitInventoryUI(21);
    }
    public void InitInventoryUI(int slotCount)
    {
        foreach (var slot in slots)
        {
            Destroy(slot.gameObject);
        }


        for (int i = 0;  i < slotCount; i++)
        {
            UISlot newslot = Instantiate(slotprefab, slotParent);
            slots.Add(newslot);
        }

        SlotWithItems();
    }

    public void SlotWithItems()
    {
        List<Item> inventoryItems = GameManager.Instance.player.inventory;

        for(int i = 0;i < inventoryItems.Count;i++)
        {
            if(i< slots.Count)
            {
                slots[i].SetItme(inventoryItems[i]);
            }
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
    public void CharacterInfo(Character character)
    {
        if (character == null) return;

        nameText.text = $"{character.Name}";
        levelText.text = $"Lv. {character.Level}";
        goldText.text = $"{character.Gold}";
    }
}
