using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inventoryCountText;
    [SerializeField] private GameObject buttons;
    [SerializeField] private Button backButton;

    [SerializeField] private UISlot uiSlot;
    [SerializeField] private Transform slotParent;

    private List<UISlot> slots = new List<UISlot>();
    public Character character { get { return GameManager.Instance.player; } }

    private IEnumerator Start()
    {
        backButton.onClick.AddListener(BackButton);

        yield return new WaitUntil(() => character.inventory.Count > 0);

        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        for (int i = 0; i < character.inventory.Count; i++)
        {
            UISlot newslot = Instantiate(uiSlot, slotParent);
            newslot.SetItem(character.inventory[i]);
            slots.Add(newslot);
            Debug.Log("����");
        }
    }


    public void BackButton()
    {
        gameObject.SetActive(false);
        buttons.SetActive(true);
    }
}
