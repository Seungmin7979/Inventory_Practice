[System.Serializable]
public class Character 
{
    public string name { get; private set; }
    public int lv { get; private set; }
    public int gold { get; private set; }
    public int atk { get; private set; }
    public int def { get; private set; }
    public int hp { get; private set; }
    public int cri { get; private set; }

    public Character (string name, int lv, int gold, int atk, int def, int hp, int cri) 
    {
        this.name = name;
        this.lv = lv;
        this.gold = gold;
        this.atk = atk;
        this.def = def;
        this.hp = hp;
        this.cri = cri;
    }
}