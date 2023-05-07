using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Entity", menuName = "Entity/Create new entity")]
public class EntityBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;

    [SerializeField] EntityType type1;
    [SerializeField] EntityType type2;

    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int deffance;
    [SerializeField] int spAttack;
    [SerializeField] int spDeffance;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    public string GetName()
    {
        return name;
    }

    public string Name { get { return name; } }
    public string Description { get { return description; } }

    public Sprite FrontSprite { get { return frontSprite; } }
    public EntityType Type1 { get { return type1; } }
    public EntityType Type2 { get { return type2; } }

    public int MaxHp { get { return maxHp; } }
    public int Attack { get { return attack; } }
    public int Deffance { get { return deffance; } }
    public int SpAttack { get { return spAttack; } }
    public int SpDeffance { get { return spDeffance; } }
    public int Speed { get { return speed; } }

    public List<LearnableMove> LearnableMoves { get { return learnableMoves; } }
}


[System.Serializable]
public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base { get { return moveBase; } }
    public int Level { get { return level; } }
}

public enum EntityType
{
    None,
    Normal,
    Boss,
    Special,
    //
    Fire,
    Water,
    Grass,
    Dark,
    Poison,
    Ghost,
    //
    Spirit,
    Virus
}

public class TypeChart
{
    // Kendi türüne daha az hasar //
    static float[][] chart =
    {
        //                       NORMAL  BOSS  SPEC  FIRE   WATER  GRAS  DARK  POIS  GHOST SPIR  VIRUS
        /* NORMAL  */ new float[] { 1f,  0.8f,  1f,   1f,    1f,    1f,   1f,   1f,   1f,   1f,   1f   },
        /* BOSS    */ new float[] { 1f,   1f,   1f,   1f,    1f,    1f,   1f,   1f,   1f,   1f,   1f   },
        /* SPECIAL */ new float[] { 1.2f, 1f,  0.75f, 1f,    1f,    1f,   1f,   1f,   1f,   1f,   1f   },
        /* FIRE    */ new float[] { 1f,  0.8f,  1f,  0.75f, 0.5f,   2f,   1f,   1f,   1f,   1f,   1f   },
        /* WATER   */ new float[] { 1f,  0.8f,  1f,   2f,   0.75f, 0.5f,  1f,   1f,   1f,   1f,   1f   },
        /* GRASS   */ new float[] { 1f,  0.8f,  1f,  0.5f,   2f,   0.75f, 1f,   1f,   1f,   1f,   1f   },
        /* DARK    */ new float[] { 1f,  0.8f,  1f,   1f,    1f,    1f,  0.75f, 1f,   1f,   1f,   1f   },
        /* POISON  */ new float[] { 1f,  0.8f,  1f,   1f,    1f,    2f,   1f,  0.75f, 1f,   1f,   1f   },
        /* GHOST   */ new float[] { 1f,   1f,   1f,   1f,    1f,    1f,   1f,   1f,  0.75f, 1f,   1f   },
        /* SPIRIT  */ new float[] { 1f,   1f,   1f,   1f,    1f,    1f,   1f,   1f,   1f,  0.75f, 1f   },
        /* VIRUS   */ new float[] { 1f,   2f,   1f,   1f,   1.2f,   1f,   1f,   1f,   1f,   1f,  0.75f },
    };

    static public float GetEffectiveness(EntityType attackType, EntityType defenseType)
    {
        if (attackType == EntityType.None || defenseType == EntityType.None)
            return 1;

        int row = (int)attackType - 1;
        int col = (int)defenseType - 1;

        return chart[row][col];
    }
}