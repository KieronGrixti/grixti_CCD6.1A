using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : Pet
{
    int wingSpan;
    //getter
    public int GetWingSpan() { return wingSpan; }
    //setter
    public void SetWingSpan(int NewWingSpan)
    { wingSpan = NewWingSpan; }
    public int calculateHumanYears()
    { return GetAge() * 8; }

    //the new keyword means we are rewriting a method that already exists in the parent class
    public new string GetInfo()
    {
        return base.GetInfo() + "\nWingspan: " + wingSpan;
    }
}
