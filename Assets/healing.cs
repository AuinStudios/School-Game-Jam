using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healing : MonoBehaviour
{
    public PlayerHealth playerhealth;
    [SerializeField]  int heal;
    public GameObject popupheal;
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Instantiate(popupheal, transform.position, Quaternion.identity);
            playerhealth.Healing(heal);
        }
    }
}
