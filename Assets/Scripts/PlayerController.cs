using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed =3;
    public float rotationSpeed =3;   



    private void Update()
    {
        //move player
        float horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontalInput, 0, verticalInput);
    }

}
