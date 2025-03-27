using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Enemy
{
    public override int Attack()
    {
        Debug.Log("Mage casts a fireball!");
        return Random.Range(10, 25);
    }
}
