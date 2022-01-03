using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
	public Button PauseButton;
	public UnityEngine.Sprite lay3_0;
	public UnityEngine.Sprite lay3_1;
	bool isPaused = false;
    public void pauseGame(){
        if(isPaused){
			Time.timeScale = 1;
			isPaused = false;
			PauseButton.image.sprite = lay3_0;
		}
		else
		{
			Time.timeScale = 0;
			isPaused = true;
			PauseButton.image.sprite = lay3_1;
		}
    } 
}
