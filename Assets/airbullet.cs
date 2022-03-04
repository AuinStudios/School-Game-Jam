using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airbullet : MonoBehaviour
{
   public float airSpeed = 15f;
   public float airDamage = 2f;
   public Rigidbody2D rb;


   private void FixedUpdate(){
       rb.velocity = Vector2.right * airSpeed;
   }

   private void OnCollisionEnter2D(Collision2D collision){
        /*if(collision.gameObject.tag=="bird"){
            //Destroy(collision.gameObject);
        }*/
        gameObject.SetActive(false);
   }
}
