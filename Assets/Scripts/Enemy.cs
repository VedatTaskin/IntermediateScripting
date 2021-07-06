using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Text typeText = null;
    [SerializeField] private EnemyType enemyType = null;

    // Start is called before the first frame update
    void Start()
    { 
        GetComponent<Renderer>().material.color = enemyType.enemyColor;
        transform.localScale = enemyType.enemyScale;
        typeText.text = enemyType.enemyTypeName;         

    }


}
