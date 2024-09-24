using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hello;
    public string Name = "Enzo";
    public int Age = 69;
    public string Race = "African-American";
    public int PhysicalDamage = 1;
    public int Armor = 5;
    public int MagicDamage = 2;
    public int MagicResistance = 4;
    public float Speed = 0.1f;

    public void Button1press()
    {
        hello.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResistance: " + MagicResistance + " \nSpeed: " + Speed;
    }
}