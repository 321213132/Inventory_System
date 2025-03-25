using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu _UIMainMenu;
    [SerializeField] private UIStatus _UIStatus;
    [SerializeField] private UIInventory _UIInventory;

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
        MainMenu.Hide();
        Status.Show();
        Inventory.Hide();
    }
    public void ShowInventory()
    {
        MainMenu.Hide();
        Status.Hide();
        Inventory.Show();
    }

    public void UpdateUI()
    {
        //UIMainMenu.CharacterInfo();
    }
}
