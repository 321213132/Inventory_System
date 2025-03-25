using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button backButton;

    [SerializeField] private TextMeshProUGUI AtkText;
    [SerializeField] private TextMeshProUGUI HPText;
    [SerializeField] private TextMeshProUGUI DEFText;
    [SerializeField] private TextMeshProUGUI SpeedText;

    [SerializeField] private TextMeshProUGUI StatusText;
    private void Start()
    {
        //뒤로가기 버튼
        backButton.onClick.AddListener(UIManager.instance.ShowMainMenu);
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void StatusInfo(Character character)
    {
        if (character == null) return;

        StatusText.text = $"HP\n{character.MaxHealth}\nATK\n{character.AttackPower}\nDEF\n{character.Defense}\nSpeed\n{character.Speed}";
    }
}
