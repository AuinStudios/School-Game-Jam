using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool hit;
    private CircleCollider2D circleCollider;

    private void Awake(){
        circleCollider = GetComponent<CircleCollider2D>();
    }

    private void Update(){
        if(hit) return;
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed,0,0);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        hit = true;
        circleCollider.enabled = false;
    }

    public void SetDirection(float _direction){
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        circleCollider.enabled = true;
    }

    
}
