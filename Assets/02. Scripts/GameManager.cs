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
        Player = new Character("�Ž¹�", 10, 20000, 35, 40, 100, 25);

        UIManager.Instance.UIMainMenu.CharacterInfo(Player);
        UIManager.Instance.UIStatus.CharacterStatusInfo(Player);

        Item sword = new Item("Į", 5, 0, 0, 2);
        Item shield= new Item("����", 0, 5, 10, 0);
        Item shabbyClothes= new Item("�㸧�� ��", 0, 2, 5, 0);
    }
}
