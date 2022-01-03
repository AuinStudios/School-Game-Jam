using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Texts : MonoBehaviour
{
    private int i;
    private float WaitSec;
    private float currentSec;
    public Text textElement;
    private string current;
    public PlayerFuel playerFuel;
    private string[ ] textValue = new string[]{
        "Welcome to the tutorial!!",                                                                                            //0
        "By pressing WASD you can move the balloon",                                                                            //1
        "Great!",                                                                                                               //2
        "On the top left is your fuel and your health",                                                                         //3
        "Your fuel shrinks while you move up and down and your health when you are out of fuel",                                //4
        "There is a can on your way that will refill your fuel tank",                                                           //5
        "On the top right is the pause button",                                                                                 //6
        "On your way to Deliver the packages you will find many enemies. Some of them are Birds, Wind generators and rockets!"  //7    
    }; 
    // Start is called before the first frame update
    void Start()
    {
        i=0;
        WaitSec=1;
        Time.timeScale=1; 
        currentSec = WaitSec;
        StartCoroutine(speechtypewriter());
    }

    // Update is called once per frame
    void Update()
    {
        if(i<4){
            Time.timeScale=1; 
            playerFuel.Refill(1000);
            Speech();
            playerFuel.Refill(1000);
            if(i==4)
                playerFuel.currentFuel=playerFuel.maxFuel;
        }
        else if(i<5){
            Time.timeScale=1; 
            Speech();
        }
        else{
            Speech();
        }
    }
    private IEnumerator speechtypewriter()
    {
        int d = 0; 
        WaitForSeconds wait = new WaitForSeconds(0.1f);
        WaitForFixedUpdate waitmore = new WaitForFixedUpdate();
        while (d < textValue[i].Length)
        {
                for (int b = 0; b <=  textValue[i].Length; b++)
                {
                  d = b;
                   current= textValue[i].Substring(0, b);
                      textElement.text = current;
                currentSec=WaitSec;
                   yield return wait;
                }
            yield return waitmore;
        }
                 
               
        
    }
    private void Speech(){
        if (currentSec > 0)
        {
            currentSec -= Time.deltaTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Return)){
                i++;
                StartCoroutine(speechtypewriter());
                        
            }
          
            
            
        }
    }
}
