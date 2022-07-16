using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tools/Card Data")]
public class Cards : ScriptableObject
{
    public int Damage;
    public DamageMode _DamageMode;
    public int NumberOfDiceRequired;
    [SerializeField]
    public List<CardDice> NumberRequired = new List<CardDice>();
    public DamageType _DamageType;
    public string Name;
    public string Description;
}

[System.Serializable]
public class CardDice
{
    public int Number;
    public DiceModesEnum Mode;

}

public enum DiceModesEnum
{
    Exact,
    MoreOrEqual,
    LessOrEqual
}

public enum DamageType
{
    Damage,
    Defense
}
public enum DamageMode
{
    ExactNumber,
    DiceTotal
}