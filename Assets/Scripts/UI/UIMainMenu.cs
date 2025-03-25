using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    [SerializeField] private Text nameText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text experienceText;
    [SerializeField] private Text goldText;

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
        UIManager.instance.ShowMainMenu();
    }

    public void OpenStatus()
    {
        UIManager.instance.ShowState();
    }

    public void OpenInventory()
    {
        UIManager.instance.ShowInventory();
    }

    public void CharacterInfo(Character character)
    {
        if (character == null) return;

        nameText.text = $"¿Ã∏ß : {character.name}";
        levelText.text = $"Lv. {character.Level}";
        goldText.text = $"{character.Gold}";
    }
}
