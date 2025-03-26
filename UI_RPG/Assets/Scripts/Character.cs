using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] private Weapon activeWeapon;

    public virtual int Attack()
    {
        Debug.Log("character attack");
        return activeWeapon.GetDamage();
    }

    public Weapon ActiveWeapon
    {
        get { return activeWeapon;}
    }

    public void GetHit(int damage)
    {
        health -= damage;
        Debug.Log(name + "'s current health: " + health);
    }
    
    public void GetHit(Weapon weapon)
    {
        health -= weapon.GetDamage();
        Debug.Log("Got hit by: " + weapon.name);
        Debug.Log(name + " current health: " + health);
    }
}
