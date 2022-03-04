using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextofPrice2 : MonoBehaviour
{
    public Text Text;
    private int Amount;
    // Start is called before the first frame update
    void Start()
    {
       Amount = PlayerPrefs.GetInt("Hp_price");
    }

    // Update is called once per frame
    void Update()
    {
        Text.text=""+Amount;
        Amount = PlayerPrefs.GetInt("Hp_price");
    }
}
