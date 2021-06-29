using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Observer Pattern Example
public class PlayerController : MonoBehaviour  // Subject for Observer Pattern 
{
    public float speed =3;
    public float rotationSpeed =3;
    public int _goldScore;
    public int GoldScore { get { return _goldScore;} set { _goldScore = value; } }  // Property

    public static event Action<int> OnGoldCollected; // Action

    private void Awake()
    {
        _goldScore = 0;
    }

    private void Update()
    {
        MovePlayer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gold"))
        {
            _goldScore++; // Increase gold count
            Debug.Log("Player touched");
            other.transform.position = new Vector3(UnityEngine.Random.Range(-5f, 5f), 1f, UnityEngine.Random.Range(-5f,5f));
            // UIControl.Instance.SetScore(); // singleton object diirect calling

            OnGoldCollected?.Invoke(_goldScore);  // Calling Event
        }
    }

    void MovePlayer()
    {
        //move player
        float horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontalInput, 0, verticalInput);
    }

}
