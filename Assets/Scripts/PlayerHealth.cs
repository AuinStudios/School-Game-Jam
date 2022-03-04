using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth = 10;
    public float WaitSec;
    public float currentSec;
    public HealthScript script;
    public GameObject gameoverpanel;
    public GameObject PopUpDamage;
    public GameObject popupdamage2;
    


    // Start is called before the first frame update
    void Start()
    {
       // maxHealth=PlayerPrefs.GetInt("Hp");
        currentHealth = maxHealth;
        currentSec = WaitSec;
        script.Health.maxValue=maxHealth;
    }
    
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Rocket")
            {
                currentHealth = 0;
                gameoverpanel.SetActive(true);
                Instantiate(PopUpDamage, transform.position, Quaternion.identity);
                Time.timeScale = 0;
            }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "stillos")
        {
            Instantiate(popupdamage2, transform.position, Quaternion.identity);
        }
    }


    public void Healing(int amount)
    {
        currentHealth += amount;
        if(currentHealth > maxHealth)
            currentHealth = maxHealth;
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
            else if (currentHealth <= 0)
            {
                Time.timeScale = 0;
                gameoverpanel.SetActive(true);   
            }
            else if(currentHealth == 0)
            {
                Time.timeScale = 0;
                gameoverpanel.SetActive(true);  
            }
        }
    }
}
