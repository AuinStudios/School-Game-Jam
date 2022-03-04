using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthScript : MonoBehaviour
{
    public PlayerFuel playerFuel;
    public PlayerHealth playerHealth;
    public Image UISprite;
    public Slider Health;

    // Start is called before the first frame update
    void Start()
    {
        Health = GetComponent<Slider>();
        Health.value=Health.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.value <= Health.minValue)
        {
            UISprite.enabled = false;
        }
        if (Health.value > Health.minValue && !UISprite.enabled)
        {
            UISprite.enabled = true;
        }
        //float fillValue = playerHealth.currentHealth * Health.maxValue /playerHealth.maxHealth;
        float fillValue=playerHealth.currentHealth;
        if (playerFuel.currentFuel == 0)
        {
            playerHealth.NoHealth(1);
        }
        if (fillValue <= Health.maxValue / 3)
        {
            UISprite.color = Color.red;
        }
        else if (fillValue > Health.maxValue / 3)
        {
            UISprite.color = Color.green;
        }
        Health.value = fillValue;
        //Health.value=playerHealth.currentHealth;
    }
}
