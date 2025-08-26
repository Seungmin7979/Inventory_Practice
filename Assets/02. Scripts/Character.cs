[System.Serializable]
public class Character
{
    public string name;
    public int lv;
    public int gold;
    public int atk;
    public int def;
    public int hp;
    public int cri;

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