using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            UIControl.Instance.SetScore(); // singleton object called;
            Debug.Log("Player touched");
        }
    }

}
