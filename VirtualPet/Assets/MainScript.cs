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
    public Button PlayButton, SleepButton, FeedButton, PlayButtonBird, SleepButtonBird, FeedButtonBird;

    // Start is called before the first frame update
    void Start()
    {
        d = new Dog();
        d.SetName("Ginger");
        d.SetAge(1);
        d.SetHappinessLevel(5);
        d.SetEnergyLevel(5);
        d.SetBarkingLevel(5);

        b = new Bird();
        b.SetName("Skye");
        b.SetAge(3);
        b.SetHappinessLevel(5);
        b.SetEnergyLevel(5);
        b.SetWingSpan(15);

        PlayButton.GetComponent<Button>().onClick.AddListener(PlayEvent);
        PlayButtonBird.GetComponent<Button>().onClick.AddListener(PlayEventBird);
        FeedButton.GetComponent<Button>().onClick.AddListener(FeedEvent);
        FeedButtonBird.GetComponent<Button>().onClick.AddListener(FeedEventBird);
        SleepButton.GetComponent<Button>().onClick.AddListener(SleepEvent);
        SleepButtonBird.GetComponent<Button>().onClick.AddListener(SleepEventBird);
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

    // Update is called once per frame
    void Update()
    {
        DogText.text = d.GetInfo();
        BirdText.text = b.GetInfo();
    }
}
