using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //public GameObject hitEffect; for when there is an animation

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f); for when there is an animation
        Destroy(gameObject);
    }
}
