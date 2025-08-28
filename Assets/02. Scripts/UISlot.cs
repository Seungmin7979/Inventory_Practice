using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private GameObject equippedMark;
    [SerializeField] private Button equippedButton;

    private Item currentItem;

    private void Start()
    {
        equippedButton.onClick.AddListener(IsEquipped);
    }

    public void SetItem(Item item)
    {
        currentItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (currentItem != null)
        {
            equippedMark.SetActive(currentItem.isEquipped);
        }

        else
        {
            equippedMark.SetActive(false);
        }
    }

    public void IsEquipped()
    {
        if (currentItem == null) return;

        Character player = GameManager.Instance.player;

        if (currentItem.isEquipped)
            player.UnEquip(currentItem);
        else
            player.Equip(currentItem);

        RefreshUI();
        UIManager.Instance.UIStatus.CharacterStatusInfo(player);
    }
}
