using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OilScript : MonoBehaviour
{
    public PlayerFuel playerFuel;
    public int refill;
    public GameObject Oil; 
    public GameObject popupfuel;

    // Start is called before the first frame update
     public void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.tag == "Player")
    {
      playerFuel.Refill(3);
      Instantiate(popupfuel, transform.position, Quaternion.identity);
    }	
    }
}
