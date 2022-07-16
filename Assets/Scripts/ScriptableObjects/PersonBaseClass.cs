using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonBaseClass : ScriptableObject
{
    public int MaxHealth;
    public int CurrentHealth;
    public int CurrentSheilds;
    public List<Cards> Deck;
    public int StartingNumberOfDice;
    public int CurrentNumberOfDice;
    public string Name;
}
