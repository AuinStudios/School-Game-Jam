using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFuel : MonoBehaviour
{
    public int maxFuel;
    public int currentFuel;
    public float WaitSec;
    public float currentSec;

    // Start is called before the first frame update
    void Start()
    {
        currentFuel = maxFuel;
        currentSec = WaitSec;
    }

    public void Refill(int amount)
    {
        currentFuel += amount;
    }

    public void NoFuel(int amount)
    {
        if (WaitSec > 0)
        {
            WaitSec -= Time.deltaTime;

        }
        else
        {
            if (currentFuel > 0)
            {
                currentFuel -= amount;
                WaitSec = currentSec;
            }
        }
    }

}
