using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button backButton;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI experienceText;
    [SerializeField] private TextMeshProUGUI goldText;

    [SerializeField] private TextMeshProUGUI StatusText;
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
        StatusText.text = $"HP\n{character.MaxHealth}\nATK\n{character.AttackPower}\nDEF\n{character.Defense}\nSpeed\n{character.Speed}";

    }
}
