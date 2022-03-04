using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneDam : MonoBehaviour
{
   public float WaitSec=2;
   public float currentSec;
   public GameObject PopUpDamage;
   public PlayerHealth playerhealth;
   public int damage = 2;
   public Shake shake;

   public void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.tag == "Player")
       {
	   if (currentSec > 0)
           {
            currentSec -= Time.deltaTime;
           }
           else
            {
                playerhealth.currentHealth -= damage;
                currentSec = WaitSec;
                Instantiate(PopUpDamage, transform.position, Quaternion.identity);
                shake.CamShake();
             }
           
       }
   }
}
