using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public PlayerFuel playerFuel;
    public float movespeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        ProcessInputes();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputes()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        if (playerFuel.currentFuel != 0)
        {
            moveDirection = new Vector2(moveX, moveY).normalized;
        }
        else
        {
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
        if (col.gameObject.name=="Oil")
        {
            Destroy(col.gameObject);
        }
    }
}
