using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public float rocketVelocity = 750f;
    public float fireRate = 3f;
    public Transform bulletSpawn;
    public GameObject barierWall;

    void Start()
    {
        InvokeRepeating("Fire", fireRate, fireRate);
    }

    void Fire()
    {
        GameObject projectile = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        projectile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, rocketVelocity));
    }
}
