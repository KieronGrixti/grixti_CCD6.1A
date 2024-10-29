using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet
{
    public string name;
    public int age;
    public int happinessLevel;
    public int energyLevel;

    public void feed()
    {
        energyLevel += 1;
        happinessLevel += 1;
    }

    public void play()
    {
        happinessLevel += 1;
        energyLevel -= 1;
    }

    public void sleep()
    {
        energyLevel += 1;
    }
}
