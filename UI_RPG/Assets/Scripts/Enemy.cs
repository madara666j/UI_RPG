using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] internal int aggression = 10;

    public override int Attack()
    {
        return aggression;
    }
}
