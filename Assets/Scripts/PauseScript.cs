using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
	public Button PauseButton;
	public GameObject Menupanel;
	

    public void pauseGame(){
			Time.timeScale = 0;

			Menupanel.SetActive(true);	
    } 
}
