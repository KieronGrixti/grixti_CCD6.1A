using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dog : Pet
{
    int barkingLevel;

    public Dog() { } //paramaterless
    public Dog(string name, int age, int happinessLevel, int energyLevel,int barkingLevel) : base(name,age,happinessLevel,energyLevel)
    {
        this.barkingLevel = barkingLevel;
    }

    //getter
    public int GetBarkingLevel() { return barkingLevel; }
    //setter
    public void SetBarkingLevel(int NewBarkingLevel)
    { barkingLevel = NewBarkingLevel; }

    public override void play()
    {
        SetHappinessLevel(GetHappinessLevel()+2);
        SetEnergyLevel(GetEnergyLevel()-1);
    }

    public int calculateHumanYears()
    { return GetAge() * 7; }

    //the new keyword means we are rewriting a method that already exists in the parent class
    public new string GetInfo()
    {
        return base.GetInfo() + "\nBarking Level: " + barkingLevel;
    }
}

