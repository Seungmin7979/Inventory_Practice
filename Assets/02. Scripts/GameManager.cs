using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Character player { get; private set; }

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
        player = new Character("신승민", 10, 20000, 35, 40, 100, 25);

        UIManager.Instance.UIMainMenu.CharacterInfo(player);
        UIManager.Instance.UIStatus.CharacterStatusInfo(player);

        Item sword = new Item("칼", 5, 0, 0, 2);
        Item shield= new Item("방패", 0, 5, 10, 0);
        Item shabbyClothes= new Item("허름한 옷", 0, 2, 5, 0);

        player.Additem(sword);
        player.Additem(shield);
        player.Additem(shabbyClothes);
        // 아이템 불변하는 정보 // 보유하고 있는 데이터 나누기 (itemlist) id생성 필요 // 슬롯에 어떤 아이템 데이터를 보여주고 있는지 표시
    }
}
