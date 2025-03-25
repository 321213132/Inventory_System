using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private UIMainMenu _UIMainMenu;
    [SerializeField] private UIStatus _UIStatus;
    [SerializeField] private UIInventory _UIInventory;

    public UIMainMenu MainMenu => _UIMainMenu;
    public UIStatus Status => _UIStatus;
    public UIInventory Inventory => _UIInventory;
    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
        Character player = GameManager.Instance.player;
        if (player == null) return;

        _UIMainMenu.CharacterInfo(player);
        _UIStatus.CharacterInfo(player);
        _UIInventory.CharacterInfo(player);

    }
}
