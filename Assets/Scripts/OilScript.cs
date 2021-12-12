﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OilScript : MonoBehaviour
{
    public PlayerFuel playerFuel;
    public int refill;
    public GameObject Oil; 

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        playerFuel.Refill(refill);
    }
}