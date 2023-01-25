using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRockets : MonoBehaviour
{
    public GameObject rocket;
    public float rocketVelocity = 750f;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject projectile = Instantiate(rocket, transform.position, transform.rotation);
            projectile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0,rocketVelocity));
        }
    }
}
