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

    public void OpenMainMenu()
    {
        buttons.SetActive(false);
    }

    public void OpenStatus()
    {
        
    }

    public void OpenInventory()
    {

    }
}
