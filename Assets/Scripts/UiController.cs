using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] Button startButton;
    //[SerializeField] InputField inputName;
    
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(() =>{
            //PlayerPrefs.SetString("player_name", inputName.text);
            SceneManager.LoadScene("MainScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
