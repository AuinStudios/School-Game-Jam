﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdDamage : MonoBehaviour
{
   public PlayerHealth playerhealth;

   public void OnCollisionEnter2D(Collision2D other)
   {
       if(other.gameObject.tag == "Player")
       {
           playerhealth.currentHealth -= 1;
       }
   }
}
