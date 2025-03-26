using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI experienceText;
    [SerializeField] private TextMeshProUGUI goldText;

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.ShowMainMenu();
    }

    public void OpenStatus()
    {
        UIManager.Instance.ShowState();
    }

    public void OpenInventory()
    {
        UIManager.Instance.ShowInventory();
    }

    public void CharacterInfo(Character character)
    {
        if (character == null) return;

        nameText.text = $"{character.Name}";
        levelText.text = $"Lv. {character.Level}";
        goldText.text = $"{character.Gold}";
    }
}
