using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu _UIMainMenu;
    [SerializeField] private UIStatus _UIStatus;
    [SerializeField] private UIInventory _UIInventory;
    [SerializeField] private Character _Character;

    public UIMainMenu MainMenu => _UIMainMenu;
    public UIStatus Status => _UIStatus;
    public UIInventory Inventory => _UIInventory;
    
    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        ShowMainMenu();
        UpdateUI();
    }

    public void ShowMainMenu()
    {
        MainMenu.Show();
        Status.Hide();
        Inventory.Hide();        
    }
    public void ShowState()
    {
        Status.Show();
        Inventory.Hide();
    }
    public void ShowInventory()
    {
        Status.Hide();
        Inventory.Show();
    }

    public void UpdateUI()
    {
        _UIMainMenu.CharacterInfo(_Character);
        _UIStatus.StatusInfo(_Character);
    }
}
