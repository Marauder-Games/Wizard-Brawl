using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefabStraight;
    public GameObject bulletPrefabCurve;

    public float bulletForceStraight = 20f;
    public float bulletForceCurve = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootStraight();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ShootCurve();
        }
    }

    void ShootStraight()
    {
        GameObject bullet = Instantiate(bulletPrefabStraight, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForceStraight, ForceMode2D.Impulse);
    }

    void ShootCurve()
    {
        GameObject bullet = Instantiate(bulletPrefabCurve, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForceCurve, ForceMode2D.Impulse);
    }
}
