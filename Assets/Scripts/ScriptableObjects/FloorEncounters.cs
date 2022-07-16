using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tools/Floor Data")]
public class FloorEncounters : ScriptableObject
{
    public List<EncounterClass> Encounters;
    public string FloorName;
}

[System.Serializable]
public class EncounterClass
{
    public int Rarity;
    public Encounters _Encounters;
    public EncounterType _EncounterType;
}

public enum EncounterType
{
    Combat,
    Mystery,
    Boss,
    Elite,
    Health
}