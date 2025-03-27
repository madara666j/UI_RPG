using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    public override void ApplyEffect(Character character)
    {
        // Implement bow-specific logic, e.g., shooting arrows or dealing damage
        Debug.Log("Bow effect applied to " + character.name);
    }
}
