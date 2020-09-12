using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Vector3 explosionPosition = transform.position;
        // explosionPosition[1] = 
        // Debug.Log(explosionPosition);
        GameObject effect= Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, .25f);
        Destroy(gameObject);
    }
}
