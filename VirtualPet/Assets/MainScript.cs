using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    Dog d; //Dog is a data type
    Bird b; //Bird is a data type
    public TextMeshProUGUI DogText;
    public TextMeshProUGUI BirdText;
    public Button PlayButton, SleepButton, FeedButton, PlayButtonBird, SleepButtonBird, FeedButtonBird,PlayWithAllBtn;
    List<Pet> pets = new List<Pet>();

    // Start is called before the first frame update
    void Start()
    {
        d = new Dog("Ginger",1,5,5,5);
        pets.Add(d); //Add new dog to the list

        //d.SetName("Ginger");
        //d.SetAge(1);
        //d.SetHappinessLevel(5);
        //d.SetEnergyLevel(5);
        //d.SetBarkingLevel(5);

        b = new Bird("Skye",3,5,5,15);
        pets.Add(b); //add new bird to the list

        PlayButton.GetComponent<Button>().onClick.AddListener(PlayEvent);
        PlayButtonBird.GetComponent<Button>().onClick.AddListener(PlayEventBird);
        FeedButton.GetComponent<Button>().onClick.AddListener(FeedEvent);
        FeedButtonBird.GetComponent<Button>().onClick.AddListener(FeedEventBird);
        SleepButton.GetComponent<Button>().onClick.AddListener(SleepEvent);
        SleepButtonBird.GetComponent<Button>().onClick.AddListener(SleepEventBird);

        PlayWithAllBtn.GetComponent<Button>().onClick.AddListener(playAllEvent);
    }
    void PlayEvent()
    {
        d.play();
    }

    void SleepEvent()
    {
        d.sleep();
    }

    void FeedEvent()
    {
        d.feed();
    }

    void PlayEventBird()
    {
        b.play();
    }

    void SleepEventBird()
    {
        b.sleep();
    }

    void FeedEventBird()
    {
        b.feed();
    }

    void playAllEvent()
    {
        foreach (Pet pet in pets)
        {
            pet.play(); //polymorphism
        }
    }

    // Update is called once per frame
    void Update()
    {
        DogText.text = d.GetInfo();
        BirdText.text = b.GetInfo();
    }
}
