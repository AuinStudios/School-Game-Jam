using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private SkinManager skinManager;
    public PlayerFuel playerFuel;
    public float movespeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = skinManager.GetSelectedSkin().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputes();
        if(Input.GetKey("w")||Input.GetKey(KeyCode.UpArrow))
            rb.gravityScale = 2.8f;
        else
            rb.gravityScale = 4f;
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputes()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        if(playerFuel.currentFuel != 0)
        {
            moveDirection = new Vector2(moveX, moveY).normalized;
        }
        /*else if(playerFuel.currentFuel <= 10)
        {
            movespeed = 2.75f;
            moveDirection = new Vector2(moveX, moveY).normalized;
        }
        else if(playerFuel.currentFuel >= 5 && playerFuel.currentFuel <= 10)
        {
            movespeed = 2.5f;
            moveDirection = new Vector2(moveX, moveY).normalized;
        }
        else if(playerFuel.currentFuel > 1 && playerFuel.currentFuel < 5)
        {
            movespeed = 2.25f;
            moveDirection = new Vector2(moveX, moveY).normalized;
        }*/
        else
        {
           // movespeed = 2.0f;
            moveY = 0;
            moveDirection = new Vector2(moveX, moveY).normalized;
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x*movespeed, moveDirection.y*movespeed);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="Fuel")
        {
            Destroy(col.gameObject);
        }
    }
}
