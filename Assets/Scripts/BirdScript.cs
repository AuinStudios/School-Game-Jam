using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage;

    void OnTriggerEnter2D(Collider2D col)
    {
        playerHealth.Damage(damage);
    }
}
