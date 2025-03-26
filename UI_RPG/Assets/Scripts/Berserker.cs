using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Enemy
{
    [SerializeField] private int agressionGain = 5;
    public override int Attack()
    {
        aggression += agressionGain;
        return agressionGain / 10;
    }
}
