using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ShootingRockets : MonoBehaviour
{
    public GameObject alienShip;
    public GameObject rocket;
    public float rocketVelocity = 750f;
    public int rocketsAlive = 0;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (rocketsAlive == 0)
            {
                GameObject projectile = Instantiate(rocket, transform.position, transform.rotation);
                projectile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0,rocketVelocity));
                rocketsAlive++;    
            }
        }
        
        if (rocketsAlive == 1)
        {
            if (GameObject.Find("PlayerRocket(Clone)") == null)
            {
                rocketsAlive = 0;
            }
        }
    }
}
