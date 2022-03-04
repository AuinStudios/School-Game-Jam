using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextofFuel : MonoBehaviour
{
    public Text Text;
    private int Amount;
    // Start is called before the first frame update
    void Start()
    {
       Amount = PlayerPrefs.GetInt("Fuel");
    }

    // Update is called once per frame
    void Update()
    {
        Text.text=""+Amount;
        Amount = PlayerPrefs.GetInt("Fuel");
    }
}
