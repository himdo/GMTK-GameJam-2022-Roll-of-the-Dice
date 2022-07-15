using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberGenerator
{
    public static int RoleDice(int sides)
    {
        return Random.Range(1, sides + 1);
    }
}
