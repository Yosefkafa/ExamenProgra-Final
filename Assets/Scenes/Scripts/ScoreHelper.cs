using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScoreHelper
{
    public static int ModifyValue(int id, int value)
    {
        return value+(id + 1);
    }
}
