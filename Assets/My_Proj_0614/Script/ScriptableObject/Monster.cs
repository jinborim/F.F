using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Monster", menuName = "New Monster/monster")]
public class Monster : ScriptableObject
{
    public int damage;
    public int M_health;
    public Monster_Type monster_type;

    public enum Monster_Type
    {
        normal,
        middle,
        boss

    }
}

