using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallySpeak : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    //public GameObject all;
    public GameObject wally;
    public GameObject continueButton;
    public GameObject panel;
    public GameObject Youwin;
    public PlayerFuel Fuel;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Fuel.currentFuel = 10;
            panel.SetActive(true);
            wally.SetActive(true);
            StartCoroutine(Type());
           
        }
    }

    /*void Start()
    {
        //all.SetActive(false);
        panel.SetActive(true);
        wally.SetActive(true);
        StartCoroutine(Type());
    }*/

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if(index< sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
           
            textDisplay.text = "";
            panel.SetActive(false);
            wally.SetActive(false);
            Youwin.SetActive(true);
            
        }
        /*if(index> sentences.Length)
        {
            all.SetActive(true);
        }*/
    }
}
