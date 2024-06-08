using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneUIController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    public static MainSceneUIController Instance;

    private int scoreCount;
    public int ScoreCount
    {
        get { return scoreCount; }
        set { 
            scoreCount = value; 
            scoreText.text = scoreCount.ToString();
        }
    }

    void Awake()
    {
        Instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //playerName.text = PlayerPrefs.GetString("player_name");
    }

    public void CollectFlower() {

    }
}
