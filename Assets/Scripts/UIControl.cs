using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IntermediateScripting; // when we put PlayerController in a namespace we can access with this way.

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

        // TERNARY OPERATOR: If condition is true then do expression 1, else do expression 2
        //(condition) ? expression_1 : expression_2; 
        // we sholud assign the result to something
        int i = goldScore > 0 ? (int)5 : (int)4;
        bool b = goldScore == 0 ? true : false;

    }
   
}
