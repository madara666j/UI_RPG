using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private string charName;
    private bool shieldActive = false;
    private float shieldBlockChance = 0.3f;

    [SerializeField] private List<Weapon> weapons = new List<Weapon>(); // 🔥 Fix: Added weapons list
    private int currentWeaponIndex = 0;

    public string CharName => charName;

    public void ToggleShield()
    {
        shieldActive = !shieldActive;
        Debug.Log(shieldActive ? "Shield activated!" : "Shield deactivated!");
    }

    // 🔥 NEW FUNCTION: Switch to the next weapon in the list
    public void SwitchWeapon()
    {
        if (weapons.Count == 0)
        {
            Debug.Log("No weapons available!");
            return;
        }

        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Count;  // Cycle through weapons
        activeWeapon = weapons[currentWeaponIndex];  // Set the new weapon

        Debug.Log("Switched to: " + activeWeapon.name);
    }
}

