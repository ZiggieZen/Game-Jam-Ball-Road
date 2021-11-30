using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingball : MonoBehaviour
{
    private float turnSpeed = 25.0f; private float horiztontalInput; private float forwardInput; public GameObject player; private float speed = 5.0f; // Start is called before the first frame update void Start() {



// Update is called once per frame

void Update()
{
    //Move the Ball forward
    horiztontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");
    // Moves the ball forward based on vertical input
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    // Rotates the ball based on horizontal input
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horiztontalInput);
}
}

