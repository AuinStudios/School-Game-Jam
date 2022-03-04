using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    public PlayerFuel playerFuel;
    public Image UISprite;
    public Slider Fuel;
    // Start is called before the first frame update
    void Start()
    {
        Fuel = GetComponent<Slider>();
        //Fuel.maxValue=playerFuel.maxFuel;
        Fuel.value=Fuel.maxValue;
    }

    void Update()
    {
        if (Fuel.value <= Fuel.minValue)
        {
            UISprite.enabled = false;
        }
        if (Fuel.value > Fuel.minValue && !UISprite.enabled)
        {
            UISprite.enabled = true;
        }
        float verticalValue = Input.GetAxis("Vertical");
        if (verticalValue != 0)
        {
            playerFuel.NoFuel(1);
        }
        //float fillValue = playerFuel.currentFuel * Fuel.maxValue / playerFuel.maxFuel;
        //Fuel.value = fillValue;
        Fuel.value=playerFuel.currentFuel;
    }
}
