using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dog : Pet
{
    int barkingLevel;

    //getter
    public int GetBarkingLevel() { return barkingLevel; }
    //setter
    public void SetBarkingLevel(int NewBarkingLevel)
    { barkingLevel = NewBarkingLevel; }

    public int calculateHumanYears()
    { return GetAge() * 7; }

    //the new keyword means we are rewriting a method that already exists in the parent class
    public new string GetInfo()
    {
        return base.GetInfo() + "\nBarking Level: " + barkingLevel;
    }
}

