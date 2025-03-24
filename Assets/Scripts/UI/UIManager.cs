using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private UIMainMenu _MainMenu;
    [SerializeField] private UIStatus _Status;
    [SerializeField] private UIInventory _Inventory;

    public UIMainMenu MainMenu => _MainMenu;
    public UIStatus Status => _Status;
    public UIInventory Inventory => _Inventory;
    
    private GameObject currentPanel;

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

}
