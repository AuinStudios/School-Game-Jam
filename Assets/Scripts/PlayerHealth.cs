using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public float WaitSec;
    public float currentSec;
    public GameObject gameoverpanel;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentSec = WaitSec;
    }

    public void Damage(int amount)
    {
        currentHealth -= amount;
    }

    public void NoHealth(int amount)
    {
        if (WaitSec > 0)
        {
            WaitSec -= Time.deltaTime;

        }
        else
        {
            if (currentHealth > 0)
            {
                currentHealth -= amount;
                WaitSec = currentSec;
            }
            else if (currentHealth == 0)
            {
                Time.timeScale = 0;
                gameoverpanel.SetActive(true);
                
            }
        }
    }
}
