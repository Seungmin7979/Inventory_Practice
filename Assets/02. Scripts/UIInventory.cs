using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inventoryCountText;
    [SerializeField] private Button backButton;

    [SerializeField] private UISlot uiSlot;
    [SerializeField] private Transform slotParent;

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        for (int i = 0; i < 10; i++)
        {
            UISlot newslot = Instantiate(uiSlot, slotParent);

            slots.Add(newslot);
        }
    }

}
