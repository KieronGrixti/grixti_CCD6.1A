using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject balloonPrefab;
    int score = 0;
    public Text txtScore;
    public Button btnSave;

    //GUARANTEE that only 1 instance of Game Manager exists at a time - SINGLETON
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void IncrementScore()
    {
        score++;
        txtScore.text = score + "";
    }

    //method to spawn the balloons
    IEnumerator SpawnBalloons()
    {
        while (true)
        {
            Vector3 balloonPos = new Vector3 (0, balloonPrefab.transform.position.y , 0);
            Instantiate(balloonPrefab, balloonPos, Quaternion.identity);
            yield return new WaitForSeconds(2); //wait 2 seconds
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //score = PlayerPrefs.GetInt("score"); //Loading

        //Loading from file
        if (File.Exists(Application.dataPath + "/ScoreSave.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.dataPath + "/ScoreSave.dat", FileMode.Open);
            score = (int)bf.Deserialize(file);
            file.Close();
        }

        txtScore.text = score + "";

        btnSave.onClick.AddListener(SaveScore);
        StartCoroutine(SpawnBalloons());
    }

    void SaveScore()
    {
        PlayerPrefs.SetInt("score", score); //Saving

        //Saving in a binary file
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.dataPath + "/ScoreSave.dat", FileMode.OpenOrCreate);

        bf.Serialize(file, score);
        file.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
