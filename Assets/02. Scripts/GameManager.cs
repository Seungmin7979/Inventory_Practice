using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Character Player { get; private set; }

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
            return;
        }
    }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        Player = new Character("½Å½Â¹Î", 10, 20000, 35, 40, 100, 25);

        UIManager.Instance.UIMainMenu.CharacterInfo(Player);
        UIManager.Instance.UIStatus.CharacterStatusInfo(Player);
    }
}
