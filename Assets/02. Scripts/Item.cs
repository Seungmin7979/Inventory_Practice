using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName { get; private set; }
    public int addAtk { get; private set; }
    public int addDef { get; private set; }
    public int addHp { get; private set; }
    public int addCri { get; private set; }
    public bool isEquipped;

    public Item(string itemName, int addAtk, int addDef, int addHp, int addCri)
    {
        this.itemName = itemName;
        this.addAtk = addAtk;
        this.addDef = addDef;
        this.addHp = addHp;
        this.addCri = addCri;
        this.isEquipped = false;
    }
}

