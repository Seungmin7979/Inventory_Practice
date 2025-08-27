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

    public void CharacterStatusInfo(Character character)
    {
        atkValue.text = character.atk.ToString();
        defValue.text = character.def.ToString();
        hpValue.text = character.hp.ToString();
        criValue.text = character.cri.ToString();
    }
}
