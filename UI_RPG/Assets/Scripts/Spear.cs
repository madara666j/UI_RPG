using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
    public override void ApplyEffect(Character character)
    {
        Debug.Log("Spear pierces deeply!");
    }
}
