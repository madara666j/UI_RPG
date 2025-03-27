using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    // Override the ApplyEffect method (e.g., dealing damage to enemies)
    public override void ApplyEffect(Character character)
    {
        // Implement sword-specific logic, e.g., apply damage
        Debug.Log("Sword effect applied to " + character.name);
    }
}
