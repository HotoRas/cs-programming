namespace League;

public class Game
{
    Character a, b, c, user;
    public Game()
    {
        a = b = c = user = Character.Unset;
        Init();
    }
    void Init()
    {
        a = new HumanChampion("dummy1", 324, 600, 20, 15, "Human");
        b = new BeastChampion("beast1", 418, 0, 42, 34, "Beast");
        c = new HumanChampion("human1", 260, 180, 25, 35, "Magician");
        user = GetChamp();
    }
    Champion GetChamp()
    {
        string name;
        do
        {
            Console.Write("Name? ");
            name = Console.ReadLine();
        } while (name != null);

        int HP;
        do
        {
            Console.Write("HP? ");
        } while (!int.TryParse(Console.ReadLine(), out HP));

        int Mana;
        do
        {
            Console.Write("Mana? ");
        } while (!int.TryParse(Console.ReadLine(), out Mana));

        int Attack;
        do
        {
            Console.Write("Attack? ");
        } while (!int.TryParse(Console.ReadLine(), out Attack));

        int Defence;
        do
        {
            Console.Write("Defence? ");
        } while (!int.TryParse(Console.ReadLine(), out Defence));

        int MagicDef;
        do
        {
            Console.Write("Magical Defence? ");
        } while (!int.TryParse(Console.ReadLine(), out MagicDef));

        Champion chara = Champion.Unset;
        Character.Stats stat = new();
        stat.Init(HP, Mana, Attack, Defence, magicdefence: MagicDef);
        chara.SetDetails("user", stat, new Character.Stats(), "Human");
        return chara;
    }
}

public class Character
{
    public static Character Unset
    {
        get
        {
            return new Character("", 0, 0, 0, 0, "");
        }
    }
    public string Name = string.Empty;
    public int Level = 1;
    public struct Stats
    {
        public int HP, Mana, Attack;
        public float AttackSpd;
        public int /*HPHeal, ManaHeal,*/ Defence;
        public int MagicDef, Speed, AttackRadius;
        public void Init(int hp, int mana, int attack, int defence,
        float attackspeed = 0,// int hpheal = 0, int manaheal = 0,
        int magicdefence = 0, int speed = 0, int attackradius = 0)
        {
            HP = hp; Mana = mana; Attack = attack; Defence = defence;
            AttackSpd = attackspeed;// HPHeal = hpheal; ManaHeal = manaheal;
            MagicDef = magicdefence; Speed = speed; AttackRadius = attackradius;
        }
    }
    public Stats BaseStats;
    public Stats StatsPerLevel;
    protected int HP, Mana;
    public string Type = string.Empty;
    public Weapon weapon;
    public virtual void Skill1(Character chara)
    {
        if (Mana < 10) return;
        Mana -= 10;
        chara.MagicDealt(BaseStats.Attack + StatsPerLevel.Attack * (Level - 1) + weapon.getAttack(true));
    }
    public virtual void Attack(Character chara)
    {
        chara.Dealt(BaseStats.Attack + StatsPerLevel.Attack * (Level - 1) + weapon.getAttack(false));
    }
    public void Dealt(int damage)
    {
        HP -= (int)(damage * (2 / (BaseStats.Defence + (double)(StatsPerLevel.Defence * (Level - 1)))));
    }
    public void MagicDealt(int damage)
    {
        HP -= (int)(damage * (2 / (BaseStats.MagicDef + (double)(StatsPerLevel.MagicDef * (Level - 1)))));
    }
    public Character(string name, int HP, int Mana, int Attack, int Defence, string Type = "")
    {
        Name = name;
        BaseStats.Init(HP, Mana, Attack, Defence);
        this.HP = HP; this.Mana = Mana; this.Type = Type;
        Level = 1; weapon = Weapon.None;
    }
    public void SetDetails(string name, Stats basestats, Stats perLevel, string Type = "")
    {
        Name = name;
        BaseStats = basestats; StatsPerLevel = perLevel;
        Level = 1; this.Type = Type;
        HP = basestats.HP; Mana = basestats.Mana; weapon = Weapon.None;
    }
}
public class Weapon
{
    readonly public string Name;
    int Attack;
    int Defence;
    int MagicAttack;
    bool isMagic;
    bool isUpgraded = false;

    public Weapon(string name, int attack, int defence, bool isMagic)
    {
        Name = name;
        if (isMagic) { Attack = 0; MagicAttack = attack; }
        else { Attack = attack; MagicAttack = 0; }
        Defence = defence;
        this.isMagic = isMagic;
    }
    public static Weapon None
    {
        get
        {
            return new Weapon("none", 0, 0, false);
        }
    }
    public int getAttack(bool isMagic) => isMagic ? (this.isMagic ? MagicAttack : Attack) : (this.isMagic ? Attack : MagicAttack);
    public void Upgrade()
    {
        if (isUpgraded)
        {
            Console.WriteLine("The weapon is already upgraded!");
            return;
        }
        Attack += (int)(Attack * .1);
        Defence += (int)(Defence * .1);
        MagicAttack += (int)(MagicAttack * .1);
    }
}
public class Champion(string name, int HP, int Mana, int Attack, int Defence, string Type = "") : Character(name, HP, Mana, Attack, Defence, Type)
{
    public new static Champion Unset
    {
        get
        {
            return new Champion("", 0, 0, 0, 0, "");
        }
    }
    protected int Skill1_ManaUse = 30;
    protected double Skill1_Multiplier = 1.2;
    public override void Skill1(Character chara)
    {
        if (Mana < Skill1_ManaUse)
        {
            Console.WriteLine("Not enough mana!"); return;
        }
        Mana -= Skill1_ManaUse;
        chara.MagicDealt((int)((BaseStats.Attack + StatsPerLevel.Attack * (Level - 1) + weapon.getAttack(true)) * Skill1_Multiplier));
    }
    public void GetWeapon(Weapon w)
    {
        weapon = w;
    }
}

public class HumanChampion(string name, int HP, int Mana, int Attack, int Defence, string Type = "") : Champion(name, HP, Mana, Attack, Defence, Type)
{
    public override void Skill1(Character chara)
    {
        if (Mana < 40)
        {
            Console.WriteLine("Not enough mana!"); return;
        }
        Mana -= 40;
        chara.MagicDealt((int)((BaseStats.Attack + StatsPerLevel.Attack * (Level - 1) + weapon.getAttack(true)) * 1.4));
    }
}

public class BeastChampion(string name, int HP, int Mana, int Attack, int Defence, string Type = "") : Champion(name, HP, Mana, Attack, Defence, Type)
{
    public override void Skill1(Character chara)
    {
        chara.MagicDealt((int)((BaseStats.Attack + StatsPerLevel.Attack * (Level - 1) + weapon.getAttack(false)) * 1.4));
    }
}