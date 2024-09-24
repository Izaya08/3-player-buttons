using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Hi;
    public string Name = "Mr Maynard";
    public int Age = 21;
    public string Race = "Big Black Man";
    public int PhysicalDamage = 1000;
    public int Armor = 200;
    public int MagicDamage = 500;
    public int MagicResistance = 250;
    public float Speed = 100000.1f;

    public void Button2press()
    {
        Hi.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResistance: " + MagicResistance + " \nSpeed: " + Speed;
    }
}
