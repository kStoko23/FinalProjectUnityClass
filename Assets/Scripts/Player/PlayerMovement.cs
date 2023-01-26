using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedF = 10f;
    public float horiznotalInput;
    public int xRange = 48;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiznotalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speedF * horiznotalInput * Time.deltaTime*-1);

        if (transform.position.x < xRange*-1)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange*-1, transform.position.y, transform.position.z);
        }
    }
}
