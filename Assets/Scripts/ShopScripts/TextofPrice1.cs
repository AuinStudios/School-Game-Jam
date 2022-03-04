using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextofPrice1 : MonoBehaviour
{
    public Text Text;
    private int Amount;
    // Start is called before the first frame update
    void Start()
    {
       Amount = PlayerPrefs.GetInt("Fprice");
    }

    // Update is called once per frame
    void Update()
    {
        Text.text=""+Amount;
        Amount = PlayerPrefs.GetInt("Fprice");
    }
}
