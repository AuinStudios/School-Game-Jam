using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdDamage : MonoBehaviour
{
   public PlayerHealth playerhealth;
   public int damage = 1;
   public GameObject PopUpDamage;
   private Shake shake;
   //public Transform spawnpoint;
   //public GameObject damageText;
   void Start()
   {
       shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
   }

   public void OnCollisionEnter2D(Collision2D other)
   {
       if(other.gameObject.tag == "Player")
       {
           playerhealth.currentHealth -= damage;
           Instantiate(PopUpDamage, transform.position, Quaternion.identity);
            shake.CamShake();
           //DamageIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<DamageIndicator>();
           //indicator.SetDamageTest(damage);
           
       }
   }
}
