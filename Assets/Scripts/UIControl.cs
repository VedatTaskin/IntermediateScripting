using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{

    //Singleton Pattern
    private static UIControl instance;
    public static UIControl Instance { get => instance; set => instance = value; }

 
    [SerializeField] Text scoreText;
    private int score=0;



    private void Awake()
    {
        if (instance == null)
            instance = this;        
    }

    public void SetScore()
    {
        score++;
        scoreText.text ="Score: " + score.ToString();
    }
   
}
