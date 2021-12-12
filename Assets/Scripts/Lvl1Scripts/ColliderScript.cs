using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public PlayerHealth playerhealth;

    public GameObject gameoverpanel;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerhealth.currentHealth = 0;
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);
            


        }
    }
}
