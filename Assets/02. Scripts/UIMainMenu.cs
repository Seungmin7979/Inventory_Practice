using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Left")]
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI currentLv;
    [SerializeField] private Image lvBar;
    [SerializeField] private TextMeshProUGUI lvText;
    [SerializeField] private TextMeshProUGUI discription;

    [Header("Right")]
    [SerializeField] private TextMeshProUGUI gold;
    [SerializeField] private GameObject buttons;
    [SerializeField] private Button status;
    [SerializeField] private Button inventory;

    private void Start()
    {
        status.onClick.AddListener(OpenStatus);
        inventory.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        buttons.SetActive(true);
    }

    public void OpenStatus()
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
        buttons.SetActive(false);
    }

    public void OpenInventory()
    {
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
        buttons.SetActive(false);
    }

    public void CharacterInfo(Character character)
    {
        name.text = character.name;
        currentLv.text = character.lv.ToString();
        gold.text = character.gold.ToString("N0");
    }
}
