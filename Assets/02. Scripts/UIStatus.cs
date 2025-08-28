using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI atkValue;
    [SerializeField] private TextMeshProUGUI defValue;
    [SerializeField] private TextMeshProUGUI hpValue;
    [SerializeField] private TextMeshProUGUI criValue;
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject buttons;

    private void Start()
    {
        backButton.onClick.AddListener(BackButton);
    }

    public void CharacterStatusInfo(Character character)
    {
        atkValue.text = character.atk.ToString();
        defValue.text = character.def.ToString();
        hpValue.text = character.hp.ToString();
        criValue.text = character.cri.ToString();
    }

    public void BackButton()
    {
        gameObject.SetActive(false);
        buttons.SetActive(true);
    }
}
