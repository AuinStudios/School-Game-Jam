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
        if(currentFuel > maxFuel)
            currentFuel = maxFuel;
		
	}

    public void NoFuel(int amount)
    {
        if (currentSec > 0)
        {
            currentSec -= Time.deltaTime;
        }
        else
        {
            if (currentFuel > 0)
            {
                currentFuel -= amount;
                currentSec = WaitSec;
            }
        }
    }

}
