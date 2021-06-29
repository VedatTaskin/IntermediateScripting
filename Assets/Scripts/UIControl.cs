using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField] Text scoreText;


#region Singleton
    //Singleton Pattern
    private static UIControl instance;
    public static UIControl Instance { get => instance; set => instance = value; }
     

    private void Awake()
    {
        if (instance == null)
            instance = this;        
    }
#endregion

    private void Start()
    {
        //When action occurs "OnGoldCollected" sends "integer" message, so receiving function (SetScore) has to take an integer parameter 
        PlayerController.OnGoldCollected += SetScore; // OBSERVING
    }

    public void SetScore(int goldScore)
    {
        goldScore++;
        scoreText.text ="Score: " + goldScore.ToString();
    }
   
}
