using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bye;
    public string Name = "Guts";
    public int Age = 21;
    public string Race = "Doesn't Know";
    public int PhysicalDamage = 1000;
    public int Armor = 500;
    public int MagicDamage = 75;
    public int MagicResistance = 200;
    public float Speed = 50.5f;
    public void Button1press()
    {
        bye.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResistance: " + MagicResistance + " \nSpeed: " + Speed;
    }
}