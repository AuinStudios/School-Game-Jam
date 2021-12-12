using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnemScript : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int Damage;

    void OnTriggerEnter2D(Collider2D col)
    {
        playerHealth.Damage(Damage);
    }
}
