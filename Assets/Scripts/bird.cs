using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float speed = 4.5f;
    private Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        

    }

    // Update is called once per frame
    void Update()
    {
        
        //if(transform.position.x < screenBounds.x * 100000)
        {
            //Destroy(this.gameObject);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="bullet"){
            transform.position = new Vector2 (transform.position.x+5f , transform.position.y);
        }
    }
    
    

    public void deathanim(){
        Physics2D.Raycast(transform.position, Vector2.down, 0.6f);
    }
}
