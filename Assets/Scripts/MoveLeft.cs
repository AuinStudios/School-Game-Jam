using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    float vaccinewidth;
    BoxCollider2D box;

    void Start()
    {
        if(gameObject.CompareTag("bird"))
        {
            vaccinewidth = GameObject.FindGameObjectWithTag("bird").GetComponent<BoxCollider2D>().size.x;
        }
    }

    void Update()
    {
        transform.position = new Vector2(
        transform.position.x - speed * Time.deltaTime, 
        transform.position.y);
        if(gameObject.CompareTag("bird"))      
        {
            if((transform.position.x < GameManager.bottomLeft.x - vaccinewidth))
            {
                //Destroy(gameObject);
            }
        }
    }
}
