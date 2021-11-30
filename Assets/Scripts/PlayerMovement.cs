using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10);
        }
        if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.down * 10);
        }
        if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 10);
        }
        if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 10);
        }
    }
}