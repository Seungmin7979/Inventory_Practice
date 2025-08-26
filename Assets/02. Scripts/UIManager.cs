using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
