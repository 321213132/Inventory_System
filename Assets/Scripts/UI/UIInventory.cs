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
    [SerializeField] private TextMeshProUGUI experienceText;
    [SerializeField] private TextMeshProUGUI goldText;
    private void Start()
    {
        //뒤로가기 버튼
        backButton.onClick.AddListener(UIManager.Instance.ShowMainMenu);
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

        nameText.text = $"{character.name}";
        levelText.text = $"Lv. {character.Level}";
        goldText.text = $"{character.Gold}";
    }
}
