using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    Dog d; //Dog is a data type
    Bird b; //Bird is a data type

    // Start is called before the first frame update
    void Start()
    {
        d= new Dog();
        d.name = "Ginger";
        d.age = 1;
        d.happinessLevel = 5;
        d.energyLevel = 5;
        d.barkingLevel = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
