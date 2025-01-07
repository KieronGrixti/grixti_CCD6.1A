using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text txtScore;
    public Text txtHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = GameData.Score + ""; //needs to be string
        txtHealth.text = GameData.Health + "";
    }
}
