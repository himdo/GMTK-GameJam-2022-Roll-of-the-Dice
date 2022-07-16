using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tools/Encounter Data")]
public class Encounters : ScriptableObject
{
    public List<Enemies> Enemies = new List<Enemies>();
}
